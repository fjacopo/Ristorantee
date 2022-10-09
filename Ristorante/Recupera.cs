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
    public partial class Recupera : Form
    {

        public string path = $@".\menu\5\";
        public string cestinopath = $@".\menu\5\";

        public string file;

        public bool Antipasto;
        public bool Primo;
        public bool Secondo;
        public bool Dessert;

        public Recupera()
        {
            InitializeComponent();
        }

        private void Recupera_Load(object sender, EventArgs e)
        {
            List<string> antipasti = new List<string>(Directory.EnumerateFiles(path, "*.txt"));
            BinLoad(antipasti);
        }

        public void BinLoad(List<string> dirs) //lista a
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4);
                cestino.Items.Add(name);
            }
        }

        public int CheckPortata() //controlli riguardo la selezione della portata
        {
            if (Antipasto == false && Primo == false && Secondo == false && Dessert == false)
            {
                MessageBox.Show("Seleziona una portata");
                return 0;
            }

            if (Antipasto == true && Primo == false && Secondo == false && Dessert == false)
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
                MessageBox.Show("seleziona una sola portata");
                return 0;
            }
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //a
        {
            if (checkBox1.Checked == false)
            {
                Antipasto = false;
            }

            if (checkBox1.Checked == true)
            {
                Antipasto = true;
            }
        }

       
        private void checkBox2_CheckedChanged(object sender, EventArgs e) //p
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

     
        private void checkBox3_CheckedChanged(object sender, EventArgs e) //s
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

        
        private void checkBox4_CheckedChanged(object sender, EventArgs e) //d
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

        private void cestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            file = cestino.SelectedItem.ToString(); 
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(file == String.Empty)
            {
                MessageBox.Show("SELEZIONA UN PIATTO");
            }
            else
            {
                int check = CheckPortata();

                path = FoldSwitch(path, check);

                path = path + file + ".txt";
                cestinopath = cestinopath + file + ".txt";

                File.Move(cestinopath, path);
                MessageBox.Show("IL PIATTO É STATO SPOSTATO");
                this.Close();
            }
        }

        public string FoldSwitch(string A, int check) //in base alla portata seleziono una cartella differente
        {
            if (check == 1)
            {
                A = @"menu\1\";
            }

            if (check == 2)
            {
                A = @"menu\2\"; ;
            }

            if (check == 3)
            {
                A = @"menu\3\";
            }

            if (check == 4)
            {
                A = @"menu\4\";
            }

            return A;
        }
    }
}
