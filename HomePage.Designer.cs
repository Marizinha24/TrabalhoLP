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
            label1 = new Label();
            btnCadastroCliente = new Button();
            btnListaUsuarios = new Button();
            formPanel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 81);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "O que deseja verificar";
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(57, 151);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(152, 111);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cadastro Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // btnListaUsuarios
            // 
            btnListaUsuarios.Location = new Point(57, 326);
            btnListaUsuarios.Name = "btnListaUsuarios";
            btnListaUsuarios.Size = new Size(152, 102);
            btnListaUsuarios.TabIndex = 3;
            btnListaUsuarios.Text = "Lista Usuarios";
            btnListaUsuarios.UseVisualStyleBackColor = true;
            btnListaUsuarios.Click += btnListaUsuarios_Click;
            // 
            // formPanel
            // 
            formPanel.Location = new Point(215, 12);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1126, 720);
            formPanel.TabIndex = 4;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 731);
            Controls.Add(formPanel);
            Controls.Add(btnListaUsuarios);
            Controls.Add(btnCadastroCliente);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastroCliente;
        private Button btnListaUsuarios;
        private Panel formPanel;
    }
}