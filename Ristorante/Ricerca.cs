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
    public partial class Ricerca : Form
    {
        public string piatto = "";

        public string a = "";

        public Ricerca()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Nome(a);
        }

        public void Nome(string a) 
        {
            if (namebox.Text == string.Empty)
            {
                MessageBox.Show("INSERIRE IL NOME DEL PIATTO");
            }

            else
            {
                piatto = namebox.Text;
                a = CercaPiatto(piatto);

                if (a != null)  
                {
                    Reader(a);
                }
            }
        }

        public void Reader(string a) //lettura file
        {
            StreamReader sr = new StreamReader(a);
            pricelabel.Text = sr.ReadLine();
            firstlabel.Text = sr.ReadLine();
            secondlabel.Text = sr.ReadLine();
            thirdlabel.Text = sr.ReadLine();
            fourthlabel.Text = sr.ReadLine();
            sr.Close();
        }

        public string CercaPiatto(string piatto) //Controllo se il piatto esiste o meno
        {
            
            string a = $@".\menu\1\{piatto}.txt";   //a

            if (File.Exists(a))
            {
                return a;
            }

            
            a = $@".\menu\2\{piatto}.txt"; //p

            if (File.Exists(a))
            {
                return a;
            }

            
           a = $@".\menu\3\{piatto}.txt"; //s

            if (File.Exists(a))
            {
                return a;
            }

           
            a = $@".\menu\4\{piatto}.txt";  //d

            if (File.Exists(a))
            {
                return a;
            }

            
            MessageBox.Show("IL PIATTO NON ESISTE");

            return null;
        }

        private void Ricerca_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pricelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
