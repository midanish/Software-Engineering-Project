namespace SE_Project
{
    partial class Form_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.button_Upload = new System.Windows.Forms.Button();
            this.richTextBox_Display = new System.Windows.Forms.RichTextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(99, 303);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(75, 23);
            this.button_Upload.TabIndex = 0;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_Upload_Click);
            // 
            // richTextBox_Display
            // 
            this.richTextBox_Display.Location = new System.Drawing.Point(99, 63);
            this.richTextBox_Display.Name = "richTextBox_Display";
            this.richTextBox_Display.Size = new System.Drawing.Size(550, 234);
            this.richTextBox_Display.TabIndex = 1;
            this.richTextBox_Display.Text = "";
            this.richTextBox_Display.TextChanged += new System.EventHandler(this.richTextBox_Display_TextChanged);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(540, 303);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(99, 34);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 5;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
            this.pictureBox_Image.Location = new System.Drawing.Point(621, 303);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(27, 20);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 6;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.Click += new System.EventHandler(this.pictureBox_Image_Click);
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(207, 306);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(327, 20);
            this.textBox_Text.TabIndex = 7;
            this.textBox_Text.TextChanged += new System.EventHandler(this.textBox_Text_TextChanged);
            this.textBox_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.richTextBox_Display);
            this.Controls.Add(this.button_Upload);
            this.Name = "Form_Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.RichTextBox richTextBox_Display;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.TextBox textBox_Text;
    }
}

