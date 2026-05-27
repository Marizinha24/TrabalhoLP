namespace TrabalhoLP
{
    partial class CustomizadoBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizadoBox));
            btnAddPet = new Button();
            btnNovoAgendamento = new Button();
            btnVerAgendamentos = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPet
            // 
            btnAddPet.BackColor = Color.FromArgb(160, 211, 241);
            btnAddPet.FlatAppearance.BorderSize = 5;
            btnAddPet.FlatStyle = FlatStyle.Popup;
            btnAddPet.Font = new Font("Cooper Black", 12F);
            btnAddPet.ForeColor = Color.FromArgb(89, 50, 19);
            btnAddPet.Location = new Point(193, 147);
            btnAddPet.Margin = new Padding(3, 2, 3, 2);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(108, 50);
            btnAddPet.TabIndex = 0;
            btnAddPet.Text = "Adicionar novo Pet?";
            btnAddPet.UseVisualStyleBackColor = false;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnNovoAgendamento
            // 
            btnNovoAgendamento.BackColor = Color.FromArgb(160, 211, 241);
            btnNovoAgendamento.FlatAppearance.BorderSize = 5;
            btnNovoAgendamento.FlatStyle = FlatStyle.Popup;
            btnNovoAgendamento.Font = new Font("Cooper Black", 12F);
            btnNovoAgendamento.ForeColor = Color.FromArgb(89, 50, 19);
            btnNovoAgendamento.Location = new Point(12, 82);
            btnNovoAgendamento.Margin = new Padding(3, 2, 3, 2);
            btnNovoAgendamento.Name = "btnNovoAgendamento";
            btnNovoAgendamento.Size = new Size(190, 40);
            btnNovoAgendamento.TabIndex = 1;
            btnNovoAgendamento.Text = "Novo Agendamento?";
            btnNovoAgendamento.UseVisualStyleBackColor = false;
            btnNovoAgendamento.Click += btnNovoAgendamento_Click;
            // 
            // btnVerAgendamentos
            // 
            btnVerAgendamentos.BackColor = Color.FromArgb(160, 211, 241);
            btnVerAgendamentos.FlatAppearance.BorderSize = 90;
            btnVerAgendamentos.FlatStyle = FlatStyle.Popup;
            btnVerAgendamentos.Font = new Font("Cooper Black", 12F);
            btnVerAgendamentos.ForeColor = Color.FromArgb(89, 50, 19);
            btnVerAgendamentos.Location = new Point(291, 82);
            btnVerAgendamentos.Margin = new Padding(3, 2, 3, 2);
            btnVerAgendamentos.Name = "btnVerAgendamentos";
            btnVerAgendamentos.Size = new Size(199, 40);
            btnVerAgendamentos.TabIndex = 2;
            btnVerAgendamentos.Text = "Ver agendamentos?";
            btnVerAgendamentos.UseVisualStyleBackColor = false;
            btnVerAgendamentos.Click += btnVerAgendamentos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(89, 50, 19);
            label4.Location = new Point(121, 24);
            label4.Name = "label4";
            label4.Size = new Size(271, 31);
            label4.TabIndex = 11;
            label4.Text = "O que deseja fazer?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(414, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // CustomizadoBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 233, 215);
            ClientSize = new Size(514, 208);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnVerAgendamentos);
            Controls.Add(btnNovoAgendamento);
            Controls.Add(btnAddPet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomizadoBox";
            Text = "CustomizadoBox";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPet;
        private Button btnNovoAgendamento;
        private Button btnVerAgendamentos;
        private Label label4;
        private PictureBox pictureBox1;
    }
}