namespace soprogresso
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.lbox = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(69, 270);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(178, 76);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Grava";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(222, 186);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 20);
            this.txtbox.TabIndex = 1;
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(484, 54);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(304, 342);
            this.lbox.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(290, 270);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(153, 76);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Calcula";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label1;
    }
}

