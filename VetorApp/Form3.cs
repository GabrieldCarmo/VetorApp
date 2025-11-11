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
    public partial class frmprograma2 : Form
    {
        public frmprograma2()
        {
            InitializeComponent();
        }

        int[] A = new int[10];
        int[] B = new int[10];
        int indice = 0;

        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int num;
                num = Convert.ToInt16(txtnum.Text);

                if (num > 0)
                {
                    if (indice < 10)
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

                        if (indice == 10)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                B[i] = -A[i];
                            }

                            txtB.Clear();
                            for (int i = 0; i < 10; i++)
                            {
                                txtB.AppendText(B[i].ToString() + "\r\n");
                            }

                            MessageBox.Show("O vetor foi completamente preenchido!");
                            indice = 0;
                        }
                    }
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtnum.Clear();
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
