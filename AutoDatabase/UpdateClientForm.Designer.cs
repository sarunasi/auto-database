namespace AutoDatabase
{
    partial class UpdateClientForm
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
            this.textClient1 = new System.Windows.Forms.TextBox();
            this.textClient2 = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientSurname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textClient1
            // 
            this.textClient1.BackColor = System.Drawing.SystemColors.Window;
            this.textClient1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClient1.Location = new System.Drawing.Point(24, 67);
            this.textClient1.Name = "textClient1";
            this.textClient1.ReadOnly = true;
            this.textClient1.Size = new System.Drawing.Size(67, 13);
            this.textClient1.TabIndex = 19;
            this.textClient1.Text = "Vardas";
            // 
            // textClient2
            // 
            this.textClient2.BackColor = System.Drawing.SystemColors.Window;
            this.textClient2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textClient2.Location = new System.Drawing.Point(24, 93);
            this.textClient2.Name = "textClient2";
            this.textClient2.ReadOnly = true;
            this.textClient2.Size = new System.Drawing.Size(67, 13);
            this.textClient2.TabIndex = 18;
            this.textClient2.Text = "Pavarde";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(97, 64);
            this.textBoxClientName.MaxLength = 50;
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(224, 20);
            this.textBoxClientName.TabIndex = 17;
            // 
            // textBoxClientSurname
            // 
            this.textBoxClientSurname.Location = new System.Drawing.Point(97, 90);
            this.textBoxClientSurname.MaxLength = 50;
            this.textBoxClientSurname.Name = "textBoxClientSurname";
            this.textBoxClientSurname.Size = new System.Drawing.Size(224, 20);
            this.textBoxClientSurname.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(24, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(67, 13);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Telefonas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(24, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 13);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Adresas";
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Location = new System.Drawing.Point(145, 179);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(123, 35);
            this.buttonUpdateClient.TabIndex = 13;
            this.buttonUpdateClient.Text = "Atnaujinti duomenis";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(97, 142);
            this.textBoxTelephone.MaxLength = 30;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(224, 20);
            this.textBoxTelephone.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(97, 116);
            this.textBoxAddress.MaxLength = 50;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(224, 20);
            this.textBoxAddress.TabIndex = 11;
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 237);
            this.Controls.Add(this.textClient1);
            this.Controls.Add(this.textClient2);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxClientSurname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxAddress);
            this.Name = "UpdateClientForm";
            this.Text = "UpdateClientForm";
            this.Load += new System.EventHandler(this.UpdateClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textClient1;
        private System.Windows.Forms.TextBox textClient2;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientSurname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}