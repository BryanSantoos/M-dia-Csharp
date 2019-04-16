namespace WindowsFormsApp1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtav2 = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.lblav1 = new System.Windows.Forms.Label();
            this.lblav2 = new System.Windows.Forms.Label();
            this.lblmedia = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.txtav1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncalcular.Location = new System.Drawing.Point(156, 63);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnlimpar.Location = new System.Drawing.Point(156, 90);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            // 
            // txtav2
            // 
            this.txtav2.Location = new System.Drawing.Point(99, 92);
            this.txtav2.Name = "txtav2";
            this.txtav2.Size = new System.Drawing.Size(51, 20);
            this.txtav2.TabIndex = 4;
            this.txtav2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtav2.TextChanged += new System.EventHandler(this.txtav2_TextChanged);
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(99, 119);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(51, 20);
            this.txtmedia.TabIndex = 5;
            this.txtmedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblav1
            // 
            this.lblav1.AutoSize = true;
            this.lblav1.BackColor = System.Drawing.SystemColors.Control;
            this.lblav1.Location = new System.Drawing.Point(58, 69);
            this.lblav1.Name = "lblav1";
            this.lblav1.Size = new System.Drawing.Size(30, 13);
            this.lblav1.TabIndex = 6;
            this.lblav1.Text = "AV 1";
            this.lblav1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblav1.UseMnemonic = false;
            this.lblav1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblav2
            // 
            this.lblav2.AutoSize = true;
            this.lblav2.Location = new System.Drawing.Point(58, 96);
            this.lblav2.Name = "lblav2";
            this.lblav2.Size = new System.Drawing.Size(30, 13);
            this.lblav2.TabIndex = 7;
            this.lblav2.Text = "AV 2";
            this.lblav2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblav2.Click += new System.EventHandler(this.lblav2_Click);
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblmedia.Location = new System.Drawing.Point(55, 123);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(36, 13);
            this.lblmedia.TabIndex = 8;
            this.lblmedia.Text = "Média";
            this.lblmedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsair.Location = new System.Drawing.Point(156, 118);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // txtav1
            // 
            this.txtav1.Location = new System.Drawing.Point(99, 65);
            this.txtav1.Name = "txtav1";
            this.txtav1.Size = new System.Drawing.Size(51, 20);
            this.txtav1.TabIndex = 3;
            this.txtav1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtav1.TextChanged += new System.EventHandler(this.txtav1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.lblav2);
            this.Controls.Add(this.lblav1);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtav2);
            this.Controls.Add(this.txtav1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtav2;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label lblav1;
        private System.Windows.Forms.Label lblav2;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtav1;
    }
}

