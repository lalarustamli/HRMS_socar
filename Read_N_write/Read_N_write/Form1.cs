using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_N_write
{

    public partial class Main_form : Form
    {
        
        public Main_form()
        {
            InitializeComponent();
            main_page1.BringToFront();

            side_panel.Height = main_page_button.Height;
            

        }
        //Yeni işçi yaratmaq üçün keçid
        public void create_Click(object sender, EventArgs e)
        {
            new_employee1.hide();
            new_employee1.BringToFront();
            side_panel.Height = create.Height;
            side_panel.Top = create.Top;
            
        }
        //Mövcud işçi siyahısına text file-dan baxmaq üçün keçid        
        private void read_Click(object sender, EventArgs e)
        {
            side_panel.Height = read.Height;
            side_panel.Top = read.Top;
            
            
            employee_list1.BringToFront();
            employee_list1.gridview_data();
            
        }
        //Yeni sənəd yaratmaq üçün keçid
        private void create_doc_Click(object sender, EventArgs e)
        {
            
            side_panel.Height = create_doc.Height;
            side_panel.Top = create_doc.Top;
            new_document1.BringToFront();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            edit_employees1.BringToFront();
            side_panel.Height = edit.Height;
            side_panel.Top = edit.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_page_button_Click(object sender, EventArgs e)
        {
            main_page1.BringToFront();
            side_panel.Height = main_page_button.Height;
            side_panel.Top = main_page_button.Top;
        }
    }
}
