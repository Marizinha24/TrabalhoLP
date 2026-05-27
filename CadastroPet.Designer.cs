namespace TrabalhoLP
{
    partial class CadastroPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPet));
            pbPet = new PictureBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtNomeTutor = new TextBox();
            blbNome = new Label();
            label4 = new Label();
            txtObservacao = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            cbRacas = new ComboBox();
            cbEspecie = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            cmbCastrado = new ComboBox();
            txtNomePet = new TextBox();
            label8 = new Label();
            cmbSexo = new ComboBox();
            txtTemperamento = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbPorte = new ComboBox();
            label2 = new Label();
            btnEntrar = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPet).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pbPet
            // 
            pbPet.Location = new Point(72, 75);
            pbPet.Margin = new Padding(3, 2, 3, 2);
            pbPet.Name = "pbPet";
            pbPet.Size = new Size(270, 235);
            pbPet.TabIndex = 34;
            pbPet.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(160, 211, 241);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pbPet);
            groupBox2.Controls.Add(txtNomeTutor);
            groupBox2.Controls.Add(blbNome);
            groupBox2.Font = new Font("Cooper Black", 8.25F);
            groupBox2.ForeColor = Color.FromArgb(89, 50, 19);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 512);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 25F);
            label1.ForeColor = Color.FromArgb(89, 50, 19);
            label1.Location = new Point(122, 16);
            label1.Name = "label1";
            label1.Size = new Size(171, 39);
            label1.TabIndex = 35;
            label1.Text = "Foto Pet:";
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Font = new Font("Cooper Black", 18F);
            txtNomeTutor.Location = new Point(31, 411);
            txtNomeTutor.Multiline = true;
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.ReadOnly = true;
            txtNomeTutor.Size = new Size(343, 46);
            txtNomeTutor.TabIndex = 0;
            // 
            // blbNome
            // 
            blbNome.AutoSize = true;
            blbNome.Font = new Font("Cooper Black", 25F);
            blbNome.ForeColor = Color.FromArgb(89, 50, 19);
            blbNome.Location = new Point(55, 347);
            blbNome.Name = "blbNome";
            blbNome.Size = new Size(287, 39);
            blbNome.TabIndex = 5;
            blbNome.Text = "Nome do Tutor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 20F);
            label4.ForeColor = Color.FromArgb(89, 50, 19);
            label4.Location = new Point(321, 391);
            label4.Name = "label4";
            label4.Size = new Size(279, 31);
            label4.TabIndex = 10;
            label4.Text = "Observações gerais:";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(321, 434);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(321, 52);
            txtObservacao.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(160, 211, 241);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbRacas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbEspecie);
            groupBox1.Controls.Add(txtObservacao);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbCastrado);
            groupBox1.Controls.Add(txtNomePet);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbSexo);
            groupBox1.Controls.Add(txtTemperamento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbPorte);
            groupBox1.Font = new Font("Cooper Black", 8.25F);
            groupBox1.ForeColor = Color.FromArgb(89, 50, 19);
            groupBox1.Location = new Point(455, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 512);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(89, 50, 19);
            label12.Location = new Point(22, 271);
            label12.Name = "label12";
            label12.Size = new Size(100, 31);
            label12.TabIndex = 25;
            label12.Text = "Raças:";
            // 
            // cbRacas
            // 
            cbRacas.Font = new Font("Cooper Black", 15F);
            cbRacas.FormattingEnabled = true;
            cbRacas.Location = new Point(22, 335);
            cbRacas.Name = "cbRacas";
            cbRacas.Size = new Size(250, 31);
            cbRacas.TabIndex = 24;
            cbRacas.SelectedIndexChanged += cbRacas_SelectedIndexChanged;
            // 
            // cbEspecie
            // 
            cbEspecie.Font = new Font("Cooper Black", 15F);
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Items.AddRange(new object[] { "Gato", "Cachorro" });
            cbEspecie.Location = new Point(22, 224);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(250, 31);
            cbEspecie.TabIndex = 23;
            cbEspecie.SelectedIndexChanged += cbEspecie_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(89, 50, 19);
            label10.Location = new Point(22, 391);
            label10.Name = "label10";
            label10.Size = new Size(229, 31);
            label10.TabIndex = 19;
            label10.Text = "Temperamento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 20F);
            label9.ForeColor = Color.FromArgb(89, 50, 19);
            label9.Location = new Point(321, 271);
            label9.Name = "label9";
            label9.Size = new Size(145, 31);
            label9.TabIndex = 20;
            label9.Text = "Castrado:";
            // 
            // cmbCastrado
            // 
            cmbCastrado.Font = new Font("Cooper Black", 15F);
            cmbCastrado.FormattingEnabled = true;
            cmbCastrado.Items.AddRange(new object[] { "Sim", "Não" });
            cmbCastrado.Location = new Point(321, 327);
            cmbCastrado.Name = "cmbCastrado";
            cmbCastrado.Size = new Size(321, 31);
            cmbCastrado.TabIndex = 19;
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(22, 118);
            txtNomePet.Multiline = true;
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(250, 29);
            txtNomePet.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 20F);
            label8.ForeColor = Color.FromArgb(89, 50, 19);
            label8.Location = new Point(321, 167);
            label8.Name = "label8";
            label8.Size = new Size(85, 31);
            label8.TabIndex = 18;
            label8.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Cooper Black", 15F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Fêmea", "Macho" });
            cmbSexo.Location = new Point(321, 224);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(321, 31);
            cmbSexo.TabIndex = 17;
            // 
            // txtTemperamento
            // 
            txtTemperamento.Location = new Point(22, 443);
            txtTemperamento.Multiline = true;
            txtTemperamento.Name = "txtTemperamento";
            txtTemperamento.Size = new Size(250, 29);
            txtTemperamento.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 20F);
            label7.ForeColor = Color.FromArgb(89, 50, 19);
            label7.Location = new Point(321, 55);
            label7.Name = "label7";
            label7.Size = new Size(97, 31);
            label7.TabIndex = 15;
            label7.Text = "Porte:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 20F);
            label5.ForeColor = Color.FromArgb(89, 50, 19);
            label5.Location = new Point(22, 167);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 11;
            label5.Text = "Espécie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20F);
            label6.ForeColor = Color.FromArgb(89, 50, 19);
            label6.Location = new Point(22, 55);
            label6.Name = "label6";
            label6.Size = new Size(193, 31);
            label6.TabIndex = 14;
            label6.Text = "Nome do Pet:";
            // 
            // cmbPorte
            // 
            cmbPorte.Font = new Font("Cooper Black", 15F);
            cmbPorte.FormattingEnabled = true;
            cmbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            cmbPorte.Location = new Point(321, 116);
            cmbPorte.Name = "cmbPorte";
            cmbPorte.Size = new Size(321, 31);
            cmbPorte.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 30F);
            label2.ForeColor = Color.FromArgb(89, 50, 19);
            label2.Location = new Point(286, 9);
            label2.Name = "label2";
            label2.Size = new Size(575, 46);
            label2.TabIndex = 26;
            label2.Text = "Realize cadastro de seu pet:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(160, 211, 241);
            btnEntrar.FlatAppearance.BorderSize = 5;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(89, 50, 19);
            btnEntrar.Location = new Point(455, 619);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(178, 47);
            btnEntrar.TabIndex = 25;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1007, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // CadastroPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 233, 215);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnEntrar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroPet";
            Text = "CadastroPet";
            ((System.ComponentModel.ISupportInitialize)pbPet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPet;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtObservacao;
        private PictureBox pictureBox10;
        private GroupBox groupBox1;
        private Label label12;
        private ComboBox cbRacas;
        private ComboBox cbEspecie;
        private PictureBox pictureBox12;
        private Label label10;
        private Label label9;
        private ComboBox cmbCastrado;
        private TextBox txtNomePet;
        private Label label8;
        private ComboBox cmbSexo;
        private TextBox txtTemperamento;
        private Label label7;
        private Label label5;
        private Label label6;
        private ComboBox cmbPorte;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox11;
        private Label label2;
        private Button btnEntrar;
        private TextBox txtNomeTutor;
        private Label blbNome;
        private Label label1;
        private PictureBox pictureBox4;
    }
}