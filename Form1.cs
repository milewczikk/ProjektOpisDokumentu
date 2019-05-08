using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateXML_Click(object sender, EventArgs e)
        {
            List<Ksiazka> k1 = new List<Ksiazka>();
            XmlSerializer searial = new XmlSerializer(typeof(List<Ksiazka>));
            k1.Add(new Ksiazka()
            {
                Id = 1,
                Nazwa = "Srebrny dzwoneczek",
                Autor = "Kiereś Emilia",
                Wydawnictwo = "Akapit Press",
                Seria = "",
                Gatunek = "Fikcja",
                Kod = 925000603009,
                Dostepnosc = "Dostępny jest 1 egzemplarz."

            });
            k1.Add(new Ksiazka()
            {
                Id = 2,
                Nazwa = "Pociągi : sprawdźcie sami... : ponad 60 okienek",
                Autor = "Bone Emily",
                Wydawnictwo = "OLESIEJUK",
                Seria = "Książka z Okienkami",
                Gatunek = "Fikcja",
                Kod = 925000602996,
                Dostepnosc = "Dostępnych jest 10 egzemplarzy."

            });
            k1.Add(new Ksiazka()
            {
                Id = 3,
                Nazwa = "Eragon : dziedzictwa księga pierwsza",
                Autor = "Paolini Christopher",
                Wydawnictwo = "Mag",
                Seria = "Dziedzictwo",
                Gatunek = "Fantastyka naukowa",
                Kod = 923001014459,
                Dostepnosc = "Została wypożyczona"

            });
            using (FileStream fs=new FileStream(Environment.CurrentDirectory+"\\Ksiazki.xml",FileMode.Create,FileAccess.Write))
            {
                searial.Serialize(fs, k1);
                MessageBox.Show("Zrobione");
            }
        }

        private void ReadXML_Click(object sender, EventArgs e)
        {
            List<Ksiazka> k1 = new List<Ksiazka>();
            XmlSerializer searial = new XmlSerializer(typeof(List<Ksiazka>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Ksiazki.xml", FileMode.Open, FileAccess.Read))
            {
                k1 = searial.Deserialize(fs) as List<Ksiazka>;
            }
            dataGridView1.DataSource = k1;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
