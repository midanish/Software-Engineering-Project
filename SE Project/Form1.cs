using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace SE_Project
{
    public partial class Form_Client : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private bool isConnected = false;

        private readonly object ClipboardLock = new object();

        public Form_Client()
        {
            InitializeComponent();
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            // Initialize client connection
            client = new TcpClient();
            // Set up your IP address and port
            string ipAddress = "127.0.0.1";
            int port = 12345;
            try
            {
                client.Connect(ipAddress, port);
                NetworkStream networkStream = client.GetStream();
                reader = new StreamReader(networkStream);
                writer = new StreamWriter(networkStream);
                writer.AutoFlush = true;

                // Start listening for incoming messages from the server
                Task.Run(() => ReceiveMessages());

                // Set the connection status to true
                isConnected = true;

                // Display the connection status message
                DisplayConnectionStatus("Successfully connected to the server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
            }
        }
        private void DisplayConnectionStatus(string message)
        {
            richTextBox_Display.Invoke(new Action(() =>
            {
                richTextBox_Display.AppendText(message + Environment.NewLine);
            }));
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Form_Client_Load(sender, e);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            string message = textBox_Text.Text;
            SendMessage(message);
            textBox_Text.Clear();
        }

        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button_Send_Click(sender, e);
            }
        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                SendImage(imagePath);
            }
        }

        private void richTextBox_Display_TextChanged(object sender, EventArgs e)
        {
            // You can add any additional logic here if needed
        }

        private void textBox_Text_TextChanged(object sender, EventArgs e)
        {
            // You can add any additional logic here if needed
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    string message = reader.ReadLine();

                    if (IsBase64Image(message))
                    {
                        // Received image
                        DisplayImageFromBase64(message);
                    }
                    else
                    {
                        // Received message
                        DisplayMessage("Server: " + message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving message: " + ex.Message);
            }
        }

        private bool IsBase64Image(string message)
        {
            // Check if the message is a valid base64 encoded image
            try
            {
                byte[] imageBytes = Convert.FromBase64String(message);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image.FromStream(ms);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void DisplayImageFromBase64(string base64Image)
        {
            pictureBox_Image.Invoke(new Action(() =>
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(base64Image);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        // Acquire lock to access the clipboard
                        lock (ClipboardLock)
                        {
                            Clipboard.SetImage(image);
                            richTextBox_Display.Paste();
                            richTextBox_Display.AppendText(Environment.NewLine);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying image: " + ex.Message);
                }
            }));
        }



        private void SendMessage(string message)
        {
            if (isConnected)
            {
                writer.WriteLine(message);
                DisplayMessage("You: " + message);
            }
            else
            {
                MessageBox.Show("It is not connected to the server. Press the connect button to connect to the server");
            }
        }
        private void SendImage(string imagePath)
        {
            if (isConnected)
            {
                try
                {
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    string base64Image = Convert.ToBase64String(imageData);

                    // Acquire lock to access the clipboard
                    lock (ClipboardLock)
                    {
                        writer.WriteLine(base64Image);
                    }

                    DisplayImage(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("It is not connected to the server. Press the connect button to connect to the server");
            }
        }

        private void DisplayMessage(string message)
        {
            richTextBox_Display.Invoke(new Action(() =>
            {
                richTextBox_Display.AppendText(message + Environment.NewLine);
            }));
        }

        private void DisplayImage(string imagePath)
        {
            
                pictureBox_Image.Invoke(new Action(() =>
                {
                    Image image = Image.FromFile(imagePath);
                    Clipboard.SetImage(image);
                    richTextBox_Display.Paste();
                    richTextBox_Display.AppendText(Environment.NewLine);
                }));
            
        }

        private void button_Upload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string chatHistory = richTextBox_Display.Text;
                File.WriteAllText(filePath, chatHistory);
                MessageBox.Show("Chat history saved successfully!");
            }
        }
    }
}