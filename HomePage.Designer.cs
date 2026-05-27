namespace TrabalhoLP
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label1 = new Label();
            btnCadastroCliente = new Button();
            btnListaUsuarios = new Button();
            formPanel = new Panel();
            pbGif = new PictureBox();
            pictureBox1 = new PictureBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20F);
            label1.ForeColor = Color.FromArgb(89, 50, 19);
            label1.Location = new Point(-1, 203);
            label1.Name = "label1";
            label1.Size = new Size(230, 78);
            label1.TabIndex = 0;
            label1.Text = "O que deseja\r\nverificar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(160, 211, 241);
            btnCadastroCliente.FlatStyle = FlatStyle.Popup;
            btnCadastroCliente.Font = new Font("Cooper Black", 20F);
            btnCadastroCliente.ForeColor = Color.FromArgb(89, 50, 19);
            btnCadastroCliente.Image = (Image)resources.GetObject("btnCadastroCliente.Image");
            btnCadastroCliente.ImageAlign = ContentAlignment.TopCenter;
            btnCadastroCliente.Location = new Point(14, 411);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(195, 135);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastro Cliente";
            btnCadastroCliente.TextAlign = ContentAlignment.BottomCenter;
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnListaUsuarios
            // 
            btnListaUsuarios.BackColor = Color.FromArgb(160, 211, 241);
            btnListaUsuarios.FlatStyle = FlatStyle.Popup;
            btnListaUsuarios.Font = new Font("Cooper Black", 20F);
            btnListaUsuarios.ForeColor = Color.FromArgb(89, 50, 19);
            btnListaUsuarios.Image = (Image)resources.GetObject("btnListaUsuarios.Image");
            btnListaUsuarios.ImageAlign = ContentAlignment.TopCenter;
            btnListaUsuarios.Location = new Point(14, 649);
            btnListaUsuarios.Name = "btnListaUsuarios";
            btnListaUsuarios.Size = new Size(180, 131);
            btnListaUsuarios.TabIndex = 3;
            btnListaUsuarios.Text = "Lista Usuarios";
            btnListaUsuarios.TextAlign = ContentAlignment.BottomCenter;
            btnListaUsuarios.UseVisualStyleBackColor = false;
            btnListaUsuarios.Click += btnListaUsuarios_Click;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(pbGif);
            formPanel.Location = new Point(236, -1);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1415, 1000);
            formPanel.TabIndex = 4;
            // 
            // pbGif
            // 
            pbGif.Image = (Image)resources.GetObject("pbGif.Image");
            pbGif.Location = new Point(270, 230);
            pbGif.Name = "pbGif";
            pbGif.Size = new Size(790, 468);
            pbGif.TabIndex = 0;
            pbGif.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 218, 229);
            ClientSize = new Size(1663, 999);
            Controls.Add(pictureBox1);
            Controls.Add(formPanel);
            Controls.Add(btnListaUsuarios);
            Controls.Add(btnCadastroCliente);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "HomePage";
            formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastroCliente;
        private Button btnListaUsuarios;
        private Panel formPanel;
        private PictureBox pictureBox1;
        private PictureBox pbGif;
    }
}