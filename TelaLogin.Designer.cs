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
            btnEntrar = new Button();
            lblNome = new Label();
            txbSenha = new TextBox();
            lblSenha = new Label();
            txbNome = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.PaleTurquoise;
            btnEntrar.Font = new Font("Snap ITC", 18F);
            btnEntrar.ForeColor = Color.FromArgb(255, 130, 179);
            btnEntrar.Location = new Point(129, 344);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(122, 35);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(255, 130, 179);
            lblNome.Location = new Point(78, 120);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 31);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(78, 274);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(187, 23);
            txbSenha.TabIndex = 2;
            txbSenha.WordWrap = false;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(255, 130, 179);
            lblSenha.Location = new Point(78, 223);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(104, 31);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(78, 175);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(187, 23);
            txbNome.TabIndex = 4;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(txbNome);
            Controls.Add(lblSenha);
            Controls.Add(txbSenha);
            Controls.Add(lblNome);
            Controls.Add(btnEntrar);
            Name = "TelaLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lblNome;
        private TextBox txbSenha;
        private Label lblSenha;
        private TextBox txbNome;
    }
}
