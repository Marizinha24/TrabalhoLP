namespace TrabalhoLP
{
    partial class AgendamentosPet
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
            pbPet = new PictureBox();
            lvHistorico = new ListView();
            lblUsuario = new Label();
            lblRaca = new Label();
            lblNomePet = new Label();
            lblEspecie = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPet).BeginInit();
            SuspendLayout();
            // 
            // pbPet
            // 
            pbPet.Location = new Point(12, 12);
            pbPet.Name = "pbPet";
            pbPet.Size = new Size(179, 154);
            pbPet.TabIndex = 0;
            pbPet.TabStop = false;
            // 
            // lvHistorico
            // 
            lvHistorico.Location = new Point(12, 223);
            lvHistorico.Name = "lvHistorico";
            lvHistorico.Size = new Size(1017, 404);
            lvHistorico.TabIndex = 1;
            lvHistorico.UseCompatibleStateImageBehavior = false;
            lvHistorico.SelectedIndexChanged += lvHistorico_SelectedIndexChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(250, 55);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "label1";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Location = new Point(604, 146);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(50, 20);
            lblRaca.TabIndex = 3;
            lblRaca.Text = "label2";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(357, 55);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(50, 20);
            lblNomePet.TabIndex = 4;
            lblNomePet.Text = "label3";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(458, 146);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(50, 20);
            lblEspecie.TabIndex = 5;
            lblEspecie.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 21);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 6;
            label5.Text = "Tutor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 21);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 7;
            label6.Text = "Pet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 111);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Especie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(604, 111);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 9;
            label8.Text = "Raça";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(887, 21);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(130, 67);
            btnHome.TabIndex = 10;
            btnHome.Text = "Home Page";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // AgendamentosPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 639);
            Controls.Add(btnHome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblEspecie);
            Controls.Add(lblNomePet);
            Controls.Add(lblRaca);
            Controls.Add(lblUsuario);
            Controls.Add(lvHistorico);
            Controls.Add(pbPet);
            Name = "AgendamentosPet";
            Text = "AgendamentosPet";
            ((System.ComponentModel.ISupportInitialize)pbPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPet;
        private ListView lvHistorico;
        private Label lblUsuario;
        private Label lblRaca;
        private Label lblNomePet;
        private Label lblEspecie;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnHome;
    }
}