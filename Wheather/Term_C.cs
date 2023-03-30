using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheather
{
    public partial class Term_C : Form
    {
        public Term_C()
        {
            InitializeComponent();
        }

        private void Term_C_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else if (!checkBox1.Checked)
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form obj = new Registration_Form();
            this.Hide();
            obj.radioButton1.Checked = true;
            //obj.radioButton1.CheckedChanged = true;
        }
    }
}
