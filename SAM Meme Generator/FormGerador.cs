using System;
using System.Linq;
using System.Windows.Forms;
using SAM_Meme_Generator.Properties;

namespace SAM_Meme_Generator
{
    public partial class FormGerador : Form
    {
        public FormGerador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botaoGerar_Click(object sender, EventArgs e)
        {
            Meme meme = new Meme
            {
                Texto1 = groupBoxMeme1.Controls.OfType<RadioButton>().FirstOrDefault(botao => botao.Checked)?.Text,
                Texto2 = groupBoxMeme2.Controls.OfType<RadioButton>().FirstOrDefault(botao => botao.Checked)?.Text,
                Texto3 = textoMeme.Text,
                MemeImage = memeEscolhido.Image
            };
            TelaResultado telaResultado = new TelaResultado(meme);
            telaResultado.Show();
        }

        private void botaoIrineu_CheckedChanged(object sender, EventArgs e)
        {
            memeEscolhido.Image = Resources.irineu;
        }

        private void botaoVinDiesel_CheckedChanged(object sender, EventArgs e)
        {
            memeEscolhido.Image = Resources.vindiesel;
        }
    }
}
