using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCourseWork
{
    public partial class FormAddSides : Form
    {
        
         public bool change = false;

        public FormAddSides(string mark)
        {
            
            InitializeComponent();
            TextBoxAddMark.Text = mark;
            if (TextBoxAddMark.Text.Length == 0||TextBoxAddMark.Text == "0")
                TextBoxAddMark.Text = "1";
            trackBar1.Value = Int32.Parse(TextBoxAddMark.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                change = true;
                this.Close();
        }

        private void FormAddMark_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TextBoxAddMark.Text = trackBar1.Value.ToString();
        }
    }
}
