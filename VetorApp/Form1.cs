namespace VetorApp
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmprograma1 frmprograma1 = new frmprograma1();
            frmprograma1.Show();
        }

        private void programa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmprograma2 frmprograma2 = new frmprograma2();
            frmprograma2.Show();
        }

        private void programa3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmprograma3 frmprograma3 = new frmprograma3();
            frmprograma3.Show();
        }
    }
}
