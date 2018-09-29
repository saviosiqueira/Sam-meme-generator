namespace SAM_Meme_Generator
{
    partial class FormGerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerador));
            this.groupBoxMeme1 = new System.Windows.Forms.GroupBox();
            this.meme1_3 = new System.Windows.Forms.RadioButton();
            this.meme1_2 = new System.Windows.Forms.RadioButton();
            this.meme1_1 = new System.Windows.Forms.RadioButton();
            this.groupBoxMeme2 = new System.Windows.Forms.GroupBox();
            this.meme2_3 = new System.Windows.Forms.RadioButton();
            this.meme2_2 = new System.Windows.Forms.RadioButton();
            this.meme2_1 = new System.Windows.Forms.RadioButton();
            this.textoMeme = new System.Windows.Forms.TextBox();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.groupBoxFoto = new System.Windows.Forms.GroupBox();
            this.botaoIrineu = new System.Windows.Forms.RadioButton();
            this.memeEscolhido = new System.Windows.Forms.PictureBox();
            this.botaoVinDiesel = new System.Windows.Forms.RadioButton();
            this.botaoGerar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxMeme1.SuspendLayout();
            this.groupBoxMeme2.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.groupBoxFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memeEscolhido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMeme1
            // 
            this.groupBoxMeme1.Controls.Add(this.meme1_3);
            this.groupBoxMeme1.Controls.Add(this.meme1_2);
            this.groupBoxMeme1.Controls.Add(this.meme1_1);
            this.groupBoxMeme1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMeme1.Name = "groupBoxMeme1";
            this.groupBoxMeme1.Size = new System.Drawing.Size(108, 111);
            this.groupBoxMeme1.TabIndex = 3;
            this.groupBoxMeme1.TabStop = false;
            this.groupBoxMeme1.Text = "Meme 1";
            // 
            // meme1_3
            // 
            this.meme1_3.AutoSize = true;
            this.meme1_3.Location = new System.Drawing.Point(6, 65);
            this.meme1_3.Name = "meme1_3";
            this.meme1_3.Size = new System.Drawing.Size(67, 17);
            this.meme1_3.TabIndex = 2;
            this.meme1_3.Text = "AI VOCÊ";
            this.meme1_3.UseVisualStyleBackColor = true;
            // 
            // meme1_2
            // 
            this.meme1_2.AutoSize = true;
            this.meme1_2.Location = new System.Drawing.Point(6, 42);
            this.meme1_2.Name = "meme1_2";
            this.meme1_2.Size = new System.Drawing.Size(72, 17);
            this.meme1_2.TabIndex = 1;
            this.meme1_2.Text = "QUANDO";
            this.meme1_2.UseVisualStyleBackColor = true;
            // 
            // meme1_1
            // 
            this.meme1_1.AutoSize = true;
            this.meme1_1.Checked = true;
            this.meme1_1.Location = new System.Drawing.Point(6, 18);
            this.meme1_1.Name = "meme1_1";
            this.meme1_1.Size = new System.Drawing.Size(68, 17);
            this.meme1_1.TabIndex = 0;
            this.meme1_1.TabStop = true;
            this.meme1_1.Text = "EIS QUE";
            this.meme1_1.UseVisualStyleBackColor = true;
            this.meme1_1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxMeme2
            // 
            this.groupBoxMeme2.Controls.Add(this.radioButton1);
            this.groupBoxMeme2.Controls.Add(this.meme2_3);
            this.groupBoxMeme2.Controls.Add(this.meme2_2);
            this.groupBoxMeme2.Controls.Add(this.meme2_1);
            this.groupBoxMeme2.Location = new System.Drawing.Point(126, 12);
            this.groupBoxMeme2.Name = "groupBoxMeme2";
            this.groupBoxMeme2.Size = new System.Drawing.Size(115, 111);
            this.groupBoxMeme2.TabIndex = 4;
            this.groupBoxMeme2.TabStop = false;
            this.groupBoxMeme2.Text = "Meme 2";
            // 
            // meme2_3
            // 
            this.meme2_3.AutoSize = true;
            this.meme2_3.Location = new System.Drawing.Point(6, 64);
            this.meme2_3.Name = "meme2_3";
            this.meme2_3.Size = new System.Drawing.Size(82, 17);
            this.meme2_3.TabIndex = 2;
            this.meme2_3.Text = "A MORENA";
            this.meme2_3.UseVisualStyleBackColor = true;
            // 
            // meme2_2
            // 
            this.meme2_2.AutoSize = true;
            this.meme2_2.Location = new System.Drawing.Point(6, 41);
            this.meme2_2.Name = "meme2_2";
            this.meme2_2.Size = new System.Drawing.Size(64, 17);
            this.meme2_2.TabIndex = 1;
            this.meme2_2.Text = "A 10/10";
            this.meme2_2.UseVisualStyleBackColor = true;
            // 
            // meme2_1
            // 
            this.meme2_1.AutoSize = true;
            this.meme2_1.Checked = true;
            this.meme2_1.Location = new System.Drawing.Point(6, 18);
            this.meme2_1.Name = "meme2_1";
            this.meme2_1.Size = new System.Drawing.Size(73, 17);
            this.meme2_1.TabIndex = 0;
            this.meme2_1.TabStop = true;
            this.meme2_1.Text = "O IRINEU";
            this.meme2_1.UseVisualStyleBackColor = true;
            // 
            // textoMeme
            // 
            this.textoMeme.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textoMeme.Location = new System.Drawing.Point(6, 19);
            this.textoMeme.Multiline = true;
            this.textoMeme.Name = "textoMeme";
            this.textoMeme.Size = new System.Drawing.Size(250, 86);
            this.textoMeme.TabIndex = 5;
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.textoMeme);
            this.groupBoxText.Location = new System.Drawing.Point(247, 12);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(262, 111);
            this.groupBoxText.TabIndex = 6;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Texto";
            // 
            // groupBoxFoto
            // 
            this.groupBoxFoto.Controls.Add(this.botaoIrineu);
            this.groupBoxFoto.Controls.Add(this.memeEscolhido);
            this.groupBoxFoto.Controls.Add(this.botaoVinDiesel);
            this.groupBoxFoto.Location = new System.Drawing.Point(12, 129);
            this.groupBoxFoto.Name = "groupBoxFoto";
            this.groupBoxFoto.Size = new System.Drawing.Size(229, 241);
            this.groupBoxFoto.TabIndex = 7;
            this.groupBoxFoto.TabStop = false;
            this.groupBoxFoto.Text = "Foto";
            // 
            // botaoIrineu
            // 
            this.botaoIrineu.AutoSize = true;
            this.botaoIrineu.Checked = true;
            this.botaoIrineu.Location = new System.Drawing.Point(6, 19);
            this.botaoIrineu.Name = "botaoIrineu";
            this.botaoIrineu.Size = new System.Drawing.Size(51, 17);
            this.botaoIrineu.TabIndex = 4;
            this.botaoIrineu.TabStop = true;
            this.botaoIrineu.Text = "Irineu";
            this.botaoIrineu.UseVisualStyleBackColor = true;
            this.botaoIrineu.CheckedChanged += new System.EventHandler(this.botaoIrineu_CheckedChanged);
            // 
            // memeEscolhido
            // 
            this.memeEscolhido.Image = global::SAM_Meme_Generator.Properties.Resources.irineu;
            this.memeEscolhido.Location = new System.Drawing.Point(6, 65);
            this.memeEscolhido.Name = "memeEscolhido";
            this.memeEscolhido.Size = new System.Drawing.Size(215, 170);
            this.memeEscolhido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memeEscolhido.TabIndex = 3;
            this.memeEscolhido.TabStop = false;
            // 
            // botaoVinDiesel
            // 
            this.botaoVinDiesel.AutoSize = true;
            this.botaoVinDiesel.Location = new System.Drawing.Point(6, 42);
            this.botaoVinDiesel.Name = "botaoVinDiesel";
            this.botaoVinDiesel.Size = new System.Drawing.Size(72, 17);
            this.botaoVinDiesel.TabIndex = 2;
            this.botaoVinDiesel.Text = "Vin Diesel";
            this.botaoVinDiesel.UseVisualStyleBackColor = true;
            this.botaoVinDiesel.CheckedChanged += new System.EventHandler(this.botaoVinDiesel_CheckedChanged);
            // 
            // botaoGerar
            // 
            this.botaoGerar.Location = new System.Drawing.Point(209, 376);
            this.botaoGerar.Name = "botaoGerar";
            this.botaoGerar.Size = new System.Drawing.Size(75, 23);
            this.botaoGerar.TabIndex = 8;
            this.botaoGerar.Text = "Gerar";
            this.botaoGerar.UseVisualStyleBackColor = true;
            this.botaoGerar.Click += new System.EventHandler(this.botaoGerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAM_Meme_Generator.Properties.Resources.samemes;
            this.pictureBox1.Location = new System.Drawing.Point(253, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Outro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoGerar);
            this.Controls.Add(this.groupBoxFoto);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.groupBoxMeme2);
            this.Controls.Add(this.groupBoxMeme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGerador";
            this.Text = "SAM MEME GENERATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMeme1.ResumeLayout(false);
            this.groupBoxMeme1.PerformLayout();
            this.groupBoxMeme2.ResumeLayout(false);
            this.groupBoxMeme2.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxFoto.ResumeLayout(false);
            this.groupBoxFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memeEscolhido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMeme1;
        private System.Windows.Forms.RadioButton meme1_3;
        private System.Windows.Forms.RadioButton meme1_2;
        private System.Windows.Forms.RadioButton meme1_1;
        private System.Windows.Forms.GroupBox groupBoxMeme2;
        private System.Windows.Forms.RadioButton meme2_3;
        private System.Windows.Forms.RadioButton meme2_2;
        private System.Windows.Forms.RadioButton meme2_1;
        private System.Windows.Forms.TextBox textoMeme;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.GroupBox groupBoxFoto;
        private System.Windows.Forms.PictureBox memeEscolhido;
        private System.Windows.Forms.RadioButton botaoVinDiesel;
        private System.Windows.Forms.RadioButton botaoIrineu;
        private System.Windows.Forms.Button botaoGerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

