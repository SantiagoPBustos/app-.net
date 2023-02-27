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
    public partial class formGymApp : Form
    {

        Persona person = new Persona();

        public formGymApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {
                person.Id = tbId.Text;
                person.Name = tbName.Text;
                person.Salary = Double.Parse(tbSalary.Text);
                person.Stratum = Int16.Parse(cbStratum.Text);

                bool Masculino = rbM.Checked;
                bool Femenimo = rbF.Checked;

                if (Masculino)
                {
                    person.Gender = "Masculino";
                }
                else if (Femenimo)
                {
                    person.Gender = "Femenino";
                }
            } catch {
                MessageBox.Show("Error en el ingreso de los datos","Error");
            }
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
