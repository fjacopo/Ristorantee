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
    public partial class Elimina : Form
    {

        public string portata = "";

        public string a = "";

        public string cestino = $@".\menu\5\";

        public Elimina()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(namebox.Text == string.Empty)
            {
                MessageBox.Show("INSERIRE NOME DI UN PIATTO");
            }

            else
            {
                if (a != null)
                {
                    panel2.BringToFront();
                }
            }
        }

        public string CercaPiatto(string p) // il piatto esiste?
        {
            
            string a = $@".\menu\1\{p}.txt"; //a

            if (File.Exists(a))
            {
                return a;
            }

           
            a= $@".\menu\2\{p}.txt"; //p

            if (File.Exists(a))
            {
                return a;
            }

           
            a = $@".\menu\3\{p}.txt"; //s

            if (File.Exists(a))
            {
                return a;
            }

            
            a = $@".\menu\4\{p}.txt"; //d

            if (File.Exists(a))
            {
                return a;
            }

            
            MessageBox.Show("IL PIATTO NON ESISTE");

            return null;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            portata = namebox.Text;
            a = CercaPiatto(portata);

            cestino = cestino + portata + ".txt";
            File.Move(a, cestino);

            MessageBox.Show("IL PIATTO É STATO ELIMINATO");
            this.Close();
        }

        private void Elimina_Load(object sender, EventArgs e)
        {

        }
    }
}
