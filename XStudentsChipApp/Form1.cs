using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XStudentsChipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ucDownload2.Hide();
            ucReading1.Hide();
            ucUpdate1.Hide();
            ucWrite1.Hide();

        }

      
        private void lbl_Project(object sender, EventArgs e)
        {
            
        }

        private void BTN_Write_Form_Click(object sender, EventArgs e)
        {
            ucWrite1.Show();
            ucDownload2.Hide();
            ucReading1.Hide();
            ucUpdate1.Hide();
        }

        private void BTN_Change_Form_Click(object sender, EventArgs e)
        {
            ucUpdate1.Show();
            ucWrite1.Hide();
            ucDownload2.Hide();
            ucReading1.Hide();
            
        }

        private void BTN_Install_Form_Click(object sender, EventArgs e)
        {
            ucDownload2.Show();
            ucWrite1.Hide();
            ucReading1.Hide();
            ucUpdate1.Hide();
        }

        private void BTN_Read_Form_Click(object sender, EventArgs e)
        {
            ucReading1.Show();
            ucWrite1.Hide();
            ucDownload2.Hide();
            ucUpdate1.Hide();
        }

       
      
    }
}
