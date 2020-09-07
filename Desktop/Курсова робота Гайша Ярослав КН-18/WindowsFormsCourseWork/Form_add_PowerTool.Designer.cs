namespace WindowsFormsCourseWork
{
        partial class Form_Add_PowerTool
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_PowerTool));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMark1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelMark2 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelMark3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxP = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoadIm = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Базова ціна, грн";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(238, 89);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(180, 31);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 597);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Обєм (м^3)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(238, 585);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(180, 31);
            this.textBoxWeight.TabIndex = 7;
            this.textBoxWeight.TabStop = false;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxMark_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(238, 326);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(180, 33);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFaculty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(362, 660);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 35);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(238, 148);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(180, 31);
            this.textBoxNumber.TabIndex = 11;
            this.textBoxNumber.TabStop = false;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 206);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата виготовлення";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(429, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelMark1
            // 
            this.labelMark1.AutoSize = true;
            this.labelMark1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark1.Location = new System.Drawing.Point(32, 408);
            this.labelMark1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMark1.Name = "labelMark1";
            this.labelMark1.Size = new System.Drawing.Size(121, 25);
            this.labelMark1.TabIndex = 16;
            this.labelMark1.Text = "Ширина (см)";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(238, 395);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.ReadOnly = true;
            this.textBoxWidth.Size = new System.Drawing.Size(180, 31);
            this.textBoxWidth.TabIndex = 17;
            this.textBoxWidth.TabStop = false;
            this.textBoxWidth.Text = "1";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(238, 454);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.ReadOnly = true;
            this.textBoxHeight.Size = new System.Drawing.Size(180, 31);
            this.textBoxHeight.TabIndex = 19;
            this.textBoxHeight.TabStop = false;
            this.textBoxHeight.Text = "1";
            // 
            // labelMark2
            // 
            this.labelMark2.AutoSize = true;
            this.labelMark2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark2.Location = new System.Drawing.Point(28, 463);
            this.labelMark2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMark2.Name = "labelMark2";
            this.labelMark2.Size = new System.Drawing.Size(108, 25);
            this.labelMark2.TabIndex = 18;
            this.labelMark2.Text = "Висота (см)";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLength.Location = new System.Drawing.Point(238, 520);
            this.textBoxLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.ReadOnly = true;
            this.textBoxLength.Size = new System.Drawing.Size(180, 31);
            this.textBoxLength.TabIndex = 21;
            this.textBoxLength.TabStop = false;
            this.textBoxLength.Text = "1";
            // 
            // labelMark3
            // 
            this.labelMark3.AutoSize = true;
            this.labelMark3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark3.Location = new System.Drawing.Point(28, 529);
            this.labelMark3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMark3.Name = "labelMark3";
            this.labelMark3.Size = new System.Drawing.Size(129, 25);
            this.labelMark3.TabIndex = 20;
            this.labelMark3.Text = "Довжина (см)";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(429, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(429, 517);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Повна назва";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(238, 22);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(695, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(821, 597);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "Видалити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(530, 597);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Добавити...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxP
            // 
            this.listBoxP.BackColor = System.Drawing.Color.PaleGreen;
            this.listBoxP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxP.FormattingEnabled = true;
            this.listBoxP.ItemHeight = 25;
            this.listBoxP.Location = new System.Drawing.Point(530, 483);
            this.listBoxP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxP.Name = "listBoxP";
            this.listBoxP.Size = new System.Drawing.Size(403, 104);
            this.listBoxP.TabIndex = 30;
            this.listBoxP.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(525, 451);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ключові особливості";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Виробник";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(530, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLoadIm
            // 
            this.buttonLoadIm.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadIm.Location = new System.Drawing.Point(530, 375);
            this.buttonLoadIm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadIm.Name = "buttonLoadIm";
            this.buttonLoadIm.Size = new System.Drawing.Size(149, 35);
            this.buttonLoadIm.TabIndex = 8;
            this.buttonLoadIm.Text = "Завантажити...";
            this.buttonLoadIm.UseVisualStyleBackColor = true;
            this.buttonLoadIm.Click += new System.EventHandler(this.buttonLoadIm_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteImage.Location = new System.Drawing.Point(821, 375);
            this.buttonDeleteImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(112, 35);
            this.buttonDeleteImage.TabIndex = 9;
            this.buttonDeleteImage.Text = "Видалити";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (.)|*.*";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(238, 266);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(180, 28);
            this.comboBoxCountry.TabIndex = 37;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form_Add_PowerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(981, 713);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.buttonLoadIm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBoxP);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelMark3);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelMark2);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelMark1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Add_PowerTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Інформація про електроінструмент";
            this.Load += new System.EventHandler(this.Form_add_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox textBoxPrice;
            private System.Windows.Forms.Label label4;
            public System.Windows.Forms.TextBox textBoxWeight;
            private System.Windows.Forms.ComboBox comboBoxType;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Button buttonSave;
            private System.Windows.Forms.TextBox textBoxNumber;
            private System.Windows.Forms.DateTimePicker dateTimePicker1;
            private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMark1;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelMark2;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelMark3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBoxP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoadIm;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
    
}