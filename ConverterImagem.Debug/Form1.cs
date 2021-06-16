using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterImagem.Debug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCaminhoArquivo.Text))
            {
                MessageBox.Show("Informe o arquivo.");  
            }
            else
            {
                try
                {
                    var convert = new Converter();
                    convert.ConvertTo24bpp(txtCaminhoArquivo.Text);
                    MessageBox.Show("Sucesso!.");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Erro ao converter a imagem. {Ex.Message}");
                }
                
            }
            
        }
    }
}
