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
            btnAddPet.Location = new Point(52, 117);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(124, 66);
            btnAddPet.TabIndex = 0;
            btnAddPet.Text = "Adicionar novo Pet?";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnNovoAgendamento
            // 
            btnNovoAgendamento.Location = new Point(287, 88);
            btnNovoAgendamento.Name = "btnNovoAgendamento";
            btnNovoAgendamento.Size = new Size(217, 53);
            btnNovoAgendamento.TabIndex = 1;
            btnNovoAgendamento.Text = "Novo Agendamento?";
            btnNovoAgendamento.UseVisualStyleBackColor = true;
            btnNovoAgendamento.Click += btnNovoAgendamento_Click;
            // 
            // btnVerAgendamentos
            // 
            btnVerAgendamentos.Location = new Point(287, 168);
            btnVerAgendamentos.Name = "btnVerAgendamentos";
            btnVerAgendamentos.Size = new Size(227, 60);
            btnVerAgendamentos.TabIndex = 2;
            btnVerAgendamentos.Text = "Ver agendamentos?";
            btnVerAgendamentos.UseVisualStyleBackColor = true;
            btnVerAgendamentos.Click += btnVerAgendamentos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(130, 34);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 11;
            label4.Text = "O que deseja fazer?";
            // 
            // CustomizadoBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 247);
            Controls.Add(label4);
            Controls.Add(btnVerAgendamentos);
            Controls.Add(btnNovoAgendamento);
            Controls.Add(btnAddPet);
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