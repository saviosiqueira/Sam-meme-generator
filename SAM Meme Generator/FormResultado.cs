using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAM_Meme_Generator
{
    public partial class TelaResultado : Form
    {
        public TelaResultado()
        {
            InitializeComponent();
        }

        public TelaResultado(Meme meme)
        {
            InitializeComponent();
            textBox1.Text = meme.MemeCompleto();
            pictureBox1.Image = meme.MemeImage;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = new Point(10, 140);
            pictureBox1.Focus();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaResultado_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
