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
            pbPet.Location = new Point(99, 37);
            pbPet.Name = "pbPet";
            pbPet.Size = new Size(179, 155);
            pbPet.TabIndex = 0;
            pbPet.TabStop = false;
            // 
            // lvHistorico
            // 
            lvHistorico.BackColor = Color.FromArgb(255, 225, 235);
            lvHistorico.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvHistorico.Location = new Point(14, 231);
            lvHistorico.Name = "lvHistorico";
            lvHistorico.Size = new Size(1325, 752);
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
            btnConcluido.Location = new Point(982, 183);
            btnConcluido.Name = "btnConcluido";
            btnConcluido.Size = new Size(163, 43);
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
            btnCancelar.Location = new Point(1163, 183);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 43);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1186, 1);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 129);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 167);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(59, 1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cooper Black", 20F);
            lblUsuario.ForeColor = Color.FromArgb(89, 50, 19);
            lblUsuario.Location = new Point(482, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(119, 39);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "label1";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Cooper Black", 20F);
            lblRaca.ForeColor = Color.FromArgb(89, 50, 19);
            lblRaca.Location = new Point(840, 60);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(119, 39);
            lblRaca.TabIndex = 3;
            lblRaca.Text = "label2";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Font = new Font("Cooper Black", 20F);
            lblNomePet.ForeColor = Color.FromArgb(89, 50, 19);
            lblNomePet.Location = new Point(332, 60);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(119, 39);
            lblNomePet.TabIndex = 4;
            lblNomePet.Text = "label3";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Cooper Black", 20F);
            lblEspecie.ForeColor = Color.FromArgb(89, 50, 19);
            lblEspecie.Location = new Point(657, 60);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(119, 39);
            lblEspecie.TabIndex = 5;
            lblEspecie.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 20F);
            label5.ForeColor = Color.FromArgb(89, 50, 19);
            label5.Location = new Point(483, 16);
            label5.Name = "label5";
            label5.Size = new Size(118, 39);
            label5.TabIndex = 6;
            label5.Text = "Tutor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20F);
            label6.ForeColor = Color.FromArgb(89, 50, 19);
            label6.Location = new Point(357, 16);
            label6.Name = "label6";
            label6.Size = new Size(74, 39);
            label6.TabIndex = 7;
            label6.Text = "Pet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 20F);
            label7.ForeColor = Color.FromArgb(89, 50, 19);
            label7.Location = new Point(657, 16);
            label7.Name = "label7";
            label7.Size = new Size(145, 39);
            label7.TabIndex = 8;
            label7.Text = "Especie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 20F);
            label8.ForeColor = Color.FromArgb(89, 50, 19);
            label8.Location = new Point(893, 16);
            label8.Name = "label8";
            label8.Size = new Size(99, 39);
            label8.TabIndex = 9;
            label8.Text = "Raça";
            // 
            // AgendamentosPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 235);
            ClientSize = new Size(1576, 999);
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