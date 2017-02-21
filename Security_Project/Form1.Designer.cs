namespace Security_Project
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
            this.Message = new System.Windows.Forms.TextBox();
            this.Encryptmessage = new System.Windows.Forms.TextBox();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.decryptbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Decryptmessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(185, 42);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(320, 20);
            this.Message.TabIndex = 0;
            // 
            // Encryptmessage
            // 
            this.Encryptmessage.Location = new System.Drawing.Point(185, 86);
            this.Encryptmessage.Name = "Encryptmessage";
            this.Encryptmessage.Size = new System.Drawing.Size(320, 20);
            this.Encryptmessage.TabIndex = 1;
            // 
            // encryptbutton
            // 
            this.encryptbutton.Location = new System.Drawing.Point(219, 220);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(139, 30);
            this.encryptbutton.TabIndex = 2;
            this.encryptbutton.Text = "Encrypt Button";
            this.encryptbutton.UseVisualStyleBackColor = true;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // decryptbutton
            // 
            this.decryptbutton.Location = new System.Drawing.Point(408, 220);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(130, 30);
            this.decryptbutton.TabIndex = 3;
            this.decryptbutton.Text = "Decrypt Button";
            this.decryptbutton.UseVisualStyleBackColor = true;
            this.decryptbutton.Click += new System.EventHandler(this.decryptbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypt Message";
            // 
            // Decryptmessage
            // 
            this.Decryptmessage.Location = new System.Drawing.Point(184, 134);
            this.Decryptmessage.Name = "Decryptmessage";
            this.Decryptmessage.Size = new System.Drawing.Size(321, 20);
            this.Decryptmessage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypt Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decryptmessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.Encryptmessage);
            this.Controls.Add(this.Message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox Encryptmessage;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.Button decryptbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Decryptmessage;
        private System.Windows.Forms.Label label3;
    }
}

