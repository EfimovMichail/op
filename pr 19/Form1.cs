using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------------
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2(); // создание объекта класса Form2
            newF.Show(); // открытие формы newF
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // закрытие формы
        }
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // очистка текстовых полей
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, "Введите число!"); // всплывающая подсказка для textBox2
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox3, "сюда тоже введите число!"); // всплывающая подсказка для textBox3
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(textBox1, "тут будет ваш результат!"); // всплывающая подсказка для textBox1
        }

        private void btn_Math1_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Math1, "Выполнить расчет");
        }
        private void btn_Math1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_Close1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Close1, "выход из приложения")
            try
            {
                
                double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12;
                // преобразование строкового пердставления числа в эквивалентное ему число типа double
                double x = double.Parse(textBox2.Text);
                double b = double.Parse(textBox3.Text);
                v1 = Math.Pow(x, 2);
                Console.WriteLine(v1);
                double temp = 17 * b * x + 7;
                Console.WriteLine(temp);
                v1 = v1 - temp;
                Console.WriteLine(v1);
                v2 = 2 * Math.Pow(x, b) + 5;
                Console.WriteLine(v2);
                v2 = 3 * v2 - x;
                Console.WriteLine(v2);
                v3 = Math.Abs(v1 / v2);
                Console.WriteLine(v3);
                v4 = b - 1;
                Console.WriteLine(v4);
                v5 = 1 - b * x;
                Console.WriteLine(v5);
                v6 = v4 / v5;
                Console.WriteLine(v6);
                v7 = Math.Pow(x, 3) + 1;
                Console.WriteLine(v7);
                v8 = Math.Pow(x, 3) - b;
                Console.WriteLine(v8);
                v9 = v7 / v8;
                Console.WriteLine(v9);
                v10 = v6 / v9;
                Console.WriteLine(v10);
                v11 = 3 * Math.Exp(v3);
                Console.WriteLine(v11);
                v12 = v10 + v11;
                Console.WriteLine(v12);

                double Y = v10 + v11;
                Y = Math.Round(Y, 3, MidpointRounding.AwayFromZero);// округление до 3 знаков после запятой к тому числу, которое дальше от нуля

                // преобразование числа в эквивалетное ему строковое значение
                textBox1.Text = Y.ToString();    
            }
            catch(FormatException ex)
            {
              // +ex.ToString()
             MessageBox.Show("Проверьте правильность введенных данных!","ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            };
        }

        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Math1_Click(sender, e); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(".\\Icons\\Formula.png"); // загрузка изображения 
            btn_Math1.Image = Image.FromFile(".\\Icons\\Forward.png");
            btn_Close1.Image = Image.FromFile(".\\Icons\\Delete.png");
            Console.ReadKey();
        }
        
    }
    

}
