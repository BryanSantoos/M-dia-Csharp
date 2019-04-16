using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarando Variáveis
            double av1, av2, media;
            //Entrada de Dados
            av1 = Convert.ToDouble(txtav1.Text);
            av2 = Convert.ToDouble(txtav2.Text);
            //Processamento
            media = (av1 + av2) / 2;
            txtmedia.Text = media.ToString();

            //Condicional Simples
            if(media >= 6)
            {
                txtMedia.ForeColor = Color.Blue; 
                MessageBox.Show("Aluno aprovado com média = " + media, "Cálculo de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (media >= 4 && media < 6)
            {
                MessageBox.Show("Aluno em recuperação com média = " + media, "Cálculo de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aluno reprovado com média = " + media, "Cálculo de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void txtav1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtav2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblav2_Click(object sender, EventArgs e)
        {

        }
    }
}
