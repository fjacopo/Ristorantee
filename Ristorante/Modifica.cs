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
    public partial class Modifica : Form
    {
        public string piatto = "";

        public string a = "";

        public Modifica()
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
                MessageBox.Show("INSERIRE NOME PIATTO");
            }

            else
            {
                piatto = namebox.Text;
                a = CercaPiatto(piatto);

                if(a != null) 
                {
                    Reader(a);
                }
            }
        }

        public void Writer(string a) 
        {
            StreamWriter sw = new StreamWriter(a);
            sw.WriteLine(pricebox.Text);
            sw.WriteLine(firstbox.Text);
            sw.WriteLine(secondbox.Text);
            sw.WriteLine(thirdbox.Text);
            sw.WriteLine(fourthbox.Text);
            sw.Close();
        }

        public void Reader(string a) 
        {
            StreamReader sr = new StreamReader(a);
            pricebox.Text = sr.ReadLine();
            firstbox.Text = sr.ReadLine();
            secondbox.Text = sr.ReadLine();
            thirdbox.Text = sr.ReadLine();
            fourthbox.Text = sr.ReadLine();
            sr.Close();
        }

        public string CercaPiatto(string piatto) //il piatto esiste?
        {
           
            string a = $@".\menu\1\{piatto}.txt"; //a

            if(File.Exists(a))
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

            
            a = $@".\menu\4\{piatto}.txt"; //d

            if (File.Exists(a))
            {
                return a;
            }

            
            MessageBox.Show("IL PIATTO NON ESISTE");

               return null;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            a = CercaPiatto(piatto);

            Writer(a);            

            MessageBox.Show("MODIFICA EFFETTUATA");
            this.Close();
        }
    }
}
