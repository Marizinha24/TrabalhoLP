namespace TrabalhoLP
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            btnEntrar = new Button();
            lblNome = new Label();
            txbSenha = new TextBox();
            lblSenha = new Label();
            txbNome = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(89, 50, 19);
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Cooper Black", 25F);
            btnEntrar.ForeColor = Color.FromArgb(252, 218, 229);
            btnEntrar.Location = new Point(617, 641);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(149, 48);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Cooper Black", 30F);
            lblNome.ForeColor = Color.FromArgb(89, 50, 19);
            lblNome.Location = new Point(624, 300);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(149, 46);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Cooper Black", 15F);
            txbSenha.Location = new Point(458, 544);
            txbSenha.Multiline = true;
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(499, 57);
            txbSenha.TabIndex = 2;
            txbSenha.WordWrap = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Cooper Black", 30F);
            lblSenha.ForeColor = Color.FromArgb(89, 50, 19);
            lblSenha.Location = new Point(617, 472);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(156, 46);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // txbNome
            // 
            txbNome.Font = new Font("Cooper Black", 15F);
            txbNome.Location = new Point(458, 372);
            txbNome.Multiline = true;
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(499, 57);
            txbNome.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-226, 255);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-204, -251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(500, 500);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1000, 255);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(500, 500);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1025, -251);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(500, 500);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 218, 229);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txbNome);
            Controls.Add(lblSenha);
            Controls.Add(txbSenha);
            Controls.Add(lblNome);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Name = "TelaLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lblNome;
        private TextBox txbSenha;
        private Label lblSenha;
        private TextBox txbNome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
