namespace trabajo_cami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new formulario_31_mayo();
            form.Show();
            this.Hide();
        }
    }
}