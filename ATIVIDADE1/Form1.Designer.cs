namespace CALCULARAIO
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
            this.rdbsoma = new System.Windows.Forms.RadioButton();
            this.rdbsub = new System.Windows.Forms.RadioButton();
            this.rdbdiv = new System.Windows.Forms.RadioButton();
            this.rdbmull = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbsoma
            // 
            this.rdbsoma.AutoSize = true;
            this.rdbsoma.Location = new System.Drawing.Point(56, 101);
            this.rdbsoma.Name = "rdbsoma";
            this.rdbsoma.Size = new System.Drawing.Size(52, 17);
            this.rdbsoma.TabIndex = 0;
            this.rdbsoma.TabStop = true;
            this.rdbsoma.Text = "Soma";
            this.rdbsoma.UseVisualStyleBackColor = true;
            // 
            // rdbsub
            // 
            this.rdbsub.AutoSize = true;
            this.rdbsub.Location = new System.Drawing.Point(56, 124);
            this.rdbsub.Name = "rdbsub";
            this.rdbsub.Size = new System.Drawing.Size(74, 17);
            this.rdbsub.TabIndex = 1;
            this.rdbsub.TabStop = true;
            this.rdbsub.Text = "Subtração";
            this.rdbsub.UseVisualStyleBackColor = true;
            // 
            // rdbdiv
            // 
            this.rdbdiv.AutoSize = true;
            this.rdbdiv.Location = new System.Drawing.Point(56, 147);
            this.rdbdiv.Name = "rdbdiv";
            this.rdbdiv.Size = new System.Drawing.Size(60, 17);
            this.rdbdiv.TabIndex = 2;
            this.rdbdiv.TabStop = true;
            this.rdbdiv.Text = "Divisão";
            this.rdbdiv.UseVisualStyleBackColor = true;
            // 
            // rdbmull
            // 
            this.rdbmull.AutoSize = true;
            this.rdbmull.Location = new System.Drawing.Point(56, 170);
            this.rdbmull.Name = "rdbmull";
            this.rdbmull.Size = new System.Drawing.Size(87, 17);
            this.rdbmull.TabIndex = 3;
            this.rdbmull.TabStop = true;
            this.rdbmull.Text = "Multiplicação";
            this.rdbmull.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(167, 286);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "RESULTADO";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(56, 66);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 20);
            this.txtb1.TabIndex = 7;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(170, 66);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 20);
            this.txtb2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 331);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbmull);
            this.Controls.Add(this.rdbdiv);
            this.Controls.Add(this.rdbsub);
            this.Controls.Add(this.rdbsoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbsoma;
        private System.Windows.Forms.RadioButton rdbsub;
        private System.Windows.Forms.RadioButton rdbdiv;
        private System.Windows.Forms.RadioButton rdbmull;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
    }
}

