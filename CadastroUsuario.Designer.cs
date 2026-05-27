namespace TrabalhoLP
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            txtNomeTutor = new TextBox();
            btnEntrar = new Button();
            blbNome = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCPF = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEndereco = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            btnEndereco = new Button();
            tbxNumero = new TextBox();
            tbxComplemento = new TextBox();
            tbxCEP = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            label8 = new Label();
            txtTelefone = new TextBox();
            btnVoltar = new Button();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Location = new Point(33, 176);
            txtNomeTutor.Multiline = true;
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.Size = new Size(275, 35);
            txtNomeTutor.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(160, 211, 241);
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(89, 50, 19);
            btnEntrar.Location = new Point(456, 622);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(159, 38);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // blbNome
            // 
            blbNome.AutoSize = true;
            blbNome.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blbNome.ForeColor = Color.FromArgb(89, 50, 19);
            blbNome.Location = new Point(33, 137);
            blbNome.Name = "blbNome";
            blbNome.Size = new Size(202, 27);
            blbNome.TabIndex = 5;
            blbNome.Text = "Nome do Tutor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 50, 19);
            label1.Location = new Point(33, 223);
            label1.Name = "label1";
            label1.Size = new Size(68, 27);
            label1.TabIndex = 6;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(89, 50, 19);
            label2.Location = new Point(347, 35);
            label2.Name = "label2";
            label2.Size = new Size(441, 46);
            label2.TabIndex = 7;
            label2.Text = "Realize seu cadastro:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(33, 260);
            txtCPF.Multiline = true;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(275, 35);
            txtCPF.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(89, 50, 19);
            label3.Location = new Point(33, 298);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 9;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 20F);
            label4.ForeColor = Color.FromArgb(89, 50, 19);
            label4.Location = new Point(15, 176);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 10;
            label4.Text = "CEP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 20F);
            label5.ForeColor = Color.FromArgb(89, 50, 19);
            label5.Location = new Point(284, 176);
            label5.Name = "label5";
            label5.Size = new Size(132, 31);
            label5.TabIndex = 11;
            label5.Text = "Número:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(284, 324);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(292, 49);
            txtEndereco.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20F);
            label6.ForeColor = Color.FromArgb(89, 50, 19);
            label6.Location = new Point(284, 283);
            label6.Name = "label6";
            label6.Size = new Size(141, 31);
            label6.TabIndex = 14;
            label6.Text = "Endereço";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(160, 211, 241);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnEndereco);
            groupBox1.Controls.Add(tbxNumero);
            groupBox1.Controls.Add(tbxComplemento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbxCEP);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = Color.FromArgb(255, 130, 179);
            groupBox1.Location = new Point(522, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 471);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(192, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // btnEndereco
            // 
            btnEndereco.BackColor = Color.FromArgb(250, 233, 215);
            btnEndereco.FlatStyle = FlatStyle.Popup;
            btnEndereco.Font = new Font("Cooper Black", 15F);
            btnEndereco.ForeColor = Color.FromArgb(89, 50, 19);
            btnEndereco.Location = new Point(224, 396);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(134, 54);
            btnEndereco.TabIndex = 33;
            btnEndereco.Text = "Buscar Endereço";
            btnEndereco.UseVisualStyleBackColor = false;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // tbxNumero
            // 
            tbxNumero.Font = new Font("Cooper Black", 8.25F);
            tbxNumero.ForeColor = Color.FromArgb(89, 50, 19);
            tbxNumero.Location = new Point(15, 223);
            tbxNumero.Multiline = true;
            tbxNumero.Name = "tbxNumero";
            tbxNumero.Size = new Size(233, 34);
            tbxNumero.TabIndex = 32;
            // 
            // tbxComplemento
            // 
            tbxComplemento.Location = new Point(15, 339);
            tbxComplemento.Multiline = true;
            tbxComplemento.Name = "tbxComplemento";
            tbxComplemento.Size = new Size(233, 34);
            tbxComplemento.TabIndex = 30;
            // 
            // tbxCEP
            // 
            tbxCEP.Font = new Font("Cooper Black", 8.25F);
            tbxCEP.ForeColor = Color.FromArgb(89, 50, 19);
            tbxCEP.Location = new Point(284, 222);
            tbxCEP.Multiline = true;
            tbxCEP.Name = "tbxCEP";
            tbxCEP.Size = new Size(292, 35);
            tbxCEP.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 20F);
            label7.ForeColor = Color.FromArgb(89, 50, 19);
            label7.Location = new Point(15, 283);
            label7.Name = "label7";
            label7.Size = new Size(212, 31);
            label7.TabIndex = 15;
            label7.Text = "Complemento:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(160, 211, 241);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTelefone);
            groupBox2.Controls.Add(txtNomeTutor);
            groupBox2.Controls.Add(blbNome);
            groupBox2.Controls.Add(txtCPF);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(59, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 471);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 415);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 35);
            txtEmail.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(89, 50, 19);
            label8.Location = new Point(33, 377);
            label8.Name = "label8";
            label8.Size = new Size(91, 27);
            label8.TabIndex = 28;
            label8.Text = "Email:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(33, 339);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(275, 35);
            txtTelefone.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 130, 179);
            btnVoltar.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.SaddleBrown;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(-3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(41, 34);
            btnVoltar.TabIndex = 30;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1037, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 233, 215);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox4);
            Controls.Add(btnVoltar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(btnEntrar);
            Name = "CadastroUsuario";
            Text = "PetCare";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeTutor;
        private Button btnEntrar;
        private Label blbNome;
        private Label label1;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCPF;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox cmbCastrado;
        private ComboBox cmbSexo;
        private TextBox txtTemperamento;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtEndereco;
        private ComboBox cbEspecie;
        private TextBox tbxNumero;
        private TextBox tbxCEP;
        private TextBox tbxComplemento;
        private Button btnEndereco;
        private ComboBox cbRacas;
        private PictureBox pbPet;
        private TextBox txtEmail;
        private Label label8;
        private Button btnVoltar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}