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
            btnAddPet = new Button();
            btnNovoAgendamento = new Button();
            btnVerAgendamentos = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new Point(193, 147);
            btnAddPet.Margin = new Padding(3, 2, 3, 2);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(108, 50);
            btnAddPet.TabIndex = 0;
            btnAddPet.Text = "Adicionar novo Pet?";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnNovoAgendamento
            // 
            btnNovoAgendamento.Location = new Point(12, 82);
            btnNovoAgendamento.Margin = new Padding(3, 2, 3, 2);
            btnNovoAgendamento.Name = "btnNovoAgendamento";
            btnNovoAgendamento.Size = new Size(190, 40);
            btnNovoAgendamento.TabIndex = 1;
            btnNovoAgendamento.Text = "Novo Agendamento?";
            btnNovoAgendamento.UseVisualStyleBackColor = true;
            btnNovoAgendamento.Click += btnNovoAgendamento_Click;
            // 
            // btnVerAgendamentos
            // 
            btnVerAgendamentos.Location = new Point(291, 82);
            btnVerAgendamentos.Margin = new Padding(3, 2, 3, 2);
            btnVerAgendamentos.Name = "btnVerAgendamentos";
            btnVerAgendamentos.Size = new Size(199, 40);
            btnVerAgendamentos.TabIndex = 2;
            btnVerAgendamentos.Text = "Ver agendamentos?";
            btnVerAgendamentos.UseVisualStyleBackColor = true;
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
            // CustomizadoBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 233, 215);
            ClientSize = new Size(514, 208);
            Controls.Add(label4);
            Controls.Add(btnVerAgendamentos);
            Controls.Add(btnNovoAgendamento);
            Controls.Add(btnAddPet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomizadoBox";
            Text = "CustomizadoBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPet;
        private Button btnNovoAgendamento;
        private Button btnVerAgendamentos;
        private Label label4;
    }
}