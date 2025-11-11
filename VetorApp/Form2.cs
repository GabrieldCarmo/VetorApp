using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VetorApp
{
    public partial class frmprograma1 : Form
    {
        public frmprograma1()
        {
            InitializeComponent();
        }

        int[] A = new int[15];
        int[] B = new int[15];
        int indice = 0;

        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            int num, numB;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                num = Convert.ToInt16(txtnum.Text);
                if (indice < 15)
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

                    if (indice == 15)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            B[i] = A[i] * A[i];
                        }

                        txtB.Clear();
                        for (int i = 0; i < 15; i++)
                        {
                            txtB.AppendText(B[i].ToString() + "\r\n");
                        }
                        MessageBox.Show("Os vetores A foram completamente preenchidos!");

                        indice = 0;
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
