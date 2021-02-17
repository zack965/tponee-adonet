
namespace tponee
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DisplayName = new System.Windows.Forms.Button();
            this.DisplayNameAge = new System.Windows.Forms.Button();
            this.DisplayAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(495, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 228);
            this.listBox1.TabIndex = 0;
            // 
            // DisplayName
            // 
            this.DisplayName.Location = new System.Drawing.Point(162, 302);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(118, 46);
            this.DisplayName.TabIndex = 1;
            this.DisplayName.Text = "Display Name";
            this.DisplayName.UseVisualStyleBackColor = true;
            this.DisplayName.Click += new System.EventHandler(this.DisplayName_Click);
            // 
            // DisplayNameAge
            // 
            this.DisplayNameAge.Location = new System.Drawing.Point(601, 302);
            this.DisplayNameAge.Name = "DisplayNameAge";
            this.DisplayNameAge.Size = new System.Drawing.Size(148, 69);
            this.DisplayNameAge.TabIndex = 2;
            this.DisplayNameAge.Text = "Display Name and Age";
            this.DisplayNameAge.UseVisualStyleBackColor = true;
            this.DisplayNameAge.Click += new System.EventHandler(this.DisplayNameAge_Click);
            // 
            // DisplayAll
            // 
            this.DisplayAll.Location = new System.Drawing.Point(1008, 302);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(118, 46);
            this.DisplayAll.TabIndex = 3;
            this.DisplayAll.Text = "Display All";
            this.DisplayAll.UseVisualStyleBackColor = true;
            this.DisplayAll.Click += new System.EventHandler(this.DisplayAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 533);
            this.Controls.Add(this.DisplayAll);
            this.Controls.Add(this.DisplayNameAge);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DisplayName;
        private System.Windows.Forms.Button DisplayNameAge;
        private System.Windows.Forms.Button DisplayAll;
    }
}

