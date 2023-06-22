namespace Server
{
    partial class Form_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Server));
            this.label_Status = new System.Windows.Forms.Label();
            this.button_Upload = new System.Windows.Forms.Button();
            this.richTextBox_Display = new System.Windows.Forms.RichTextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(89, 49);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status";
            
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(92, 299);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(75, 23);
            this.button_Upload.TabIndex = 1;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = true;
            this.button_Upload.Click += new System.EventHandler(this.button_Upload_Click);
            // 
            // richTextBox_Display
            // 
            this.richTextBox_Display.Location = new System.Drawing.Point(92, 74);
            this.richTextBox_Display.Name = "richTextBox_Display";
            this.richTextBox_Display.Size = new System.Drawing.Size(572, 219);
            this.richTextBox_Display.TabIndex = 2;
            this.richTextBox_Display.Text = "";
            this.richTextBox_Display.TextChanged += new System.EventHandler(this.richTextBox_Display_TextChanged);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(561, 299);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
            this.pictureBox_Image.Location = new System.Drawing.Point(642, 300);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 4;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.Click += new System.EventHandler(this.pictureBox_Image_Click);
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(186, 301);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(369, 20);
            this.textBox_Text.TabIndex = 5;
            this.textBox_Text.TextChanged += new System.EventHandler(this.textBox_Text_TextChanged);
            this.textBox_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.richTextBox_Display);
            this.Controls.Add(this.button_Upload);
            this.Controls.Add(this.label_Status);
            this.Name = "Form_Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form_Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.RichTextBox richTextBox_Display;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.TextBox textBox_Text;
    }
}

