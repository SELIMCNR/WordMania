using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace İngilizceKelimeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=EnglishApp;Integrated Security=True;Pooling=False;"); //veritabanı bağlantı

        Random rast = new Random(); //random nesnesi
        int süre = 90; //süre
        int doğru = 0; //kelime
        int yanlış = 0;
        int boş;
        int puan;
        string inglizce, cevap; //değişken

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start(); //sayaç başladı
        }

        void getir()
        {
            int sayi = rast.Next(1, 50); //random sayı oluştur

            bgl.Open(); // bağlantı aç
            SqlCommand sqlCommand = new SqlCommand("Select * from TableEnglishApp where Id=@id", bgl); //sql komutunu al
            sqlCommand.Parameters.AddWithValue("@id", sayi); //değeri komuta ekle
            SqlDataReader dr = sqlCommand.ExecuteReader(); //veriyi oku
            while (dr.Read())
            {
                inglizce = dr[1].ToString();
                cevap = dr[2].ToString().Trim().ToLower(); // Veritabanından alınan cevabı düzenle
                lblCevab.Text = cevap; // Cevabı doğru formatta yazdır
            }
            Txtİngilizce.Text = inglizce;
            bgl.Close(); //bağlantıyı kapat
        }

        private void TxtTürkce_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible=false;
            label1.Visible=true;
            label2.Visible=true;
            label3.Visible=true;
            label4.Visible=true;
            label7.Visible=true;
            label5.Visible= true;
            lblCevab.Visible= false;
            LblSüre.Visible= true;
            Lbldoğru.Visible= true;
            lblYanlış.Visible= true;
            lblboş.Visible= true;
            lblPuan.Visible= true;
            TxtTürkce.Visible= true;
            Txtİngilizce.Visible= true;
            button2 .Visible=true;
            button3.Visible=true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Textbox içeriğini düzenle ve karşılaştır
            if (TxtTürkce.Text.Trim().ToLower() == cevap)
            {
                doğru++;
                puan = puan + 20;
                lblPuan.Text="Puan : "+puan.ToString();
                getir();
                TxtTürkce.Clear();
            }
            else
            {
                yanlış++;
                puan = puan - 5;
                lblPuan.Text = "Puan : " + puan.ToString();
                getir();
                TxtTürkce.Clear();
            }

            Lbldoğru.Text = doğru.ToString();
            lblYanlış.Text=yanlış.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boş++;
            lblboş.ToString();

            puan = puan - 5;
            lblPuan.Text = "Puan : " + puan.ToString();
            getir() ;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--; // süreyi azalt
            LblSüre.Text = süre.ToString(); //labela yazdır
            if (süre == 0)
            {
                TxtTürkce.Enabled = false; // buttonları işlevsiz kıl
                Txtİngilizce.Enabled = false;
                timer1.Stop(); // zamanlayıcı durdur
                MessageBox.Show($"Oyun bitti doğru sayısı{doğru.ToString()} yanlış sayısı {yanlış.ToString()} boş sayısı{boş.ToString()} puan : {puan.ToString()}","Oyun bitti ",MessageBoxButtons.OK,MessageBoxIcon.Question);
               Application.Exit();
                
            }
        }
    }
}
