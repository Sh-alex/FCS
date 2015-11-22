using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericRows.Value = 14;
            numericCols.Value = 7;
            button1_Click(sender, e);
            string line = "";

            System.IO.StreamReader file =
                new System.IO.StreamReader("myVar.txt", Encoding.Default);
            int index = 0;
            while ((line = file.ReadLine()) != null)
            {
                List<string> list = new List<string>();

                for (int i = 0; i < line.Length - 1; i++)
                {
                    list.Add(line.Substring(i, 2));
                    i++;
                }

                for (int i = 0; i < list.Count; i++)
                {
                    valueEl[index][i].Text = list[i];
                }
                index++;
            }

            file.Close();
        }
        private void clearEl()
        {
            Controls.Clear();

            button1.Location = new System.Drawing.Point(223, 30);
            button1.Size = new System.Drawing.Size(85, 23);
            button1.Text = "Підтвердити";
            this.Controls.Add(button1);

            lNumberRows.Location = new System.Drawing.Point(13, 13);
            lNumberRows.Size = new System.Drawing.Size(137, 13);
            lNumberRows.Text = "Виберіть кількість рядків:";
            this.Controls.Add(lNumberRows);

            lNumberCols.Location = new System.Drawing.Point(16, 40);
            lNumberCols.Size = new System.Drawing.Size(148, 13);
            lNumberCols.Text = "Виберіть кількість стовпців:";
            this.Controls.Add(lNumberCols);

            numericRows.Location = new System.Drawing.Point(168, 13);
            numericRows.Size = new System.Drawing.Size(35, 20);
            this.Controls.Add(numericRows);

            numericCols.Location = new System.Drawing.Point(167, 38);
            numericCols.Size = new System.Drawing.Size(35, 20);
            this.Controls.Add(numericCols);

            numberCol.Location = new System.Drawing.Point(13, 68);
            numberCol.Size = new System.Drawing.Size(110, 13);
            this.Controls.Add(numberCol);

            lResult.Location = new System.Drawing.Point(503, 13);
            lResult.Size = new System.Drawing.Size(365, 406);
            this.Controls.Add(lResult);

            lResult.Text = "";

        } //Очищає форму перед наступним обрахунком

        NumericUpDown[] numUpDnArray; //Масив, який містить довжину рядків вхідної матриці
        TextBox[][] valueEl; //Масив, який містить значення вхідної матриці
        private void button1_Click(object sender, EventArgs e)//Розміщення NumericUpDown на формі(для кількості елементів в рядку) та TextBox
        {
            clearEl();
            valueEl = null;
            numberCol.Visible = true; 


            numUpDnArray = new NumericUpDown[(int)numericRows.Value];//Кількість рядків
            //////////////////////////////////////////////////////////
            for (int i = 0; i < (int)numericRows.Value; i++) 
            {
                NumericUpDown numUpDn = new NumericUpDown();
                numUpDn.Location = new System.Drawing.Point(20, 90 + i * 22);
                numUpDn.Size = new System.Drawing.Size(40, 20);
                numUpDn.Minimum = 1;
                numUpDn.Maximum = 14;
                
                this.Controls.Add(numUpDn);
                numUpDnArray[i] = numUpDn;
            }
            ////////////////////////////////////
            button2.Location = new System.Drawing.Point(20, 100 + (int)numericRows.Value * 22); 
            button2.Size = new System.Drawing.Size(85, 23);
            button2.Text = "Підтвердити";
            this.Controls.Add(button2);
            //button2.Show();
            ////////////////////////////////////////
            foreach (NumericUpDown i in numUpDnArray)
            {
                i.Value = numericCols.Value;
            }
           
            ////////////////////////////////
            for (int i = 0; i < numUpDnArray.Length; i++)// Задаю подію на зміну значення
                numUpDnArray[i].ValueChanged += new EventHandler(ctr_ValueChanged);
            
            ////////////////////////////////////////////////////////
            ctr_ValueChanged(sender, e);

            button2.Text = "Порахувати";

        }

        private void button2_Click(object sender, EventArgs e)//Обрахунок
        {

            Calculation calc = new Calculation();
            
            calc.countUniqueEl(valueEl); //Обчислюю кількість унікальних елементів
            lResult.Text = "Результат: ";
            lResult.Text += "\nКількість унікальних елементів: " + calc.CountUEl;
            lResult.Text += "\nМатриця: \n";

            calc.calcResultMatrix(valueEl, (int)numericRows.Value, numUpDnArray);// Обчислюю матрицю подібності
            calc.outResultMatrix(lResult);//Виведення результатів

            if (calc.resultMatrix[0].Count != 1) //Достатьньо елементів для утворення груп?
            {
                calc.createGroups();//Розбиваю на групи

                Form2 Form2 = new Form2(calc);
                Form2.Show();

                GraphVisual GraphVisual = new GraphVisual(calc);
                GraphVisual.Show();
            }

           
        }

        void ctr_ValueChanged(object sender, EventArgs e)//Подія при зміні довжини рядка
        {
            /////////////////////////////
            string[][] temp = new string[(int)numericRows.Value][];//Проміжний масив для зберігання елементів
            bool first = true;
            if (valueEl != null)
            {
                int a = -1, b = 0;
                first=false;
                foreach (TextBox[] i in valueEl)//Заповнюю temp і видаляю елементи TextBox
                {
                    a++;
                    temp[a] = new string[(int)numUpDnArray[a].Value];
                    b = 0;
                    foreach (TextBox j in i)
                    {
                        try
                        {
                            temp[a][b] = j.Text;
                        }
                        catch(IndexOutOfRangeException)
                        { }
                        b++;
                        j.Dispose();
                    }
                }
            }
            ///////////////////////////////
            valueEl = new TextBox[(int)numericRows.Value][];

            for (int i = 0; i < (int)numericRows.Value; i++)
            {
                valueEl[i] = new TextBox[(int)numUpDnArray[i].Value];

                for (int j = 0; j < (int)numUpDnArray[i].Value; j++) //Розміщення TextBox(для значень елементів)
                {
                    valueEl[i][j] = new TextBox();
                    valueEl[i][j].Location = new System.Drawing.Point(70 + 31 * j, 90 + 22 * i);
                    valueEl[i][j].Size = new System.Drawing.Size(30, 20);
                    this.Controls.Add(valueEl[i][j]);
                }

            }
            /////////////////////////////////
            if (first==false)//Якщо була змінена розмірність вже створеного TextBox
            {
                for (int i = 0; i < (int)numericRows.Value; i++)
                {
                    for (int j = 0; j < (int)numUpDnArray[i].Value; j++)
                    {
                        valueEl[i][j].Text = temp[i][j];
                    }
                }
            }
            ////////////////////////////////
            
        }

        
    }
}
