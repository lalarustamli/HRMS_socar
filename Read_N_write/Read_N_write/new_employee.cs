using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_N_write
{
    public partial class new_employee : UserControl
    {   
        public void hide()
        {
            save_label.Hide();
            error_label.Hide();
        }
        public new_employee()
        {
            InitializeComponent();
            
        }

        private void new_employee_Load(object sender, EventArgs e)
        {
            hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_box.Text)||string.IsNullOrWhiteSpace(surname_box.Text) || string.IsNullOrWhiteSpace(address_box.Text))
            {
                save_label.Hide();
                error_label.Show();
                
            }
            else
            {
                error_label.Hide();
                Employee employee = new Employee(name_box.Text, surname_box.Text, address_box.Text);
                TextWriter txt = new StreamWriter("C:\\Text\\text.txt", true);
                txt.WriteLine(employee.Name + " " + employee.Surname + " " + employee.About);
                txt.Close();
                save_label.Show();
                name_box.Clear();
                surname_box.Clear();
                address_box.Clear();
            }

        }
    }
}
