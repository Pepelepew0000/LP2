namespace VERIFICADORDETRIANGULOS
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
            this.L1 = new System.Windows.Forms.MaskedTextBox();
            this.L2 = new System.Windows.Forms.MaskedTextBox();
            this.L3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.Location = new System.Drawing.Point(116, 133);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(100, 20);
            this.L1.TabIndex = 0;
            // 
            // L2
            // 
            this.L2.Location = new System.Drawing.Point(116, 159);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(100, 20);
            this.L2.TabIndex = 1;
            // 
            // L3
            // 
            this.L3.Location = new System.Drawing.Point(116, 185);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(100, 20);
            this.L3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lados do triângulo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox L1;
        private System.Windows.Forms.MaskedTextBox L2;
        private System.Windows.Forms.MaskedTextBox L3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

