using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsCourseWork
{
    public partial class Form1 : Form
    {
        List<PowerTool> lstPT;
        List<PowerToolType> lstT;
        List<string> Сountrys;
        string FileName = "";
        
        public Form1()
        {
            InitializeComponent();
            textBoxMinPrice.Text = "0";
            textBoxMaxPrice.Text = "10000";
            lstPT = new List<PowerTool>();

            Сountrys = new List<string>();
            Сountrys.Add("Австралия");
            Сountrys.Add("Египет");
            Сountrys.Add("Китай");
            Сountrys.Add("Росія");
            Сountrys.Add("Україна");
            Сountrys.Add("Грузія");
            Сountrys.Add("Італія");
            Сountrys.Add("Німечина");
            Сountrys.Add("Франція");
            Сountrys.Add("Японія");

            lstT = new List<PowerToolType>();
            lstT.Add(new PowerToolType(1, "Шуруповерти"));
            lstT.Add(new PowerToolType(2, "Дрилі"));
            lstT.Add(new PowerToolType(3, "Перфоратори"));
            lstT.Add(new PowerToolType(4, "Болгарки"));
            lstT.Add(new PowerToolType(5, "Пилки"));
            lstT.Add(new PowerToolType(6, "Шліфмашинки"));

            comboBoxFaculty.Items.Add("Всі типи");
            for (int i = 0; i < lstT.Count; i++)
                comboBoxFaculty.Items.Add(lstT[i].Name);
            comboBoxFaculty.SelectedIndex = 0;     
        }

        public void SetData(Data data)
        {
            lstPT.Clear();
            for (int i = 0; i < data.lstPT.Count; i++)
            {
                if (data.lstPT[i].PowerType == 1) lstPT.Add(new Screwdrivers(data.lstPT[i]));
                else if (data.lstPT[i].PowerType == 2) lstPT.Add(new Drills(data.lstPT[i]));
                else if (data.lstPT[i].PowerType == 3) lstPT.Add(new Perforators(data.lstPT[i]));
                else if (data.lstPT[i].PowerType == 4) lstPT.Add(new Bulgarians(data.lstPT[i]));
                else if (data.lstPT[i].PowerType == 5) lstPT.Add(new Saw(data.lstPT[i]));
                else if (data.lstPT[i].PowerType == 6) lstPT.Add(new Screwdrivers(data.lstPT[i]));
                else lstPT.Add(new PowerTool(data.lstPT[i]));
            }  
            LoadToDataGridView();
        }
 
        int Get_number_by_id(int id)
        {
            for (int i = 0; i < lstPT.Count; i++)
                if (lstPT[i].Number == id) return i;
            return -1;
        }

 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            FileName= openFileDialog1.FileName;
            Data data = DataXmlSerilization.read_from_xml(FileName);
            SetData(data);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вийти?", "Вихід", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (FileName == "") return;
            lstPT = (lstPT.OrderBy(s => s.ActionPrice)).ToList();
            LoadToDataGridView();
        }
        private void LoadToDataGridView()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < lstPT.Count; i++)
            {
                if (is_filter(lstPT[i]))
                    dataGridView2.Rows.Add(lstT[lstPT[i].PowerType - 1].Name, lstPT[i].ActionPrice, lstPT[i].Name, lstPT[i].Years, lstPT[i].DeliveryPrice(), Сountrys[Int32.Parse(lstPT[i].Country)], lstPT[i].Number);

            }
            if (comboBoxFaculty.SelectedIndex != 0)
                toolStripStatusLabel2.Text = "Застосований фільтр! Відображаються не всі дані!";
            else toolStripStatusLabel2.Text = "";
        }
        private bool is_filter(PowerTool s)
        {
         
            int i = comboBoxFaculty.SelectedIndex;
            double minPrice = double.Parse(textBoxMinPrice.Text);
            double maxPrice = double.Parse(textBoxMaxPrice.Text);
            if (((comboBoxFaculty.SelectedIndex == 0) ||(s.PowerType == i)) &&(minPrice<= s.ActionPrice) &&(s.ActionPrice<=maxPrice)) return true;
            return false;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void Save()
        {
            Data data = new Data();
            data.lstPT = new List<PowerTool>();
            for (int i = 0; i < lstPT.Count; i++)
            {
                data.lstPT.Add(new PowerTool(lstPT[i]));
            }

            data.lstT = lstT;

            DataXmlSerilization.save_to_xml(data,FileName);
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (FileName == "") return;
            double minPrice;
            double maxPrice;
            try
            {
                 minPrice = double.Parse(textBoxMinPrice.Text);
                 maxPrice = double.Parse(textBoxMaxPrice.Text);
            }
            catch
            {
                MessageBox.Show("В фільтрі задане некоректне значення ціни!");
                return;
            }
            if(maxPrice>=minPrice) LoadToDataGridView();
            else MessageBox.Show("В фільтрі задане некоректне значення ціни!(ціна до:)повинна бути більша за (ціну від:)");
        }


        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {

            toolStripButtonEdit.PerformClick();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutAuthor form = new FormAboutAuthor();
            form.ShowDialog();
        }

     

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Form_Add_PowerTool form = new Form_Add_PowerTool(lstT, lstPT.Count + 1, Сountrys);
            form.ShowDialog();
            if (form.pt != null)
            {
                if (form.pt.PowerType == 1) lstPT.Add(new Screwdrivers(form.pt));
                else if (form.pt.PowerType == 2) lstPT.Add(new Drills(form.pt));
                else if (form.pt.PowerType == 3) lstPT.Add(new Perforators(form.pt));
                else if (form.pt.PowerType == 4) lstPT.Add(new Bulgarians(form.pt));
                else if (form.pt.PowerType == 5) lstPT.Add(new Saw(form.pt));
                else if (form.pt.PowerType == 6) lstPT.Add(new Screwdrivers(form.pt));
                else lstPT.Add(new PowerTool(form.pt));

               
                int i = lstPT.Count - 1;
                dataGridView2.Rows.Add(lstT[lstPT[i].PowerType - 1].Name, lstPT[i].ActionPrice, lstPT[i].Name, lstPT[i].Years, lstPT[i].DeliveryPrice(), Сountrys[Int32.Parse(lstPT[i].Country)], lstPT[i].Number);

            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int j = dataGridView2.CurrentRow.Index;
                if (j >= lstPT.Count) return;
                int id = Int32.Parse(dataGridView2[6, j].Value.ToString());

                int i = Get_number_by_id(id);
                Form_Add_PowerTool form = new Form_Add_PowerTool(lstT, lstPT[i], Сountrys);
                form.ShowDialog();
                if (form.pt != null)
                {
                    dataGridView2.Rows.RemoveAt(j);

                    PowerTool p = new PowerTool(form.pt);

                    if (form.pt.PowerType == 1) p=new Screwdrivers(form.pt);
                    else if (form.pt.PowerType == 2) p = new Drills(form.pt);
                    else if (form.pt.PowerType == 3) p = new Perforators(form.pt);
                    else if (form.pt.PowerType == 4) p = new Bulgarians(form.pt);
                    else if (form.pt.PowerType == 5) p = new Saw(form.pt);
                    else if (form.pt.PowerType == 6) p = new Screwdrivers(form.pt);
                    else lstPT.Add(new PowerTool(form.pt));
                    lstPT[i] =p;


                    dataGridView2.Rows.Insert(j, lstT[lstPT[i].PowerType - 1].Name, lstPT[i].ActionPrice, lstPT[i].Name, lstPT[i].Years, lstPT[i].DeliveryPrice(), Сountrys[Int32.Parse(lstPT[i].Country)], lstPT[i].Number);

                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int j = dataGridView2.CurrentRow.Index;
                if (j >= lstPT.Count) return;
                int id = Int32.Parse(dataGridView2[6, j].Value.ToString());

                int i = Get_number_by_id(id);
                lstPT.RemoveAt(i);
                LoadToDataGridView();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileName == "") return;
            lstPT = (lstPT.OrderBy(s => s.Years)).ToList();
            LoadToDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FileName == "") return;
            lstPT = (lstPT.OrderBy(s => s.Name)).ToList();
            LoadToDataGridView();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            FileName = filename;
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName != "") Save();
            else MessageBox.Show("Щоб зберегти дані необхідно вибрати команду Зберегти як...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

