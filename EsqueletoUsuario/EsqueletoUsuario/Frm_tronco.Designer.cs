namespace EsqueletoUsuario
{
    partial class Frm_tronco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_tronco));
            this.lbl_inicial = new System.Windows.Forms.Label();
            this.lbl_movimento = new System.Windows.Forms.Label();
            this.pictureTronco_2 = new System.Windows.Forms.PictureBox();
            this.pictureTronco_1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTronco_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTronco_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_inicial
            // 
            this.lbl_inicial.AutoSize = true;
            this.lbl_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicial.Location = new System.Drawing.Point(2, 20);
            this.lbl_inicial.Name = "lbl_inicial";
            this.lbl_inicial.Size = new System.Drawing.Size(780, 144);
            this.lbl_inicial.TabIndex = 0;
            this.lbl_inicial.Text = resources.GetString("lbl_inicial.Text");
            this.lbl_inicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_movimento
            // 
            this.lbl_movimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movimento.Location = new System.Drawing.Point(2, 297);
            this.lbl_movimento.Name = "lbl_movimento";
            this.lbl_movimento.Size = new System.Drawing.Size(791, 203);
            this.lbl_movimento.TabIndex = 2;
            this.lbl_movimento.Text = resources.GetString("lbl_movimento.Text");
            // 
            // pictureTronco_2
            // 
            this.pictureTronco_2.Image = global::EsqueletoUsuario.Properties.Resources.tronco_2;
            this.pictureTronco_2.Location = new System.Drawing.Point(832, 297);
            this.pictureTronco_2.Name = "pictureTronco_2";
            this.pictureTronco_2.Size = new System.Drawing.Size(220, 227);
            this.pictureTronco_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTronco_2.TabIndex = 3;
            this.pictureTronco_2.TabStop = false;
            this.pictureTronco_2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureTronco_1
            // 
            this.pictureTronco_1.Image = global::EsqueletoUsuario.Properties.Resources.tronco_1;
            this.pictureTronco_1.Location = new System.Drawing.Point(832, 20);
            this.pictureTronco_1.Name = "pictureTronco_1";
            this.pictureTronco_1.Size = new System.Drawing.Size(220, 227);
            this.pictureTronco_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTronco_1.TabIndex = 1;
            this.pictureTronco_1.TabStop = false;
            this.pictureTronco_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 525);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(87, 39);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(211, 525);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(106, 39);
            this.btn_anterior.TabIndex = 5;
            this.btn_anterior.Text = "<--- Anterior ";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(323, 525);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(106, 39);
            this.btn_proximo.TabIndex = 6;
            this.btn_proximo.Text = "Próximo --->";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // Frm_tronco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 576);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.pictureTronco_2);
            this.Controls.Add(this.lbl_movimento);
            this.Controls.Add(this.pictureTronco_1);
            this.Controls.Add(this.lbl_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_tronco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tronco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTronco_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTronco_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inicial;
        private System.Windows.Forms.PictureBox pictureTronco_1;
        private System.Windows.Forms.Label lbl_movimento;
        private System.Windows.Forms.PictureBox pictureTronco_2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
    }
}