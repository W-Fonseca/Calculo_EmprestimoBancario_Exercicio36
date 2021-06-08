using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio36 {
    public partial class Form1 : Form {
        float ValorCasa;
        float ValorSalario;
        int AnosPagar;
        public Form1() {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            ValorCasa = float.Parse(textBox1.Text);
            ValorSalario = float.Parse(textBox2.Text);
            AnosPagar = int.Parse(textBox3.Text);


            int meses = AnosPagar * 12;
            float Parcela = ValorCasa / meses;
            float TrintaPorcento = ValorSalario * 0.30f;

            if (Parcela > TrintaPorcento) {
                label5.Text = "Você não consegue fazer o emprestimo! \n " +
                    "A parcela atinge mais de 30% do seu salario \n" +
                    $"Parcela = {Parcela:f2} \n" +
                    $"30% do Salario {TrintaPorcento:f2}";
            } else {
                label5.Text = $"Você consegue o financiamento! \n" +
                    $"Sua parcela será: {Parcela:f2}";
                      }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
