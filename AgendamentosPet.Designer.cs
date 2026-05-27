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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendamentosPet));
            pbPet = new PictureBox();
            lvHistorico = new ListView();
            btnConcluido = new Button();
            btnCancelar = new Button();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblUsuario = new Label();
            lblRaca = new Label();
            lblNomePet = new Label();
            lblEspecie = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbPet
            // 
            pbPet.Location = new Point(87, 28);
            pbPet.Margin = new Padding(3, 2, 3, 2);
            pbPet.Name = "pbPet";
            pbPet.Size = new Size(157, 116);
            pbPet.TabIndex = 0;
            pbPet.TabStop = false;
            // 
            // lvHistorico
            // 
            lvHistorico.BackColor = Color.FromArgb(255, 225, 235);
            lvHistorico.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvHistorico.Location = new Point(12, 173);
            lvHistorico.Margin = new Padding(3, 2, 3, 2);
            lvHistorico.Name = "lvHistorico";
            lvHistorico.Size = new Size(1160, 565);
            lvHistorico.TabIndex = 1;
            lvHistorico.UseCompatibleStateImageBehavior = false;
            lvHistorico.SelectedIndexChanged += lvHistorico_SelectedIndexChanged;
            // 
            // btnConcluido
            // 
            btnConcluido.BackColor = Color.FromArgb(166, 213, 120);
            btnConcluido.FlatStyle = FlatStyle.Popup;
            btnConcluido.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConcluido.ForeColor = Color.White;
            btnConcluido.Location = new Point(876, 137);
            btnConcluido.Margin = new Padding(3, 2, 3, 2);
            btnConcluido.Name = "btnConcluido";
            btnConcluido.Size = new Size(126, 32);
            btnConcluido.TabIndex = 11;
            btnConcluido.Text = "Concluido";
            btnConcluido.UseVisualStyleBackColor = false;
            btnConcluido.Click += btnConcluido_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(227, 94, 101);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Cooper Black", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1018, 137);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 32);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1038, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 97);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(611, 64);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "label1";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Location = new Point(528, 110);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(38, 15);
            lblRaca.TabIndex = 3;
            lblRaca.Text = "label2";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(312, 41);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(38, 15);
            lblNomePet.TabIndex = 4;
            lblNomePet.Text = "label3";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(401, 110);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(38, 15);
            lblEspecie.TabIndex = 5;
            lblEspecie.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(439, 16);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Tutor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 16);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 7;
            label6.Text = "Pet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 83);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 8;
            label7.Text = "Especie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(528, 83);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 9;
            label8.Text = "Raça";
            // 
            // AgendamentosPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 235);
            ClientSize = new Size(1379, 749);
            Controls.Add(pictureBox4);
            Controls.Add(btnCancelar);
            Controls.Add(btnConcluido);
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
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgendamentosPet";
            Text = "AgendamentosPet";
            ((System.ComponentModel.ISupportInitialize)pbPet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPet;
        private ListView lvHistorico;
        private Button btnConcluido;
        private Button btnCancelar;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblUsuario;
        private Label lblRaca;
        private Label lblNomePet;
        private Label lblEspecie;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}