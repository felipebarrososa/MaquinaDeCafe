
namespace MaquinaDeCafe
{
    partial class frm_MaquinaCafe
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
            this.btn_Cappuccino = new System.Windows.Forms.Button();
            this.btn_Mocha = new System.Windows.Forms.Button();
            this.btn_CafeCLeite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ValorInformado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ValorCafe = new System.Windows.Forms.TextBox();
            this.btn_TirarCafé = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_UmReal = new System.Windows.Forms.Button();
            this.btn_CinquentaCentavos = new System.Windows.Forms.Button();
            this.btn_DezCentavos = new System.Windows.Forms.Button();
            this.btn_CincoCentavos = new System.Windows.Forms.Button();
            this.btn_UmCentavo = new System.Windows.Forms.Button();
            this.btn_VintecincoCentavos = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cappuccino
            // 
            this.btn_Cappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Cappuccino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cappuccino.Location = new System.Drawing.Point(23, 559);
            this.btn_Cappuccino.Name = "btn_Cappuccino";
            this.btn_Cappuccino.Size = new System.Drawing.Size(151, 35);
            this.btn_Cappuccino.TabIndex = 0;
            this.btn_Cappuccino.Text = "Cappuccino\r\nR$ 3,50";
            this.btn_Cappuccino.UseVisualStyleBackColor = true;
            this.btn_Cappuccino.Click += new System.EventHandler(this.btn_Cappuccino_Click);
            // 
            // btn_Mocha
            // 
            this.btn_Mocha.Location = new System.Drawing.Point(247, 559);
            this.btn_Mocha.Name = "btn_Mocha";
            this.btn_Mocha.Size = new System.Drawing.Size(151, 35);
            this.btn_Mocha.TabIndex = 1;
            this.btn_Mocha.Text = "Mocha\r\nR$ 4,00 ";
            this.btn_Mocha.UseVisualStyleBackColor = true;
            this.btn_Mocha.Click += new System.EventHandler(this.btn_Mocha_Click);
            // 
            // btn_CafeCLeite
            // 
            this.btn_CafeCLeite.Location = new System.Drawing.Point(462, 559);
            this.btn_CafeCLeite.Name = "btn_CafeCLeite";
            this.btn_CafeCLeite.Size = new System.Drawing.Size(151, 35);
            this.btn_CafeCLeite.TabIndex = 2;
            this.btn_CafeCLeite.Text = "Café c/ Leite\r\nR$ 3,00";
            this.btn_CafeCLeite.UseVisualStyleBackColor = true;
            this.btn_CafeCLeite.Click += new System.EventHandler(this.btn_CafeCLeite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESCOLHA SEU CAFÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "INSIRA A MOEDA";
            // 
            // txt_ValorInformado
            // 
            this.txt_ValorInformado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_ValorInformado.Location = new System.Drawing.Point(553, 164);
            this.txt_ValorInformado.Name = "txt_ValorInformado";
            this.txt_ValorInformado.Size = new System.Drawing.Size(101, 20);
            this.txt_ValorInformado.TabIndex = 19;
            this.txt_ValorInformado.Text = "0,00";
            this.txt_ValorInformado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ValorInformado.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "VALOR INFORMADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "VALOR DO CAFÉ";
            // 
            // txt_ValorCafe
            // 
            this.txt_ValorCafe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_ValorCafe.Location = new System.Drawing.Point(689, 558);
            this.txt_ValorCafe.Name = "txt_ValorCafe";
            this.txt_ValorCafe.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorCafe.TabIndex = 30;
            this.txt_ValorCafe.Text = "0,00";
            this.txt_ValorCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ValorCafe.WordWrap = false;
            // 
            // btn_TirarCafé
            // 
            this.btn_TirarCafé.Location = new System.Drawing.Point(643, 476);
            this.btn_TirarCafé.Name = "btn_TirarCafé";
            this.btn_TirarCafé.Size = new System.Drawing.Size(194, 61);
            this.btn_TirarCafé.TabIndex = 31;
            this.btn_TirarCafé.Text = "Tirar Café";
            this.btn_TirarCafé.UseVisualStyleBackColor = true;
            this.btn_TirarCafé.Click += new System.EventHandler(this.btn_TirarCafé_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaquinaDeCafe.Properties.Resources.COMLEITEF;
            this.pictureBox3.Location = new System.Drawing.Point(441, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 283);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaquinaDeCafe.Properties.Resources.MochaF;
            this.pictureBox2.Location = new System.Drawing.Point(225, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 283);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaquinaDeCafe.Properties.Resources.CappuccinoF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 283);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btn_UmReal
            // 
            this.btn_UmReal.Image = global::MaquinaDeCafe.Properties.Resources._1_real;
            this.btn_UmReal.Location = new System.Drawing.Point(454, 122);
            this.btn_UmReal.Name = "btn_UmReal";
            this.btn_UmReal.Size = new System.Drawing.Size(81, 78);
            this.btn_UmReal.TabIndex = 26;
            this.btn_UmReal.UseVisualStyleBackColor = true;
            this.btn_UmReal.Click += new System.EventHandler(this.btn_UmReal_Click);
            // 
            // btn_CinquentaCentavos
            // 
            this.btn_CinquentaCentavos.Image = global::MaquinaDeCafe.Properties.Resources._50;
            this.btn_CinquentaCentavos.Location = new System.Drawing.Point(367, 122);
            this.btn_CinquentaCentavos.Name = "btn_CinquentaCentavos";
            this.btn_CinquentaCentavos.Size = new System.Drawing.Size(81, 78);
            this.btn_CinquentaCentavos.TabIndex = 25;
            this.btn_CinquentaCentavos.UseVisualStyleBackColor = true;
            this.btn_CinquentaCentavos.Click += new System.EventHandler(this.btn_CinquentaCentavos_Click);
            // 
            // btn_DezCentavos
            // 
            this.btn_DezCentavos.Image = global::MaquinaDeCafe.Properties.Resources.DEZ;
            this.btn_DezCentavos.Location = new System.Drawing.Point(193, 121);
            this.btn_DezCentavos.Name = "btn_DezCentavos";
            this.btn_DezCentavos.Size = new System.Drawing.Size(81, 78);
            this.btn_DezCentavos.TabIndex = 24;
            this.btn_DezCentavos.UseVisualStyleBackColor = true;
            this.btn_DezCentavos.Click += new System.EventHandler(this.btn_DezCentavos_Click);
            // 
            // btn_CincoCentavos
            // 
            this.btn_CincoCentavos.Image = global::MaquinaDeCafe.Properties.Resources.cinco;
            this.btn_CincoCentavos.Location = new System.Drawing.Point(106, 122);
            this.btn_CincoCentavos.Name = "btn_CincoCentavos";
            this.btn_CincoCentavos.Size = new System.Drawing.Size(81, 78);
            this.btn_CincoCentavos.TabIndex = 23;
            this.btn_CincoCentavos.UseVisualStyleBackColor = true;
            this.btn_CincoCentavos.Click += new System.EventHandler(this.btn_CincoCentavos_Click);
            // 
            // btn_UmCentavo
            // 
            this.btn_UmCentavo.Image = global::MaquinaDeCafe.Properties.Resources.um;
            this.btn_UmCentavo.Location = new System.Drawing.Point(19, 122);
            this.btn_UmCentavo.Name = "btn_UmCentavo";
            this.btn_UmCentavo.Size = new System.Drawing.Size(81, 78);
            this.btn_UmCentavo.TabIndex = 22;
            this.btn_UmCentavo.UseVisualStyleBackColor = true;
            this.btn_UmCentavo.Click += new System.EventHandler(this.btn_UmCentavo_Click);
            // 
            // btn_VintecincoCentavos
            // 
            this.btn_VintecincoCentavos.Image = global::MaquinaDeCafe.Properties.Resources._25;
            this.btn_VintecincoCentavos.Location = new System.Drawing.Point(280, 121);
            this.btn_VintecincoCentavos.Name = "btn_VintecincoCentavos";
            this.btn_VintecincoCentavos.Size = new System.Drawing.Size(81, 78);
            this.btn_VintecincoCentavos.TabIndex = 21;
            this.btn_VintecincoCentavos.UseVisualStyleBackColor = true;
            this.btn_VintecincoCentavos.Click += new System.EventHandler(this.btn_VintecincoCentavos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MaquinaDeCafe.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(11, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(784, 93);
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // frm_MaquinaCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(875, 639);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_TirarCafé);
            this.Controls.Add(this.txt_ValorCafe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_UmReal);
            this.Controls.Add(this.btn_CinquentaCentavos);
            this.Controls.Add(this.btn_DezCentavos);
            this.Controls.Add(this.btn_CincoCentavos);
            this.Controls.Add(this.btn_UmCentavo);
            this.Controls.Add(this.btn_VintecincoCentavos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ValorInformado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CafeCLeite);
            this.Controls.Add(this.btn_Mocha);
            this.Controls.Add(this.btn_Cappuccino);
            this.Name = "frm_MaquinaCafe";
            this.Text = "Maquina de Café Virtual";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cappuccino;
        private System.Windows.Forms.Button btn_Mocha;
        private System.Windows.Forms.Button btn_CafeCLeite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ValorInformado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_VintecincoCentavos;
        private System.Windows.Forms.Button btn_UmCentavo;
        private System.Windows.Forms.Button btn_CincoCentavos;
        private System.Windows.Forms.Button btn_DezCentavos;
        private System.Windows.Forms.Button btn_CinquentaCentavos;
        private System.Windows.Forms.Button btn_UmReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ValorCafe;
        private System.Windows.Forms.Button btn_TirarCafé;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

