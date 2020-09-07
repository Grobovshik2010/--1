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
    public partial class FormAddFeature : Form
    {
        public FormAddFeature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNewLanguage.Text.Length != 0)
            this.Close();
        }
    }
}
