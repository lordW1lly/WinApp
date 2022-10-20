namespace WinApp
{
    partial class Ej_notas
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
            this.txtNotaUno = new System.Windows.Forms.TextBox();
            this.lblNotaUno = new System.Windows.Forms.Label();
            this.lblNotaDos = new System.Windows.Forms.Label();
            this.txtNotaDos = new System.Windows.Forms.TextBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNotaUno
            // 
            this.txtNotaUno.Location = new System.Drawing.Point(359, 58);
            this.txtNotaUno.Name = "txtNotaUno";
            this.txtNotaUno.Size = new System.Drawing.Size(207, 22);
            this.txtNotaUno.TabIndex = 0;
            this.txtNotaUno.Text = "Ingresa tu primer nota";
            // 
            // lblNotaUno
            // 
            this.lblNotaUno.AutoSize = true;
            this.lblNotaUno.Location = new System.Drawing.Point(260, 64);
            this.lblNotaUno.Name = "lblNotaUno";
            this.lblNotaUno.Size = new System.Drawing.Size(61, 16);
            this.lblNotaUno.TabIndex = 1;
            this.lblNotaUno.Text = "1er Nota:";
            this.lblNotaUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNotaDos
            // 
            this.lblNotaDos.AutoSize = true;
            this.lblNotaDos.Location = new System.Drawing.Point(260, 112);
            this.lblNotaDos.Name = "lblNotaDos";
            this.lblNotaDos.Size = new System.Drawing.Size(65, 16);
            this.lblNotaDos.TabIndex = 2;
            this.lblNotaDos.Text = "2da Nota:";
            // 
            // txtNotaDos
            // 
            this.txtNotaDos.Location = new System.Drawing.Point(359, 106);
            this.txtNotaDos.Name = "txtNotaDos";
            this.txtNotaDos.Size = new System.Drawing.Size(207, 22);
            this.txtNotaDos.TabIndex = 3;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(359, 158);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(207, 22);
            this.txtNotaTres.TabIndex = 4;
            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Location = new System.Drawing.Point(260, 161);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(61, 16);
            this.lblNotaTres.TabIndex = 5;
            this.lblNotaTres.Text = "3er Nota:";
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(441, 246);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(125, 45);
            this.bttnCalcular.TabIndex = 6;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // Ej_notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.lblNotaTres);
            this.Controls.Add(this.txtNotaTres);
            this.Controls.Add(this.txtNotaDos);
            this.Controls.Add(this.lblNotaDos);
            this.Controls.Add(this.lblNotaUno);
            this.Controls.Add(this.txtNotaUno);
            this.Name = "Ej_notas";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Ej_notas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotaUno;
        private System.Windows.Forms.Label lblNotaUno;
        private System.Windows.Forms.Label lblNotaDos;
        private System.Windows.Forms.TextBox txtNotaDos;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.Label lblNotaTres;
        private System.Windows.Forms.Button bttnCalcular;
    }
}