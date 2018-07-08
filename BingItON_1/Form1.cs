using SmartBing;
using SmartBing.UIClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingItON_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Process the text entered in English Textbox
            var inputText = textBox2.Text;
            var selectedLanguage = comboBox1.SelectedItem?.ToString() ?? "Tamil";
            textBox3.Text = new SmartTranslator(new OrignPhonoMorphoStrategy())
                .SmartlyTranslate(new SmartBing.DataModel.InputData {
                        InputWord = inputText, Language = selectedLanguage
                    }
                ).ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(PictureGiver.PictureDictionary[inputText]);
            }
            catch {
                pictureBox1.Image = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }
    }
}
