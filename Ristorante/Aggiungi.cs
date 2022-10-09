using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ristorante
{
    public partial class Aggiungi : Form
    {

        public string a = @".\menu\";

        public bool Antipasto;
        public bool Primo;
        public bool Secondo;
        public bool Dessert;

        public Aggiungi()
        {
            InitializeComponent();
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            bool controllo2 = NomePrezzo();
            if (controllo2 == false)
            {
                MessageBox.Show("ERRORE"); //deve compilare tutto 
            }

            else
            {
                int controllo = Portata();

                a = cartella(a, controllo);

                Write(a);

                MessageBox.Show("AGGIUNTO");
                this.Close();
            }
        }

        public bool NomePrezzo()
        {
            if(textBox1.Text == string.Empty)     //false é compilata, true é vuota 
            {
                return false;
            }

            if(textBox2.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        public void Exist(string a)
        {
            if(File.Exists(a))       //controlla se esiste il file
            {
                MessageBox.Show("PIATTO ESISTENTE");
            }
        }

        public void Write(string a)
        {
            a = a + textBox1.Text + ".txt";

            Exist(a);

            StreamWriter sw = new StreamWriter(a); //scrive
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox6.Text);
            sw.Close();
        }

        public string cartella(string a, int controllo) 
        {
            if (controllo == 1)
            {
                a = @"menu\1\";
            }

            if (controllo == 2)
            {
                a = @"menu\2\"; ;
            }

            if (controllo == 3)
            {
                a = @"menu\3\";
            }

            if (controllo == 4)
            {
                a = @"menu\4\";
            }

            return a;
        }

        public int Portata() 
        {
            if (Antipasto == false && Primo == false && Secondo == false && Dessert == false)
            {
                MessageBox.Show("SELEZIONA UNA PORTATA");
                return 0;
            }

            if(Antipasto == true && Primo == false && Secondo == false && Dessert ==  false)
            {
                return 1;
            }

            if (Antipasto == false && Primo == true && Secondo == false && Dessert == false)
            {
                return 2;
            }

            if (Antipasto == false && Primo == false && Secondo == true && Dessert == false)
            {
                return 3;
            }

            if (Antipasto == false && Primo == false && Secondo == false && Dessert == true)
            {
                return 4;
            }

            else
            {
                MessageBox.Show("SELEZIONA UNA PORTATA");
                return 0;
            }
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)      //non é selezionato
            {
                Antipasto = false;
            }

            if (checkBox1.Checked == true)      //é selezionato
            {
                Antipasto = true;
            }
        }

       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)  
            {
                Primo = false;
            }

            if (checkBox2.Checked == true)
            {
                Primo = true;
            }
        }

        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                Secondo = false;
            }

            if (checkBox3.Checked == true)
            {
                Secondo = true;
            }
        }

        
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                Dessert = false;
            }

            if (checkBox4.Checked == true)
            {
                Dessert = true;
            }
        }

        private void Aggiungi_Load(object sender, EventArgs e)
        {

        }
    }
}
