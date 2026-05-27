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
            lvUsuariosPets = new ListView();
            btnHomePage = new Button();
            btnDeletar = new Button();
            btnExportar = new Button();
            btnImportar = new Button();
            SuspendLayout();
            // 
            // lvUsuariosPets
            // 
            lvUsuariosPets.BackColor = Color.FromArgb(250, 233, 215);
            lvUsuariosPets.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvUsuariosPets.Location = new Point(27, 70);
            lvUsuariosPets.Name = "lvUsuariosPets";
            lvUsuariosPets.Size = new Size(1267, 478);
            lvUsuariosPets.TabIndex = 0;
            lvUsuariosPets.UseCompatibleStateImageBehavior = false;
            lvUsuariosPets.DoubleClick += lvUsuariosPets_DoubleClick;
            // 
            // btnHomePage
            // 
            btnHomePage.Font = new Font("Cooper Black", 9F);
            btnHomePage.ForeColor = Color.FromArgb(89, 50, 19);
            btnHomePage.Location = new Point(56, 8);
            btnHomePage.Margin = new Padding(3, 2, 3, 2);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(97, 41);
            btnHomePage.TabIndex = 1;
            btnHomePage.Text = "Home page";
            btnHomePage.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(227, 94, 101);
            btnDeletar.Font = new Font("Cooper Black", 9F);
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(1175, 8);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(119, 41);
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
            btnExportar.Location = new Point(1203, 666);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(155, 32);
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
            btnImportar.Location = new Point(1013, 666);
            btnImportar.Margin = new Padding(3, 2, 3, 2);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(160, 32);
            btnImportar.TabIndex = 14;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // UsuarioPet
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 233, 215);
            ClientSize = new Size(1370, 749);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnDeletar);
            Controls.Add(btnHomePage);
            Controls.Add(lvUsuariosPets);
            Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UsuarioPet";
            Text = "Agendamentos";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUsuariosPets;
        private Button btnHomePage;
        private Button btnDeletar;
        private Button btnExportar;
        private Button btnImportar;
    }
}