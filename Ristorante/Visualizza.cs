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
    public partial class Visualizza : Form
    {
        //PERCORSI FILE
        public string antipastii= $@".\menu\1\";
        public string primii = $@".\menu\2\";
        public string secondii = $@".\menu\3\";
        public string dessertt = $@".\menu\4\";

        public string prezzo;
        public string primo;
        public string secondo;
        public string terzo;
        public string quarto;

        public Visualizza()
        {
            InitializeComponent();
        }

        //CARICAMENTO LISTE
        private void Visualizza_Load(object sender, EventArgs e)
        {
            List<string> antipasti = new List<string>(Directory.EnumerateFiles(antipastii, "*.txt"));
            AntipastiLoad(antipasti);

            List<string> primi = new List<string>(Directory.EnumerateFiles(primii, "*.txt"));
            PrimiLoad(primi);

            List<string> secondi= new List<string>(Directory.EnumerateFiles(secondii, "*.txt"));
            SecondiLoad(secondi);

            List<string> dessert = new List<string>(Directory.EnumerateFiles(dessertt, "*.txt"));
            DessertLoad(dessert);
            
        }


       //riempimento liste a 
        public void AntipastiLoad(List<string> dirs) 
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}"; //leggo il nome del file
                int count = name.Count();
                name = name.Remove(count - 4); //tolgo .txt 
                antipasti.Items.Add(name);
            }
        }

        public void PrimiLoad(List<string> dirs) //primi
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                primi.Items.Add(name);
            }
        }

        public void SecondiLoad(List<string> dirs) //secondi
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                secondi.Items.Add(name);
            }
        }

        public void DessertLoad(List<string> dirs) //dessert
        {

            foreach (string dir in dirs)
            {
                string name = $"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}";
                int count = name.Count();
                name = name.Remove(count - 4);
                dessert.Items.Add(name);
            }
        }

        

        //a
        private void antipasti_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string name = antipasti.SelectedItem.ToString(); //salvo il nome del piatto cliccato

            antipastii = antipastii + name + ".txt";

            ReaderWriter(antipastii, name, prezzo, primo, secondo, terzo, quarto);

            antipastii = $@".\menu\1\";
        }

        //p
        private void primi_SelectedIndexChanged(object sender, EventArgs e)  
        {
            string name = primi.SelectedItem.ToString(); 

            primii = primii + name + ".txt";

            ReaderWriter(primii, name, prezzo, primo, secondo, terzo, quarto);

            primii = $@".\menu\2\";
        }

        //s
        private void secondi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = secondi.SelectedItem.ToString(); 

            secondii= secondii + name + ".txt";

            ReaderWriter(secondii, name, prezzo, primo, secondo, terzo, quarto);

            secondii = $@".\menu\3\";
        }

        //d
        private void dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = dessert.SelectedItem.ToString(); 

            dessertt = dessertt + name + ".txt";

            ReaderWriter(dessertt, name, prezzo, primo, secondo, terzo, quarto);

            dessertt = $@".\menu\4\";
        }

        //leggo e scrivo per la message box
        public void ReaderWriter(string a, string nome, string prezzo, string primo, string secondo, string terzo, string quarto) 
        {
            StreamReader sr = new StreamReader(a);
            prezzo  = sr.ReadLine();
            primo = sr.ReadLine();
            secondo = sr.ReadLine();
            terzo = sr.ReadLine();
            quarto = sr.ReadLine();
            sr.Close();

            Writer(nome, prezzo, primo, secondo, terzo, quarto);
        }

        public void Writer(string nome,  string prezzo, string primo, string secondo, string terzo, string quarto)
        {
            MessageBox.Show($"Nome : {nome} \n" + //\n vado a capo nel messaggio
                $"Prezzo: {prezzo} \n" +
                $"1 Ingrediente : {primo} \n" +
                $"2 Ingrediente : {secondo} \n" +
                $"3 Ingrediente : {terzo} \n" +
                $"4 Ingrediente : {quarto}");
        }

        private void Visualizza_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
