namespace Cafe_Virtual.Tela
{
    partial class frmCafe
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnMocha = new System.Windows.Forms.RadioButton();
            this.rdnCappuccino = new System.Windows.Forms.RadioButton();
            this.rdnCafeComLeite = new System.Windows.Forms.RadioButton();
            this.rdnCafe = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chk1Centavo = new System.Windows.Forms.CheckBox();
            this.chk5Centavos = new System.Windows.Forms.CheckBox();
            this.chk10Centavos = new System.Windows.Forms.CheckBox();
            this.chk25Centavos = new System.Windows.Forms.CheckBox();
            this.chk50Centavos = new System.Windows.Forms.CheckBox();
            this.chk1Real = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud1Centavo = new System.Windows.Forms.NumericUpDown();
            this.nud5Centavos = new System.Windows.Forms.NumericUpDown();
            this.nud10Centavos = new System.Windows.Forms.NumericUpDown();
            this.nud25Centavos = new System.Windows.Forms.NumericUpDown();
            this.nud50Centavos = new System.Windows.Forms.NumericUpDown();
            this.nud1Real = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Centavo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5Centavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud10Centavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud25Centavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud50Centavos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Real)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Location = new System.Drawing.Point(469, 304);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(89, 26);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnMocha);
            this.groupBox1.Controls.Add(this.rdnCappuccino);
            this.groupBox1.Controls.Add(this.rdnCafeComLeite);
            this.groupBox1.Controls.Add(this.rdnCafe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chk1Centavo);
            this.groupBox1.Controls.Add(this.chk5Centavos);
            this.groupBox1.Controls.Add(this.chk10Centavos);
            this.groupBox1.Controls.Add(this.chk25Centavos);
            this.groupBox1.Controls.Add(this.chk50Centavos);
            this.groupBox1.Controls.Add(this.chk1Real);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud1Centavo);
            this.groupBox1.Controls.Add(this.nud5Centavos);
            this.groupBox1.Controls.Add(this.nud10Centavos);
            this.groupBox1.Controls.Add(this.nud25Centavos);
            this.groupBox1.Controls.Add(this.nud50Centavos);
            this.groupBox1.Controls.Add(this.nud1Real);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 360);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdnMocha
            // 
            this.rdnMocha.AutoSize = true;
            this.rdnMocha.Location = new System.Drawing.Point(374, 178);
            this.rdnMocha.Name = "rdnMocha";
            this.rdnMocha.Size = new System.Drawing.Size(150, 17);
            this.rdnMocha.TabIndex = 38;
            this.rdnMocha.TabStop = true;
            this.rdnMocha.Text = "Mocha                  R$ 4,00";
            this.rdnMocha.UseVisualStyleBackColor = true;
            // 
            // rdnCappuccino
            // 
            this.rdnCappuccino.AutoSize = true;
            this.rdnCappuccino.Location = new System.Drawing.Point(374, 142);
            this.rdnCappuccino.Name = "rdnCappuccino";
            this.rdnCappuccino.Size = new System.Drawing.Size(150, 17);
            this.rdnCappuccino.TabIndex = 37;
            this.rdnCappuccino.TabStop = true;
            this.rdnCappuccino.Text = "Cappuccino          R$ 3,50";
            this.rdnCappuccino.UseVisualStyleBackColor = true;
            // 
            // rdnCafeComLeite
            // 
            this.rdnCafeComLeite.AutoSize = true;
            this.rdnCafeComLeite.Location = new System.Drawing.Point(374, 105);
            this.rdnCafeComLeite.Name = "rdnCafeComLeite";
            this.rdnCafeComLeite.Size = new System.Drawing.Size(151, 17);
            this.rdnCafeComLeite.TabIndex = 36;
            this.rdnCafeComLeite.TabStop = true;
            this.rdnCafeComLeite.Text = "Café com leite       R$ 3,00";
            this.rdnCafeComLeite.UseVisualStyleBackColor = true;
            // 
            // rdnCafe
            // 
            this.rdnCafe.AutoSize = true;
            this.rdnCafe.Location = new System.Drawing.Point(374, 71);
            this.rdnCafe.Name = "rdnCafe";
            this.rdnCafe.Size = new System.Drawing.Size(151, 17);
            this.rdnCafe.TabIndex = 35;
            this.rdnCafe.TabStop = true;
            this.rdnCafe.Text = "Café                      R$ 2,00";
            this.rdnCafe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cafés";
            // 
            // chk1Centavo
            // 
            this.chk1Centavo.AutoSize = true;
            this.chk1Centavo.Location = new System.Drawing.Point(53, 251);
            this.chk1Centavo.Name = "chk1Centavo";
            this.chk1Centavo.Size = new System.Drawing.Size(64, 17);
            this.chk1Centavo.TabIndex = 27;
            this.chk1Centavo.Text = "R$ 0,01";
            this.chk1Centavo.UseVisualStyleBackColor = true;
            this.chk1Centavo.CheckedChanged += new System.EventHandler(this.chk1Centavo_CheckedChanged);
            // 
            // chk5Centavos
            // 
            this.chk5Centavos.AutoSize = true;
            this.chk5Centavos.Location = new System.Drawing.Point(53, 215);
            this.chk5Centavos.Name = "chk5Centavos";
            this.chk5Centavos.Size = new System.Drawing.Size(64, 17);
            this.chk5Centavos.TabIndex = 26;
            this.chk5Centavos.Text = "R$ 0,05";
            this.chk5Centavos.UseVisualStyleBackColor = true;
            this.chk5Centavos.CheckedChanged += new System.EventHandler(this.chk5Centavos_CheckedChanged);
            // 
            // chk10Centavos
            // 
            this.chk10Centavos.AutoSize = true;
            this.chk10Centavos.Location = new System.Drawing.Point(53, 179);
            this.chk10Centavos.Name = "chk10Centavos";
            this.chk10Centavos.Size = new System.Drawing.Size(64, 17);
            this.chk10Centavos.TabIndex = 25;
            this.chk10Centavos.Text = "R$ 0,10";
            this.chk10Centavos.UseVisualStyleBackColor = true;
            this.chk10Centavos.CheckedChanged += new System.EventHandler(this.chk10Centavos_CheckedChanged);
            // 
            // chk25Centavos
            // 
            this.chk25Centavos.AutoSize = true;
            this.chk25Centavos.Location = new System.Drawing.Point(53, 143);
            this.chk25Centavos.Name = "chk25Centavos";
            this.chk25Centavos.Size = new System.Drawing.Size(64, 17);
            this.chk25Centavos.TabIndex = 24;
            this.chk25Centavos.Text = "R$ 0,25";
            this.chk25Centavos.UseVisualStyleBackColor = true;
            this.chk25Centavos.CheckedChanged += new System.EventHandler(this.chk25Centavos_CheckedChanged);
            // 
            // chk50Centavos
            // 
            this.chk50Centavos.AutoSize = true;
            this.chk50Centavos.Location = new System.Drawing.Point(53, 106);
            this.chk50Centavos.Name = "chk50Centavos";
            this.chk50Centavos.Size = new System.Drawing.Size(64, 17);
            this.chk50Centavos.TabIndex = 23;
            this.chk50Centavos.Text = "R$ 0,50";
            this.chk50Centavos.UseVisualStyleBackColor = true;
            this.chk50Centavos.CheckedChanged += new System.EventHandler(this.chk50Centavos_CheckedChanged);
            // 
            // chk1Real
            // 
            this.chk1Real.AutoSize = true;
            this.chk1Real.Location = new System.Drawing.Point(53, 72);
            this.chk1Real.Name = "chk1Real";
            this.chk1Real.Size = new System.Drawing.Size(64, 17);
            this.chk1Real.TabIndex = 22;
            this.chk1Real.Text = "R$ 1,00";
            this.chk1Real.UseVisualStyleBackColor = true;
            this.chk1Real.CheckedChanged += new System.EventHandler(this.chk1Real_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Moedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade";
            // 
            // nud1Centavo
            // 
            this.nud1Centavo.Enabled = false;
            this.nud1Centavo.Location = new System.Drawing.Point(151, 250);
            this.nud1Centavo.Name = "nud1Centavo";
            this.nud1Centavo.Size = new System.Drawing.Size(59, 20);
            this.nud1Centavo.TabIndex = 13;
            // 
            // nud5Centavos
            // 
            this.nud5Centavos.Enabled = false;
            this.nud5Centavos.Location = new System.Drawing.Point(151, 214);
            this.nud5Centavos.Name = "nud5Centavos";
            this.nud5Centavos.Size = new System.Drawing.Size(59, 20);
            this.nud5Centavos.TabIndex = 12;
            // 
            // nud10Centavos
            // 
            this.nud10Centavos.Enabled = false;
            this.nud10Centavos.Location = new System.Drawing.Point(151, 178);
            this.nud10Centavos.Name = "nud10Centavos";
            this.nud10Centavos.Size = new System.Drawing.Size(59, 20);
            this.nud10Centavos.TabIndex = 11;
            // 
            // nud25Centavos
            // 
            this.nud25Centavos.Enabled = false;
            this.nud25Centavos.Location = new System.Drawing.Point(151, 142);
            this.nud25Centavos.Name = "nud25Centavos";
            this.nud25Centavos.Size = new System.Drawing.Size(59, 20);
            this.nud25Centavos.TabIndex = 10;
            // 
            // nud50Centavos
            // 
            this.nud50Centavos.Enabled = false;
            this.nud50Centavos.Location = new System.Drawing.Point(151, 105);
            this.nud50Centavos.Name = "nud50Centavos";
            this.nud50Centavos.Size = new System.Drawing.Size(59, 20);
            this.nud50Centavos.TabIndex = 9;
            // 
            // nud1Real
            // 
            this.nud1Real.Enabled = false;
            this.nud1Real.Location = new System.Drawing.Point(151, 71);
            this.nud1Real.Name = "nud1Real";
            this.nud1Real.Size = new System.Drawing.Size(59, 20);
            this.nud1Real.TabIndex = 8;
            // 
            // frmCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Café";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Centavo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5Centavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud10Centavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud25Centavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud50Centavos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1Real)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud1Centavo;
        private System.Windows.Forms.NumericUpDown nud5Centavos;
        private System.Windows.Forms.NumericUpDown nud10Centavos;
        private System.Windows.Forms.NumericUpDown nud25Centavos;
        private System.Windows.Forms.NumericUpDown nud50Centavos;
        private System.Windows.Forms.NumericUpDown nud1Real;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk1Centavo;
        private System.Windows.Forms.CheckBox chk5Centavos;
        private System.Windows.Forms.CheckBox chk10Centavos;
        private System.Windows.Forms.CheckBox chk25Centavos;
        private System.Windows.Forms.CheckBox chk50Centavos;
        private System.Windows.Forms.CheckBox chk1Real;
        private System.Windows.Forms.RadioButton rdnMocha;
        private System.Windows.Forms.RadioButton rdnCappuccino;
        private System.Windows.Forms.RadioButton rdnCafeComLeite;
        private System.Windows.Forms.RadioButton rdnCafe;
    }
}