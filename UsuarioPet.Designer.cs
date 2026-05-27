namespace TrabalhoLP
{
    partial class UsuarioPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioPet));
            lvUsuariosPets = new ListView();
            btnHomePage = new Button();
            btnDeletar = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvUsuariosPets
            // 
            lvUsuariosPets.BackColor = Color.FromArgb(255, 225, 235);
            lvUsuariosPets.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvUsuariosPets.Location = new Point(33, 183);
            lvUsuariosPets.Name = "lvUsuariosPets";
            lvUsuariosPets.Size = new Size(1305, 554);
            lvUsuariosPets.TabIndex = 0;
            lvUsuariosPets.UseCompatibleStateImageBehavior = false;
            lvUsuariosPets.DoubleClick += lvUsuariosPets_DoubleClick;
            // 
            // btnHomePage
            // 
            btnHomePage.BackColor = Color.FromArgb(255, 225, 235);
            btnHomePage.FlatStyle = FlatStyle.Popup;
            btnHomePage.Font = new Font("Cooper Black", 9F);
            btnHomePage.ForeColor = Color.FromArgb(89, 50, 19);
            btnHomePage.Image = (Image)resources.GetObject("btnHomePage.Image");
            btnHomePage.Location = new Point(33, 11);
            btnHomePage.Margin = new Padding(3, 2, 3, 2);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(71, 62);
            btnHomePage.TabIndex = 1;
            btnHomePage.UseVisualStyleBackColor = false;
            btnHomePage.Click += btnHomePage_Click_1;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(227, 94, 101);
            btnDeletar.FlatStyle = FlatStyle.Popup;
            btnDeletar.Font = new Font("Cooper Black", 18F);
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(42, 811);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(154, 41);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar Usuario";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(160, 211, 241);
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Cooper Black", 18F);
            btnExportar.ForeColor = Color.FromArgb(89, 50, 19);
            btnExportar.Location = new Point(1154, 811);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(163, 41);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.FromArgb(166, 213, 120);
            btnImportar.FlatStyle = FlatStyle.Popup;
            btnImportar.Font = new Font("Cooper Black", 18F);
            btnImportar.ForeColor = Color.FromArgb(89, 50, 19);
            btnImportar.Location = new Point(818, 811);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(168, 41);
            btnImportar.TabIndex = 14;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1168, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // UsuarioPet
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 235);
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnDeletar);
            Controls.Add(btnHomePage);
            Controls.Add(lvUsuariosPets);
            Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UsuarioPet";
            Text = "Agendamentos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUsuariosPets;
        private Button btnHomePage;
        private Button btnDeletar;
        private Button btnExportar;
        private Button btnImportar;
        private PictureBox pictureBox1;
    }
}