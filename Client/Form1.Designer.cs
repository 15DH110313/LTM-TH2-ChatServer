namespace Client
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.btn_music = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(415, 270);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(106, 63);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(431, 125);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(75, 37);
            this.btn_image.TabIndex = 11;
            this.btn_image.Text = "Images";
            this.btn_image.UseVisualStyleBackColor = true;
            // 
            // btn_music
            // 
            this.btn_music.Location = new System.Drawing.Point(431, 82);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(75, 37);
            this.btn_music.TabIndex = 12;
            this.btn_music.Text = "Musics";
            this.btn_music.UseVisualStyleBackColor = true;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(431, 39);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 37);
            this.btn_file.TabIndex = 13;
            this.btn_file.Text = "Files";
            this.btn_file.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 199);
            this.listBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 270);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 63);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client IP";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(199, 8);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 25);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_music);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connect;
    }
}

