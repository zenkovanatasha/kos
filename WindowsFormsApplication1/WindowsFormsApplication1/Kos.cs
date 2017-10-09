using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()

        {          
            InitializeComponent();
            Text = "Косынка";
            this.BackColor = Color.Chartreuse;
            List<Image> picts = new List<Image>();

            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\1.jpg"));// 0 Туз пиковый
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\2.jpg"));// 1 Король 
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\3.jpg"));// 2 Дама 
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\4.jpg"));// 3 Валет 
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\5.jpg"));// 4 10 
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\6.jpg"));// 5 9
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\7.jpg"));// 6 8
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\8.jpg"));// 7 7
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\9.jpg"));// 8 6
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\10.jpg"));// 9 5
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\11.jpg"));// 10 4
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\12.jpg"));// 11 3
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\13.jpg"));// 12 2
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\14.jpg"));// 13 Туз креста
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\15.jpg"));// 14 Король
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\16.jpg"));// 15 Дама
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\17.jpg"));// 16 Валет
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\18.jpg"));// 17 10
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\19.jpg"));// 18 9
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\20.jpg"));// 19 8
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\21.jpg"));// 20 7
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\22.jpg"));// 21 6
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\23.jpg"));// 22 5
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\24.jpg"));// 23 4
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\25.jpg"));// 24 3
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\26.jpg"));// 25 2
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\27.jpg"));// 26 Туз черва
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\28.jpg"));// 27 Король
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\29.jpg"));// 28 Дама
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\30.jpg"));// 29 Валет
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\31.jpg"));// 30 10
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\32.jpg"));// 31 9
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\33.jpg"));// 32 8
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\34.jpg"));// 33 7
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\35.jpg"));// 34 6
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\36.jpg"));// 35 5
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\37.jpg"));// 36 4
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\38.jpg"));// 37 3
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\39.jpg"));// 38 2
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\40.jpg"));// 39 Туз Буба
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\41.jpg"));// 40 Король
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\42.jpg"));// 41 Дама
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\43.jpg"));// 42 Валет
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\44.jpg"));// 43 10
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\45.jpg"));// 44 9
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\46.jpg"));// 45 8
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\47.jpg"));// 46 7
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\48.jpg"));// 47 6
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\49.jpg"));// 48 5
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\50.jpg"));// 49 4
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\51.jpg"));// 50 3
            picts.Add(Image.FromFile("H:\\Косынка\\Карты\\52.jpg"));// 51 2








            pictureBox17.Image=picts[0]; 

        }

      
        

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)/// Нажатие на кнопку новая игра
        {
            MessageBox.Show("Игра начинается, удачи!");

        }

        private void pictureBox2_Click(object sender, EventArgs e)/// вся колода
        {
            
            

            
        }

        private void pictureBox36_Click(object sender, EventArgs e)///Самая левая карта
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)///Средняя карта
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)///Правая карта
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
