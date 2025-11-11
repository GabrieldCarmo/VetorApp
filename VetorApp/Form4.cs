using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorApp
{
    public partial class frmprograma3 : Form
    {
        public frmprograma3()
        {
            InitializeComponent();
        }

        int[] A = new int[30];
        int[] B = new int[30];
        int indice = 0;

        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            int num;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                num = Convert.ToInt16(txtnum.Text);
                if (indice < 30)
                {
                    A[indice] = num;
                    indice++;
                    txtA.Clear();
                    for (int i = 0; i < indice; i++)
                    {
                        txtA.AppendText(A[i].ToString() + "\r\n");
                    }
                    txtnum.Clear();
                    txtnum.Focus();

                    if (indice == 30)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            B[i] = A[i] * A[i] * A[i];
                        }

                        txtB.Clear();
                        for (int i = 0; i < 30; i++)
                        {
                            txtB.AppendText(B[i].ToString() + "\r\n");
                        }

                        MessageBox.Show("O vetor foi completamente preenchido!");
                        indice = 0;
                    }
                }
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16(txtpesquisa.Text);
            bool encontrado = false;

            for (int i = 0; i < 30; i++)
            {
                if (B[i] == valor)
                {
                    encontrado = true;
                    MessageBox.Show("Valor encontrado na posição: " + (i + 1));
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Valor não encontrado no vetor B.");
            }

            txtpesquisa.Clear();
            txtpesquisa.Focus();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtpesquisa.Clear();
            txtnum.Clear();
            txtB.Clear();
            txtA.Clear();
            txtnum.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
