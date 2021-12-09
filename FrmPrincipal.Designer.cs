
namespace CircodeAppsTDS06
{
    partial class FrmPrincipal
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
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPedraPapelTesoura = new System.Windows.Forms.Label();
            this.pbxJogo = new System.Windows.Forms.PictureBox();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            this.pbxIMC = new System.Windows.Forms.PictureBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.pbxGasolina = new System.Windows.Forms.PictureBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(47, 156);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(70, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "Busca CEP";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(522, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 42);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPedraPapelTesoura
            // 
            this.lblPedraPapelTesoura.AutoSize = true;
            this.lblPedraPapelTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedraPapelTesoura.Location = new System.Drawing.Point(181, 156);
            this.lblPedraPapelTesoura.Name = "lblPedraPapelTesoura";
            this.lblPedraPapelTesoura.Size = new System.Drawing.Size(142, 13);
            this.lblPedraPapelTesoura.TabIndex = 3;
            this.lblPedraPapelTesoura.Text = "Pedra - Papel - Tesoura";
            // 
            // pbxJogo
            // 
            this.pbxJogo.Image = global::CircodeAppsTDS06.Properties.Resources.pedrapapeltesoura1;
            this.pbxJogo.Location = new System.Drawing.Point(180, 12);
            this.pbxJogo.Name = "pbxJogo";
            this.pbxJogo.Size = new System.Drawing.Size(143, 141);
            this.pbxJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJogo.TabIndex = 4;
            this.pbxJogo.TabStop = false;
            this.pbxJogo.Click += new System.EventHandler(this.pbxJogo_Click);
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircodeAppsTDS06.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(12, 12);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(143, 141);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 1;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pbxCEP_Click);
            // 
            // pbxIMC
            // 
            this.pbxIMC.Image = global::CircodeAppsTDS06.Properties.Resources.imc;
            this.pbxIMC.Location = new System.Drawing.Point(353, 12);
            this.pbxIMC.Name = "pbxIMC";
            this.pbxIMC.Size = new System.Drawing.Size(143, 141);
            this.pbxIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIMC.TabIndex = 6;
            this.pbxIMC.TabStop = false;
            this.pbxIMC.Click += new System.EventHandler(this.pbxIMC_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(365, 156);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(118, 13);
            this.lblIMC.TabIndex = 5;
            this.lblIMC.Text = "Calculadora de IMC";
            // 
            // pbxGasolina
            // 
            this.pbxGasolina.Image = global::CircodeAppsTDS06.Properties.Resources.gas;
            this.pbxGasolina.Location = new System.Drawing.Point(12, 172);
            this.pbxGasolina.Name = "pbxGasolina";
            this.pbxGasolina.Size = new System.Drawing.Size(143, 141);
            this.pbxGasolina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGasolina.TabIndex = 8;
            this.pbxGasolina.TabStop = false;
            this.pbxGasolina.Click += new System.EventHandler(this.pbxGasolina_Click);
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(8, 316);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(147, 13);
            this.lblConsumo.TabIndex = 7;
            this.lblConsumo.Text = "Calculadora de Consumo";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 342);
            this.Controls.Add(this.pbxGasolina);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.pbxIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.pbxJogo);
            this.Controls.Add(this.lblPedraPapelTesoura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.lblCEP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGasolina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.PictureBox pbxCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbxJogo;
        private System.Windows.Forms.Label lblPedraPapelTesoura;
        private System.Windows.Forms.PictureBox pbxIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.PictureBox pbxGasolina;
        private System.Windows.Forms.Label lblConsumo;
    }
}

