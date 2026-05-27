namespace TrabalhoLP
{
    partial class Agendamento_de_Serviços
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
            rdbCompleto = new RadioButton();
            rdbHidratacao = new RadioButton();
            rdbUnhas = new RadioButton();
            rdbBanhoTosa = new RadioButton();
            rdbBanhoHidratacaoUnha = new RadioButton();
            txtAgendamentos = new TextBox();
            dtDisponibilidade = new DateTimePicker();
            lblTotal = new Label();
            cbHorario = new ComboBox();
            gbPacotes = new GroupBox();
            label1 = new Label();
            grbServicos = new GroupBox();
            rdbHigienica = new RadioButton();
            rdbSimples = new RadioButton();
            lblServiços = new Label();
            btnConfirmar = new Button();
            lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            gbPacotes.SuspendLayout();
            grbServicos.SuspendLayout();
            SuspendLayout();
            // 
            // rdbCompleto
            // 
            rdbCompleto.AutoSize = true;
            rdbCompleto.Font = new Font("Cooper Black", 18F);
            rdbCompleto.ForeColor = Color.FromArgb(89, 50, 19);
            rdbCompleto.Location = new Point(6, 136);
            rdbCompleto.Name = "rdbCompleto";
            rdbCompleto.Size = new Size(342, 31);
            rdbCompleto.TabIndex = 1;
            rdbCompleto.TabStop = true;
            rdbCompleto.Text = "Tosa Completa -> R$ 60,00";
            rdbCompleto.UseVisualStyleBackColor = true;
            // 
            // rdbHidratacao
            // 
            rdbHidratacao.AutoSize = true;
            rdbHidratacao.Font = new Font("Cooper Black", 18F);
            rdbHidratacao.ForeColor = Color.FromArgb(89, 50, 19);
            rdbHidratacao.Location = new Point(6, 99);
            rdbHidratacao.Name = "rdbHidratacao";
            rdbHidratacao.Size = new Size(400, 31);
            rdbHidratacao.TabIndex = 3;
            rdbHidratacao.TabStop = true;
            rdbHidratacao.Text = "Banho + Hidratação → R$ 55,00";
            rdbHidratacao.UseVisualStyleBackColor = true;
            // 
            // rdbUnhas
            // 
            rdbUnhas.AutoSize = true;
            rdbUnhas.Font = new Font("Cooper Black", 18F);
            rdbUnhas.ForeColor = Color.FromArgb(89, 50, 19);
            rdbUnhas.Location = new Point(6, 210);
            rdbUnhas.Name = "rdbUnhas";
            rdbUnhas.Size = new Size(346, 31);
            rdbUnhas.TabIndex = 4;
            rdbUnhas.TabStop = true;
            rdbUnhas.Text = "Corte de Unhas → R$ 15,00";
            rdbUnhas.UseVisualStyleBackColor = true;
            // 
            // rdbBanhoTosa
            // 
            rdbBanhoTosa.AutoSize = true;
            rdbBanhoTosa.Font = new Font("Cooper Black", 18F);
            rdbBanhoTosa.ForeColor = Color.FromArgb(89, 50, 19);
            rdbBanhoTosa.Location = new Point(138, 124);
            rdbBanhoTosa.Name = "rdbBanhoTosa";
            rdbBanhoTosa.Size = new Size(322, 31);
            rdbBanhoTosa.TabIndex = 5;
            rdbBanhoTosa.TabStop = true;
            rdbBanhoTosa.Text = "Banho + Tosa -> R$ 80,00";
            rdbBanhoTosa.UseVisualStyleBackColor = true;
            // 
            // rdbBanhoHidratacaoUnha
            // 
            rdbBanhoHidratacaoUnha.AutoSize = true;
            rdbBanhoHidratacaoUnha.Font = new Font("Cooper Black", 18F);
            rdbBanhoHidratacaoUnha.ForeColor = Color.FromArgb(89, 50, 19);
            rdbBanhoHidratacaoUnha.Location = new Point(6, 76);
            rdbBanhoHidratacaoUnha.Name = "rdbBanhoHidratacaoUnha";
            rdbBanhoHidratacaoUnha.Size = new Size(598, 31);
            rdbBanhoHidratacaoUnha.TabIndex = 6;
            rdbBanhoHidratacaoUnha.TabStop = true;
            rdbBanhoHidratacaoUnha.Text = "Banho + Hidratação + Corte de Unha -> R$75,00";
            rdbBanhoHidratacaoUnha.UseVisualStyleBackColor = true;
            // 
            // txtAgendamentos
            // 
            txtAgendamentos.BackColor = Color.FromArgb(160, 211, 241);
            txtAgendamentos.Font = new Font("Cooper Black", 8.25F);
            txtAgendamentos.ForeColor = Color.FromArgb(89, 50, 19);
            txtAgendamentos.Location = new Point(667, 502);
            txtAgendamentos.Multiline = true;
            txtAgendamentos.Name = "txtAgendamentos";
            txtAgendamentos.ReadOnly = true;
            txtAgendamentos.Size = new Size(301, 110);
            txtAgendamentos.TabIndex = 7;
            // 
            // dtDisponibilidade
            // 
            dtDisponibilidade.Format = DateTimePickerFormat.Short;
            dtDisponibilidade.Location = new Point(380, 449);
            dtDisponibilidade.Name = "dtDisponibilidade";
            dtDisponibilidade.Size = new Size(98, 23);
            dtDisponibilidade.TabIndex = 8;
            dtDisponibilidade.ValueChanged += dtDisponibilidade_ValueChanged_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(739, 696);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0,00";
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(589, 449);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(121, 23);
            cbHorario.TabIndex = 10;
            // 
            // gbPacotes
            // 
            gbPacotes.BackColor = Color.FromArgb(160, 211, 241);
            gbPacotes.Controls.Add(label1);
            gbPacotes.Controls.Add(rdbBanhoHidratacaoUnha);
            gbPacotes.Controls.Add(rdbBanhoTosa);
            gbPacotes.Font = new Font("Cooper Black", 8.25F);
            gbPacotes.ForeColor = Color.FromArgb(89, 50, 19);
            gbPacotes.Location = new Point(508, 128);
            gbPacotes.Name = "gbPacotes";
            gbPacotes.Size = new Size(616, 188);
            gbPacotes.TabIndex = 11;
            gbPacotes.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 218, 229);
            label1.Location = new Point(229, 25);
            label1.Name = "label1";
            label1.Size = new Size(134, 34);
            label1.TabIndex = 15;
            label1.Text = "Pacotes:";
            // 
            // grbServicos
            // 
            grbServicos.BackColor = Color.FromArgb(160, 211, 241);
            grbServicos.Controls.Add(rdbHigienica);
            grbServicos.Controls.Add(rdbSimples);
            grbServicos.Controls.Add(lblServiços);
            grbServicos.Controls.Add(rdbCompleto);
            grbServicos.Controls.Add(rdbUnhas);
            grbServicos.Controls.Add(rdbHidratacao);
            grbServicos.Font = new Font("Cooper Black", 8.25F);
            grbServicos.ForeColor = Color.FromArgb(89, 50, 19);
            grbServicos.Location = new Point(23, 92);
            grbServicos.Name = "grbServicos";
            grbServicos.Size = new Size(428, 252);
            grbServicos.TabIndex = 12;
            grbServicos.TabStop = false;
            // 
            // rdbHigienica
            // 
            rdbHigienica.AutoSize = true;
            rdbHigienica.Font = new Font("Cooper Black", 18F);
            rdbHigienica.ForeColor = Color.FromArgb(89, 50, 19);
            rdbHigienica.Location = new Point(6, 173);
            rdbHigienica.Name = "rdbHigienica";
            rdbHigienica.Size = new Size(341, 31);
            rdbHigienica.TabIndex = 8;
            rdbHigienica.TabStop = true;
            rdbHigienica.Text = "Tosa Higiênica -> R$ 35,00";
            rdbHigienica.UseVisualStyleBackColor = true;
            // 
            // rdbSimples
            // 
            rdbSimples.AutoSize = true;
            rdbSimples.Font = new Font("Cooper Black", 18F);
            rdbSimples.ForeColor = Color.FromArgb(89, 50, 19);
            rdbSimples.Location = new Point(6, 62);
            rdbSimples.Name = "rdbSimples";
            rdbSimples.Size = new Size(342, 31);
            rdbSimples.TabIndex = 7;
            rdbSimples.TabStop = true;
            rdbSimples.Text = "Banho Simples -> R$ 30,00";
            rdbSimples.UseVisualStyleBackColor = true;
            // 
            // lblServiços
            // 
            lblServiços.AutoSize = true;
            lblServiços.Font = new Font("Cooper Black", 22F);
            lblServiços.ForeColor = Color.FromArgb(252, 218, 229);
            lblServiços.Location = new Point(56, 16);
            lblServiços.Name = "lblServiços";
            lblServiços.Size = new Size(308, 35);
            lblServiços.TabIndex = 6;
            lblServiços.Text = "Serviços principais";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 130, 179);
            btnConfirmar.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.SaddleBrown;
            btnConfirmar.Location = new Point(242, 665);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 29);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Cooper Black", 20F);
            lbl.ForeColor = Color.FromArgb(89, 50, 19);
            lbl.Location = new Point(79, 581);
            lbl.Name = "lbl";
            lbl.Size = new Size(87, 31);
            lbl.TabIndex = 14;
            lbl.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(160, 211, 241);
            label2.Font = new Font("Cooper Black", 8.25F);
            label2.ForeColor = Color.FromArgb(89, 50, 19);
            label2.Location = new Point(749, 502);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 7;
            label2.Text = "Seus agendamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 30F);
            label3.ForeColor = Color.FromArgb(89, 50, 19);
            label3.Location = new Point(242, 25);
            label3.Name = "label3";
            label3.Size = new Size(707, 46);
            label3.TabIndex = 7;
            label3.Text = "Qual serviço gostaria de agendar ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 20F);
            label4.ForeColor = Color.FromArgb(89, 50, 19);
            label4.Location = new Point(324, 368);
            label4.Name = "label4";
            label4.Size = new Size(443, 31);
            label4.TabIndex = 15;
            label4.Text = "Escolha uma data e um hórario:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 130, 179);
            btnCancelar.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.SaddleBrown;
            btnCancelar.Location = new Point(536, 665);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 29);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // Agendamento_de_Serviços
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 235);
            ClientSize = new Size(1379, 749);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl);
            Controls.Add(btnConfirmar);
            Controls.Add(grbServicos);
            Controls.Add(gbPacotes);
            Controls.Add(cbHorario);
            Controls.Add(lblTotal);
            Controls.Add(dtDisponibilidade);
            Controls.Add(txtAgendamentos);
            Name = "Agendamento_de_Serviços";
            Text = "Agendamento_de_Serviços";
            gbPacotes.ResumeLayout(false);
            gbPacotes.PerformLayout();
            grbServicos.ResumeLayout(false);
            grbServicos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbCompleto;
        private RadioButton rdbHidratacao;
        private RadioButton rdbUnhas;
        private RadioButton rdbBanhoTosa;
        private RadioButton rdbBanhoHidratacaoUnha;
        private TextBox txtAgendamentos;
        private DateTimePicker dtDisponibilidade;
        private Label lblTotal;
        private ComboBox cbHorario;
        private GroupBox gbPacotes;
        private GroupBox grbServicos;
        private Label lblServiços;
        private Button btnConfirmar;
        private Label lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rdbSimples;
        private RadioButton rdbHigienica;
        private Button btnCancelar;
    }
}