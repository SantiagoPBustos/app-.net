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

                if (rbM.Checked) { person.Gender = "Masculino"; }
                else if (rbF.Checked) { person.Gender = "Femenino"; }

                ShowData data = new ShowData();
                data.lblID.Text = person.Id;
                data.lblName.Text = person.Name;
                data.lblSalary.Text = person.Salary.ToString();
                data.lblStratum.Text = person.Stratum.ToString();
                data.lblGender.Text = person.Gender.ToString();
                data.lblValue.Text = person.calculateValueGym(person.Salary, person.Stratum, person.Gender).ToString();

                data.Show();
                this.Hide();

            } catch {
                MessageBox.Show("Error en el ingreso de los datos","Error");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                person.Id = tbId.Text;
                person.Name = tbName.Text;
                person.Salary = Double.Parse(tbSalary.Text);
                person.Stratum = Int16.Parse(cbStratum.Text);

                if (rbM.Checked) { person.Gender = "Masculino"; }
                else if (rbF.Checked) { person.Gender = "Femenino"; }
                this.tbValueMonth.Text = person.calculateValueGym(person.Salary, person.Stratum, person.Gender).ToString();
            }catch {
                MessageBox.Show("Error en el ingreso de los datos", "Error");
            }
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
