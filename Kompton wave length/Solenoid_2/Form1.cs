using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kompton_effect
{
    public partial class Form1 : Form
    {
        public const double c = 2.997924;//* 10^8
        public const double h = 6.626070;//* 10^(-34)
        public double length = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_length.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_length.Clear();
                    throw new Exception("Указана невозможная длина волны!");
                }
                if (double.Parse(textBox_length.Text) <= 0)
                {
                    textBox_length.Clear();
                    throw new Exception("Указана неверная длина волны!");
                }
                length = double.Parse(textBox_length.Text);//* 10^(-9)
                label_final.Text = mass(length).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double mass(double length)
        {
            return h / (length * c);// 10^(-34) / (10^(-9) * 10^8) = 10^(-33)
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0;
            chart.Visible = true;
            try
            {
                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано невозможное значение ОТ длины волны!");
                }
                if (double.Parse(textBox_min.Text) <= 0)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано неверное значение ОТ длины волны!");
                }
                min = double.Parse(textBox_min.Text);
                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано невозможное значение ДО длины волны!");
                }
                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано неверное значение ДО длины волны!");
                }
                max = double.Parse(textBox_max.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Масса частицы");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = "Длина волны (нм)";
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Масса (кг 10^(-33))";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += (Math.Abs(min) + Math.Abs(max)) / 50)
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = mass(x);
                mySeriesOfPoint.Points.AddXY(x, res);
            }
            //Добавляем созданный набор точек в Chart
            chart.Series.Add(mySeriesOfPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.Visible = false;
            label_final.Text = "";
        }

        private void button_colour_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            // Update the text box color if the user clicks OK 
            bool flag = false;
            do
            {
                MessageBox.Show("Выберите только один из семи цветов радуги!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    flag = false;
                    if (MyDialog.Color == Color.Violet || MyDialog.Color == Color.Purple || MyDialog.Color == Color.MediumPurple)
                    {
                        length = 400;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.Blue || MyDialog.Color == Color.Aqua || MyDialog.Color == Color.Aquamarine || MyDialog.Color == Color.MediumBlue || MyDialog.Color == Color.MediumAquamarine || MyDialog.Color == Color.DarkBlue)
                    {
                        length = 445;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.LightBlue || MyDialog.Color == Color.MediumBlue || MyDialog.Color == Color.AliceBlue || MyDialog.Color == Color.CadetBlue)
                    {
                        length = 490;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.Green || MyDialog.Color == Color.MediumSeaGreen || MyDialog.Color == Color.DarkGreen || MyDialog.Color == Color.GreenYellow)
                    {
                        length = 535;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.Yellow || MyDialog.Color == Color.LightYellow || MyDialog.Color == Color.YellowGreen)
                    {
                        length = 580;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.Orange || MyDialog.Color == Color.DarkOrange || MyDialog.Color == Color.OrangeRed)
                    {
                        length = 625;
                        textBox_length.Text = length.ToString();
                    }
                    else if (MyDialog.Color == Color.Red || MyDialog.Color == Color.DarkRed || MyDialog.Color == Color.IndianRed)
                    {
                        length = 670;
                        textBox_length.Text = length.ToString();
                    }
                    else
                    {
                        flag = true;
                        MessageBox.Show("Выберите только один из семи цветов радуги! Этот цвет не поддерживается(", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } while (flag);
        }
    }
}
