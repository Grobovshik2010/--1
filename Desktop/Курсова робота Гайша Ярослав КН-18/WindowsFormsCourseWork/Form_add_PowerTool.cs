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

namespace WindowsFormsCourseWork
{
    public partial class Form_Add_PowerTool : Form
    {
        public PowerTool pt;
        List<PowerToolType> lstT;
        Bitmap image;
        string file_name;
        List<string> Сountrys;
        public Form_Add_PowerTool(List<PowerToolType> lstT, int number, List<string> Сountrys)
        {
            InitializeComponent();
            this.Сountrys = Сountrys;
            this.lstT = lstT;
            for (int i = 0; i < lstT.Count; i++)
            { comboBoxType.Items.Add(lstT[i].Name); }
            comboBoxType.SelectedIndex = 0;
            textBoxNumber.Text = number.ToString();

            textBoxWidth.Text = "1";
            textBoxHeight.Text = "1";
            textBoxLength.Text = "1";

            image = new Bitmap("Photo\\no_pic_person.jpg");
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
            for (int i = 0; i < Сountrys.Count; i++)
            comboBoxCountry.Items.Add(Сountrys[i]); 
            comboBoxCountry.SelectedIndex = 0;
        }
        public Form_Add_PowerTool(List<PowerToolType> lstT, PowerTool pt, List<string> Сountrys) : this(lstT, pt.Number, Сountrys)
        {
            textBoxPrice.Text = pt.Price;
            textBoxName.Text = pt.Name;
            textBoxWeight.Text = pt.V.ToString();
            comboBoxType.SelectedIndex = pt.PowerType - 1;
            dateTimePicker1.Value = new DateTime(pt.Year, pt.Month, pt.Day);
            this.Text = pt.Price + " № " + pt.Number;
         

            textBoxWidth.Text = pt.Sides[0].ToString();
            textBoxHeight.Text = pt.Sides[1].ToString();
            textBoxLength.Text = pt.Sides[2].ToString();


            for (int i = 0; i < pt.features.Count; i++)
            {
                listBoxP.Items.Add(pt.features[i]);
            
            }
            file_name = pt.photo_file_name;
            string new_file_name = "Photo\\"+ pt.photo_file_name;
            if (File.Exists(new_file_name))
            {
                image = new Bitmap(new_file_name);
            }
            else
                image = new Bitmap("Photo\\no_pic_person.jpg");
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
            //image.Dispose();
            try
            { comboBoxCountry.SelectedIndex = Int32.Parse(pt.Country); }
            catch
            {

            }


        }
     

        private void Button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            try
            {
                number = Int32.Parse(textBoxNumber.Text);
            }
            catch { MessageBox.Show("Error"); return; }

            double price = 0;
            try
            {
                price = double.Parse(textBoxPrice.Text);
            }
            catch { MessageBox.Show("Некоректне значення ціни!"); return; }

            pt = new PowerTool(number, textBoxPrice.Text, textBoxName.Text, dateTimePicker1.Value.Date.Day, dateTimePicker1.Value.Date.Month, dateTimePicker1.Value.Date.Year, lstT[comboBoxType.SelectedIndex].Number, comboBoxCountry.SelectedIndex.ToString());
            pt.Sides[0] = Int32.Parse(textBoxWidth.Text);
            pt.Sides[1] = Int32.Parse(textBoxHeight.Text);
            pt.Sides[2] = Int32.Parse(textBoxLength.Text);
            pt.features.Clear();
            for (int i=0;i<listBoxP.Items.Count;i++)
            {
                pt.features.Add(listBoxP.Items[i].ToString());

            }
            pt.photo_file_name = file_name;
            this.Close();
        }
        
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAddSides form = new FormAddSides(textBoxWidth.Text);  
            form.ShowDialog();
            if (form.change)
                textBoxWidth.Text = form.TextBoxAddMark.Text;
            V0();
        }

        private void textBoxMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddSides form = new FormAddSides(textBoxHeight.Text); 
            form.ShowDialog();
            if (form.change)
                textBoxHeight.Text = form.TextBoxAddMark.Text;
            V0();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddSides form = new FormAddSides(textBoxLength.Text);  
            form.ShowDialog();
            if (form.change)
                textBoxLength.Text = form.TextBoxAddMark.Text;
            V0();

        }

        void V0() 
        {
            textBoxWeight.Text = (Int32.Parse(textBoxWidth.Text) * Int32.Parse(textBoxHeight.Text) * Int32.Parse(textBoxLength.Text)/1000000.0).ToString();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void Form_add_student_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                FormAddFeature form = new FormAddFeature();
                form.ShowDialog();
                if (form.textBoxNewLanguage.Text.Length != 0)

                {
                    listBoxP.Items.Add(form.textBoxNewLanguage.Text);  
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBoxP.SelectedIndex;
            if (index < 0) return;

            listBoxP.Items.RemoveAt(index);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonLoadIm_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    //image.Dispose();
                    file_name = textBoxNumber.Text + Path.GetExtension(openFileDialog1.FileName);
                    string new_file_name = "Photo\\" + file_name;
                    if (File.Exists(new_file_name)) File.Delete(new_file_name);
                    File.Copy(openFileDialog1.FileName, new_file_name);
                    //Students_Photo
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити вибраний файл","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            string new_file_name = "Photo\\" + file_name;
            //if (File.Exists(new_file_name)) File.Delete(new_file_name);
            file_name = "";
            image = new Bitmap("Photo\\no_pic_person.jpg");
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
            //image.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

