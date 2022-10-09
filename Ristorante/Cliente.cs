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
    public partial class Cliente : Form
    {
        public string antipastii = $@".\menu\1\";               //ad ogni file assegno una portata ( antipasti, prezzo...)
        public string primii = $@".\menu\2\";
        public string secondii = $@".\menu\3\";
        public string dessertt = $@".\menu\4\";

        public string path;
        public int price = 0;

        public string nomeordine;

        public string[] arr = new string[3];

        public string ingr;

        public int a = 1;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

            List<string> antipasti = new List<string>(Directory.EnumerateFiles(antipastii, "*.txt")); //crea una nuova stringa che possa contenere tutti gli elementi
            AntipastiLoad(antipasti);

            List<string> primi = new List<string>(Directory.EnumerateFiles(primii, "*.txt"));
            PrimiLoad(primi);

            List<string> secondi = new List<string>(Directory.EnumerateFiles(secondii, "*.txt"));
            SecondiLoad(secondi);

            List<string> dessert= new List<string>(Directory.EnumerateFiles(dessertt, "*.txt"));
            DessertLoad(dessert);

        }

        public void AntipastiLoad(List<string> a) //lista a
        {

            foreach (string b in a)
            {
                string nome = $"{b.Substring(b.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";    //leggo il nome
                int count = nome.Count();        
                nome = nome.Remove(count - 4);  //tolgo .txt 

                arr[0] = nome;

                antipastii = antipastii + nome + ".txt";
                Reader(antipastii, arr, ingr);

                ListViewItem c;  //controlla la lista

                c= new ListViewItem(arr);

                menu.Items.Add(c);

                antipastii = $@".\menu\1\";
            }
        }

        public void PrimiLoad(List<string> a) //list p
        {

            foreach (string b in a)
            {
                string nome = $"{b.Substring(b.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; 
                int count = nome.Count();
                nome = nome.Remove(count - 4); 

                arr[0] = nome;

                primii = primii + nome + ".txt";
                Reader(primii, arr, ingr);

                ListViewItem c;

                c = new ListViewItem(arr);
                menu.Items.Add(c);

                primii = $@".\menu\2\";
            }
        }

        public void SecondiLoad(List<string> a) //lista s
        {

            foreach (string b in a)
            {
                string nome = $"{b.Substring(b.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = nome.Count();
                nome = nome.Remove(count - 4); 

                arr[0] = nome;

                secondii = secondii + nome + ".txt";
                Reader(secondii, arr, ingr);

                ListViewItem c;

                c = new ListViewItem(arr);
                menu.Items.Add(c);

                secondii = $@".\menu\3\";
            }
        }

        public void DessertLoad(List<string> a) // lista d
        {

            foreach (string b in a)
            {
                string nome = $"{b.Substring(b.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; 
                int count = nome.Count();
                nome = nome.Remove(count - 4); 

                arr[0] = nome;

                dessertt = dessertt + nome + ".txt";
                Reader(dessertt, arr, ingr);

                ListViewItem c;

                c = new ListViewItem(arr);
                menu.Items.Add(c);

                dessertt = $@".\menu\4\";
            }
        }

        public void Reader(string a, string[] arr, string ingr)
        {
            StreamReader sr = new StreamReader(a);
            arr[2] = sr.ReadLine();

            ingr = sr.ReadLine() + "; " + sr.ReadLine() + "; " + sr.ReadLine() + "; " + sr.ReadLine();
            arr[1] = ingr;
        }

        private void menu_DoubleClick(object sender, EventArgs e)
        {
            string nome = menu.SelectedItems[0].Text;    //salva il nome del piatto
            ordini.Items.Add(nome);

            path = CercaPiatto(nome);

            price = price + PriceReader(path);

            totprice.Text = price.ToString();
        }

        public int PriceReader(string a)
        {
            StreamReader prezzo = new StreamReader(a);    
            int b = int.Parse(prezzo.ReadLine());           //legge il prezzo e lo assegna alla variabile intera b
            return b;
        }

        
        public string CercaPiatto(string piatto) //il piatto esiste
        {
            
            string path = $@".\menu\1\{piatto}.txt"; // a
                                                                             
            if (File.Exists(path))
            {                                         
                return path;
            }

           
            path = $@".\menu\2\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

         
            path = $@".\menu\3\{piatto}.txt";

            if (File.Exists(path))
            {
                return path;
            }

           
            path = $@".\menu\4\{piatto}.txt";

            if(File.Exists(path))
            {
                return path;
            }

           
            MessageBox.Show("IL PIATTO NON ESISTE");

            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nomeordine = ordini.SelectedItem.ToString(); 

            path = CercaPiatto(nomeordine);

            int temp = int.Parse(totprice.Text);     //legge un numero in stringa e lo converte a intero 
            temp = temp - PriceReader(path);

            totprice.Text = temp.ToString();

            ordini.Items.RemoveAt(ordini.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totprice.Text == "0")
            {
                MessageBox.Show("DEVI ORDINARE ALMENO 1 COSA");
            }

            else
            {
                MessageBox.Show("ORDINE CORRETTO");
                this.Close();
            }
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
