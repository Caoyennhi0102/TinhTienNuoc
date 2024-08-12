namespace TinhTienNuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ciliFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm1 chilForm = new ChilForm1();
            chilForm.MdiParent = this;
            chilForm.Show();

        }
    }
}
