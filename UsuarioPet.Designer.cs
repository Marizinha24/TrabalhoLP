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
            lvUsuariosPets.Location = new Point(35, 78);
            lvUsuariosPets.Margin = new Padding(3, 4, 3, 4);
            lvUsuariosPets.Name = "lvUsuariosPets";
            lvUsuariosPets.Size = new Size(1146, 617);
            lvUsuariosPets.TabIndex = 0;
            lvUsuariosPets.UseCompatibleStateImageBehavior = false;
            lvUsuariosPets.DoubleClick += lvUsuariosPets_DoubleClick;
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(56, 12);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(97, 59);
            btnHomePage.TabIndex = 1;
            btnHomePage.Text = "Home page";
            btnHomePage.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1016, 12);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(119, 59);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar Usuario";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(1057, 716);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(888, 716);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(94, 29);
            btnImportar.TabIndex = 14;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // UsuarioPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 757);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnDeletar);
            Controls.Add(btnHomePage);
            Controls.Add(lvUsuariosPets);
            Margin = new Padding(3, 4, 3, 4);
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