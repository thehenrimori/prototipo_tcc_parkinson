namespace EsqueletoUsuario
{
    partial class Frm_Postura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Postura));
            this.lbl_inicial = new System.Windows.Forms.Label();
            this.lbl_movimento = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.picturePostura_4 = new System.Windows.Forms.PictureBox();
            this.picturePostura_3 = new System.Windows.Forms.PictureBox();
            this.btn_anterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePostura_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePostura_3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_inicial
            // 
            this.lbl_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicial.Location = new System.Drawing.Point(2, 20);
            this.lbl_inicial.Name = "lbl_inicial";
            this.lbl_inicial.Size = new System.Drawing.Size(845, 144);
            this.lbl_inicial.TabIndex = 1;
            this.lbl_inicial.Text = "Posicionamento Inicial \r\n\r\nPaciente em pé, com os pés levemente afastados, a cabe" +
    "ça \"olhando\" para frente e segurando um bastão.";
            this.lbl_inicial.Click += new System.EventHandler(this.lbl_inicial_Click);
            // 
            // lbl_movimento
            // 
            this.lbl_movimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movimento.Location = new System.Drawing.Point(2, 283);
            this.lbl_movimento.Name = "lbl_movimento";
            this.lbl_movimento.Size = new System.Drawing.Size(845, 203);
            this.lbl_movimento.TabIndex = 3;
            this.lbl_movimento.Text = resources.GetString("lbl_movimento.Text");
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 525);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(87, 39);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(323, 525);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(106, 39);
            this.btn_proximo.TabIndex = 7;
            this.btn_proximo.Text = "Próximo --->";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // picturePostura_4
            // 
            this.picturePostura_4.Image = global::EsqueletoUsuario.Properties.Resources.postura_4;
            this.picturePostura_4.Location = new System.Drawing.Point(878, 262);
            this.picturePostura_4.Name = "picturePostura_4";
            this.picturePostura_4.Size = new System.Drawing.Size(169, 224);
            this.picturePostura_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePostura_4.TabIndex = 4;
            this.picturePostura_4.TabStop = false;
            // 
            // picturePostura_3
            // 
            this.picturePostura_3.Image = global::EsqueletoUsuario.Properties.Resources.postura_3;
            this.picturePostura_3.Location = new System.Drawing.Point(878, 9);
            this.picturePostura_3.Name = "picturePostura_3";
            this.picturePostura_3.Size = new System.Drawing.Size(169, 224);
            this.picturePostura_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePostura_3.TabIndex = 2;
            this.picturePostura_3.TabStop = false;
            this.picturePostura_3.Click += new System.EventHandler(this.picturePostura_3_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(211, 525);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(106, 39);
            this.btn_anterior.TabIndex = 6;
            this.btn_anterior.Text = "<--- Anterior ";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // Frm_Postura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 576);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.picturePostura_4);
            this.Controls.Add(this.lbl_movimento);
            this.Controls.Add(this.picturePostura_3);
            this.Controls.Add(this.lbl_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Postura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postura";
            ((System.ComponentModel.ISupportInitialize)(this.picturePostura_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePostura_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_inicial;
        private System.Windows.Forms.PictureBox picturePostura_3;
        private System.Windows.Forms.Label lbl_movimento;
        private System.Windows.Forms.PictureBox picturePostura_4;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
    }
}