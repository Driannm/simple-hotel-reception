namespace Hotel_Reception_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = pss.Text;
                if (a.Equals("hotel"))
                {
                    MessageBox.Show("Selamat, Login Succes!");
                    hotel h = new hotel();

                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf, Password Salah!");
                }
        }
    }
}