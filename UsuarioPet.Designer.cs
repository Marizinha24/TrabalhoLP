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
            btnAgendamentos = new Button();
            btnAtualizarUsuario = new Button();
            btnImportar = new Button();
            btnExportar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // lvUsuariosPets
            // 
            lvUsuariosPets.Location = new Point(35, 78);
            lvUsuariosPets.Margin = new Padding(3, 4, 3, 4);
            lvUsuariosPets.Name = "lvUsuariosPets";
            lvUsuariosPets.Size = new Size(1146, 652);
            lvUsuariosPets.TabIndex = 0;
            lvUsuariosPets.UseCompatibleStateImageBehavior = false;
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(56, 12);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(97, 59);
            btnHomePage.TabIndex = 1;
            btnHomePage.Text = "Home page";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += this.button1_Click;
            // 
            // btnAgendamentos
            // 
            btnAgendamentos.Location = new Point(172, 12);
            btnAgendamentos.Name = "btnAgendamentos";
            btnAgendamentos.Size = new Size(101, 59);
            btnAgendamentos.TabIndex = 2;
            btnAgendamentos.Text = "Agendar agora";
            btnAgendamentos.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarUsuario
            // 
            btnAtualizarUsuario.Location = new Point(307, 12);
            btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            btnAtualizarUsuario.Size = new Size(105, 59);
            btnAtualizarUsuario.TabIndex = 3;
            btnAtualizarUsuario.Text = "Atualizar Usuario";
            btnAtualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(954, 27);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(94, 29);
            btnImportar.TabIndex = 4;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(1087, 27);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(430, 12);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(119, 59);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar Usuario";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // UsuarioPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 757);
            Controls.Add(btnDeletar);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnAtualizarUsuario);
            Controls.Add(btnAgendamentos);
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
        private Button btnAgendamentos;
        private Button btnAtualizarUsuario;
        private Button btnImportar;
        private Button btnExportar;
        private Button btnDeletar;
    }
}