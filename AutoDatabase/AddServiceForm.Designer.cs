namespace AutoDatabase
{
    partial class AddServiceForm
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
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.labelPavadinimas = new System.Windows.Forms.Label();
            this.labelKaina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(92, 35);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(131, 20);
            this.textBoxServiceName.TabIndex = 0;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(92, 72);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(66, 20);
            this.textBoxServicePrice.TabIndex = 1;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(107, 112);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(75, 23);
            this.buttonAddService.TabIndex = 2;
            this.buttonAddService.Text = "Pridėti";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // labelPavadinimas
            // 
            this.labelPavadinimas.AutoSize = true;
            this.labelPavadinimas.Location = new System.Drawing.Point(19, 38);
            this.labelPavadinimas.Name = "labelPavadinimas";
            this.labelPavadinimas.Size = new System.Drawing.Size(67, 13);
            this.labelPavadinimas.TabIndex = 3;
            this.labelPavadinimas.Text = "Pavadinimas";
            // 
            // labelKaina
            // 
            this.labelKaina.AutoSize = true;
            this.labelKaina.Location = new System.Drawing.Point(52, 75);
            this.labelKaina.Name = "labelKaina";
            this.labelKaina.Size = new System.Drawing.Size(34, 13);
            this.labelKaina.TabIndex = 4;
            this.labelKaina.Text = "Kaina";
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 147);
            this.Controls.Add(this.labelKaina);
            this.Controls.Add(this.labelPavadinimas);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServicePrice;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Label labelPavadinimas;
        private System.Windows.Forms.Label labelKaina;
    }
}