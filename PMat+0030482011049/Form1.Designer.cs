namespace PMat_0030482011049
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EXE = new System.Windows.Forms.Button();
            this.LBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EXE
            // 
            this.EXE.Location = new System.Drawing.Point(126, 124);
            this.EXE.Name = "EXE";
            this.EXE.Size = new System.Drawing.Size(75, 23);
            this.EXE.TabIndex = 0;
            this.EXE.Text = "Ok";
            this.EXE.UseVisualStyleBackColor = true;
            this.EXE.Click += new System.EventHandler(this.EXE_Click);
            // 
            // LBox
            // 
            this.LBox.FormattingEnabled = true;
            this.LBox.Location = new System.Drawing.Point(385, 20);
            this.LBox.Name = "LBox";
            this.LBox.Size = new System.Drawing.Size(376, 537);
            this.LBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.LBox);
            this.Controls.Add(this.EXE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXE;
        private System.Windows.Forms.ListBox LBox;
    }
}

