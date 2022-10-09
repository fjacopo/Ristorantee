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
    public partial class Login : Form

    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @".\menu\";
            if (Directory.Exists(path))
            {                                    //se esiste
            }
            else
            {
                Directory.CreateDirectory(path);                //se non esiste crea i file 
                path = @".\menu\1\";
                Directory.CreateDirectory(path);
                path = @".\menu\2\";
                Directory.CreateDirectory(path);
                path = @".\menu\3\";
                Directory.CreateDirectory(path);
                path = @".\menu\4\";
                Directory.CreateDirectory(path);
                path = @".\menu\5\";
                Directory.CreateDirectory(path);
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(user.Text=="admin" || user.Text == "cliente")
                {


                if (user.Text == "admin" && pass.Text == "1234")
                {
                    Admin Proprietario = new Admin();
                    Proprietario.Show();
                    this.Visible = false;
                }

                if (user.Text == "cliente" && pass.Text == "1234")
                {
                    Cliente Cliente = new Cliente();
                    Cliente.Show();
                    this.Visible = false;
                }

                if(pass.Text != "1234")
                {
                    MessageBox.Show("PASSWORD ERRATA");
                }
            }
            else
            {
                MessageBox.Show("USERNAME ERRATO");
            }

          
        }
    }
}
