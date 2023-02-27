using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class LogIn : Form
    {
        formGymApp gymApp;

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e) {}
        private void LabelName_Click(object sender, EventArgs e){}
        private void LabelDescription_Click(object sender, EventArgs e){}
        private void tbPassword_TextChanged(object sender, EventArgs e){}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = "123";
            if (tbPassword.Text.Equals(password))
            {
                gymApp = new formGymApp();
                gymApp.Show();
                this.Hide();
            }
            else {
                tbPassword.Clear(); 
                MessageBox.Show("Contraseña Incorrecta!", "Error!");
            }
        }

    }
}
