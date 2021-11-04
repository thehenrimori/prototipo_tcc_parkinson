namespace EsqueletoUsuario
{
    partial class Frm_Instrucao
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tronco = new System.Windows.Forms.Button();
            this.btn_postura = new System.Windows.Forms.Button();
            this.btn_marcha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA UM DOS EXERCÍCIOS ABAIXO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_tronco
            // 
            this.btn_tronco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tronco.Location = new System.Drawing.Point(274, 92);
            this.btn_tronco.Name = "btn_tronco";
            this.btn_tronco.Size = new System.Drawing.Size(262, 74);
            this.btn_tronco.TabIndex = 1;
            this.btn_tronco.Text = "EXERCÍCIO TRONCO";
            this.btn_tronco.UseVisualStyleBackColor = true;
            this.btn_tronco.Click += new System.EventHandler(this.btn_tronco_Click);
            // 
            // btn_postura
            // 
            this.btn_postura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_postura.Location = new System.Drawing.Point(274, 220);
            this.btn_postura.Name = "btn_postura";
            this.btn_postura.Size = new System.Drawing.Size(262, 74);
            this.btn_postura.TabIndex = 2;
            this.btn_postura.Text = "EXERCÍCIO POSTURA";
            this.btn_postura.UseVisualStyleBackColor = true;
            this.btn_postura.Click += new System.EventHandler(this.btn_postura_Click);
            // 
            // btn_marcha
            // 
            this.btn_marcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcha.Location = new System.Drawing.Point(274, 344);
            this.btn_marcha.Name = "btn_marcha";
            this.btn_marcha.Size = new System.Drawing.Size(262, 74);
            this.btn_marcha.TabIndex = 3;
            this.btn_marcha.Text = "EXERCÍCIO MARCHA";
            this.btn_marcha.UseVisualStyleBackColor = true;
            this.btn_marcha.Click += new System.EventHandler(this.btn_marcha_Click);
            // 
            // Frm_Instrucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_marcha);
            this.Controls.Add(this.btn_postura);
            this.Controls.Add(this.btn_tronco);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Instrucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intruções";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tronco;
        private System.Windows.Forms.Button btn_postura;
        private System.Windows.Forms.Button btn_marcha;
    }
}