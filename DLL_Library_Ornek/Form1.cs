using Numerik.Islemler.HesaplamaIslemleri;

namespace DLL_Library_Ornek
{
    public partial class Form1 : Form
    {
        Matematik matematik = new Matematik();
        
        int sayi1, sayi2;
        public Form1()
        {
            InitializeComponent();
        }
        private void SayilariAl()
        {
            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            SayilariAl();
            txtSonuc.Text = matematik.Topla(sayi1, sayi2).ToString();
        }


        private void btnCikart_Click(object sender, EventArgs e)
        {
            SayilariAl();
            txtSonuc.Text = matematik.Cikart(sayi1, sayi2).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            SayilariAl();
            txtSonuc.Text = matematik.Carp(sayi1, sayi2).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            SayilariAl();
            txtSonuc.Text = matematik.Bol(sayi1, sayi2).ToString();
        }

        private void btnUsAl_Click(object sender, EventArgs e)
        {
            SayilariAl();
            txtSonuc.Text = matematik.UstelFonksiyon(sayi1, sayi2).ToString();
        }
    }
}
