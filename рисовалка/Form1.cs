//Библиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Автор Дамир Алмаев Маратович

//Сама прога
namespace рисовалка
{
    public partial class Form1 : Form
    {
        //переменные

        public static int x1, x2, x3, x4, y1, y2, y3, y4 = 0;//Для рисования

        //Мусор

        private void Form1_Load(object sender, EventArgs e)//При загрузки
        {
            //тут нет нечего)))
        }

        //Мусор

        //Автор Дамир Алмаев Маратович

        public static string text = "";//Просто переменная которое исправляет один баг

        //Начинаем писать код!

        private void pictureBox1_Paint(object sender, PaintEventArgs e)//Рисование
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x1, y1, x2, y2);//Рисуем линию
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x2, y2, x3, y3);//Рисуем линию
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x1, y1, x3, y3);//Рисуем линию
            //и получаем!
        }

        //Автор Дамир Алмаев Маратович

        public Form1()//Загружаем форму
        {
            InitializeComponent();//Загружаем форму
        }

        private void button1_Click(object sender, EventArgs e)//Когда нажимаем на кнопку, то
        {
            try//обработка
            {
                x1 = Convert.ToInt32(textBox1.Text);//Водим переменные инфу
                y1 = Convert.ToInt32(textBox2.Text);//Водим переменные инфу
                x2 = Convert.ToInt32(textBox3.Text);//Водим переменные инфу
                y2 = Convert.ToInt32(textBox4.Text);//Водим переменные инфу
                x3 = Convert.ToInt32(textBox5.Text);//Водим переменные инфу
                y3 = Convert.ToInt32(textBox6.Text);//Водим переменные инфу

                //Автор Дамир Алмаев Маратович

                //Проверка
                if (text == "")//если переменная text = нечего, то
                    text = xandy.Text;//он сохраняет значении инфы
                xandy.Text = Convert.ToString("x1 = " + x1 + " y1 = " + y1 + " x2 = " + x2 + " y2 = " + y2 + " x3 = " + x3 + " y3 = " + y3);//Выводим инфу
                pictureBox1.Refresh();//Запускаем рестарт и рисование
            }
            //Если ошибка, то
            catch { MessageBox.Show("Error", "" + this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }//Выводим ошибку
        }

        //Автор Дамир Алмаев Маратович

    }
}
//конец
//Автор Дамир Алмаев Маратович
