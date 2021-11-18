using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormCombustível : Form
    {
        public FormCombustível()
        {
            InitializeComponent();
        }

        private void tipoCombustivel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                qtdLitros.Focus();
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double qtdLitrosCombustivel, precoLitroGasolina, precoLitroAlcool, precoLitroDesc, precoLitroSemDesc, desconto;

            if (tipoCombustivel.Text == "")
            {
                MessageBox.Show("Selecione um tipo de combustível", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (qtdLitros.Text == "")
            {
                MessageBox.Show("Digite a quantidade de litros", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            qtdLitrosCombustivel = Convert.ToDouble(qtdLitros.Text);

            if (tipoCombustivel.Text == "Álcool")
            {
                lbl_Preço_Litro_SemDesc.Text = String.Format("{0:n2}", 5.19);
                precoLitroSemDesc = Convert.ToDouble(lbl_Preço_Litro_SemDesc.Text);

                if (qtdLitrosCombustivel == 20)
                {
                    precoLitroAlcool = 5.19 * qtdLitrosCombustivel;
                    desconto = (qtdLitrosCombustivel * 3) / 100;
                    precoLitroDesc = precoLitroAlcool - desconto;
                    lbl_Preco_Total_Comb.Text = String.Format("{0:n2}", precoLitroDesc);
                    lbl_Preço_Litro_ComDesc.Text = String.Format("{0:n2}", precoLitroDesc);
                }
                if (qtdLitrosCombustivel > 20)
                {
                    precoLitroAlcool = 5.19 * qtdLitrosCombustivel;
                    desconto = (qtdLitrosCombustivel * 5) / 100;
                    precoLitroDesc = precoLitroAlcool - desconto;
                    lbl_Preco_Total_Comb.Text = String.Format("{0:n2}", precoLitroDesc);
                    lbl_Preço_Litro_ComDesc.Text = String.Format("{0:n2}", precoLitroDesc);
                }
                if (qtdLitrosCombustivel < 20)
                {
                    precoLitroAlcool = 5.19 * qtdLitrosCombustivel;
                    lbl_Qtd_Total_Litros.Text = qtdLitros.Text;
                    lbl_Preco_Total_Comb.Text = String.Format("{0:n2}", precoLitroAlcool);
                }

                lbl_Qtd_Total_Litros.Text = qtdLitros.Text;
            }

            if (tipoCombustivel.Text == "Gasolina")
            {
                lbl_Preço_Litro_SemDesc.Text = String.Format("{0:n2}", 6.29);
                precoLitroSemDesc = Convert.ToDouble(lbl_Preço_Litro_SemDesc.Text);

                if (qtdLitrosCombustivel == 20)
                {
                    precoLitroGasolina = 6.29 * qtdLitrosCombustivel;
                    desconto = (qtdLitrosCombustivel * 4) / 100;
                    precoLitroDesc = precoLitroGasolina - desconto;
                    lbl_Qtd_Total_Litros.Text = qtdLitros.Text;
                    lbl_Preco_Total_Comb.Text = Convert.ToString(precoLitroDesc);
                    lbl_Preço_Litro_ComDesc.Text = String.Format("{0:n2}", precoLitroDesc);
                }
                if (qtdLitrosCombustivel > 20)
                {
                    precoLitroGasolina = 6.29 * qtdLitrosCombustivel;
                    desconto = (qtdLitrosCombustivel * 6) / 100;
                    precoLitroDesc = precoLitroGasolina - desconto;
                    lbl_Qtd_Total_Litros.Text = qtdLitros.Text;
                    lbl_Preco_Total_Comb.Text = Convert.ToString(precoLitroDesc);
                    lbl_Preço_Litro_ComDesc.Text = String.Format("{0:n2}", precoLitroDesc);

                }
                if (qtdLitrosCombustivel < 20)
                {
                    precoLitroGasolina = 6.29 * qtdLitrosCombustivel;
                    lbl_Qtd_Total_Litros.Text = qtdLitros.Text;
                    lbl_Preco_Total_Comb.Text = Convert.ToString(precoLitroGasolina);
                }
            }
        }

        private void FormCombustível_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirmar a saída ?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
