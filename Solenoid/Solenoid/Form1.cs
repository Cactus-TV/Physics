using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Solenoid_2
{
    public partial class Form1 : Form
    {
        public const double magnit = 4 * 3.14 * 0.0000007;
        public string selected;
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
                    throw new Exception("Указана невозможная длина!");
                }
                if (double.Parse(textBox_length.Text) <= 0)
                {
                    textBox_length.Clear();
                    throw new Exception("Указана неверная длина!");
                }
                double length = double.Parse(textBox_amount.Text);
                if (textBox_length.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_amount.Clear();
                    throw new Exception("Указано невозможное число витков!");
                }
                if (int.Parse(textBox_amount.Text) < 0)
                {
                    textBox_amount.Clear();
                    throw new Exception("Указано неверное число витков!");
                }
                int amount = int.Parse(textBox_amount.Text);
                if (textBox_ampers.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_ampers.Clear();
                    throw new Exception("Указана невозможная сила тока!");
                }
                if (double.Parse(textBox_ampers.Text) < 0)
                {
                    textBox_ampers.Clear();
                    throw new Exception("Указана неверная сила тока!");
                }
                double ampers = double.Parse(textBox_ampers.Text);
                label_otvet.Text = magnetic_induction(length, amount, ampers).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double magnetic_induction(double len, int count, double amp)
        {
            return magnit * count * amp / len;
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selected = comboBox.Text;
            switch (comboBox.Text)
            {
                case "Длина (м)":
                    label_param1.Text = "Сила тока (А):";
                    label_param2.Text = "Число витков:";
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1.Clear();
                    textBox_param2.Clear();
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1.Enabled = true;
                    textBox_param2.Enabled = true;
                    break;
                case "Сила тока (А)":
                    label_param1.Text = "Длина (м):";
                    label_param2.Text = "Число витков:";
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1.Clear();
                    textBox_param2.Clear();
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1.Enabled = true;
                    textBox_param2.Enabled = true;
                    break;
                case "Число витков":
                    label_param1.Text = "Длина (м):";
                    label_param2.Text = "Сила тока (А):";
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1.Clear();
                    textBox_param2.Clear();
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1.Enabled = true;
                    textBox_param2.Enabled = true;
                    break;
                default:
                    break;
            }
            chart.Visible = false;
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = -1, max = -1, predres = 0;
            chart.Visible = true;
            try
            {
                int amount;
                double ampers, length;
                switch (selected)
                {
                    case "Длина (м)":
                        if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано невозможное значение ОТ длины!");
                        }
                        if (double.Parse(textBox_min.Text) <= 0)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано неверное значение ОТ длины!");
                        }
                        min = double.Parse(textBox_min.Text);
                        if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано невозможное значение ДО длины!");
                        }
                        if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано неверное значение ДО длины!");
                        }
                        max = double.Parse(textBox_max.Text);
                        if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указано невозможное число витков!");
                        }
                        if (int.Parse(textBox_param1.Text) < 0)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указано неверное число витков!");
                        }
                        amount = int.Parse(textBox_param1.Text);
                        if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указана невозможная сила тока!");
                        }
                        if (double.Parse(textBox_param2.Text) < 0)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указана неверная сила тока!");
                        }
                        ampers = double.Parse(textBox_param2.Text);
                        predres = magnit * ampers * amount;
                        break;
                    case "Сила тока (А)":
                        if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано невозможное значение ОТ силы тока!");
                        }
                        if (double.Parse(textBox_min.Text) <= 0)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано неверное значение ОТ силы тока!");
                        }
                        min = double.Parse(textBox_min.Text);
                        if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано невозможное значение ДО силы тока!");
                        }
                        if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано неверное значение ДО силы тока!");
                        }
                        max = double.Parse(textBox_max.Text);
                        if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указана невозможная длина!");
                        }
                        if (double.Parse(textBox_param1.Text) < 0)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указана неверная длина!");
                        }
                        length = double.Parse(textBox_param1.Text);
                        if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указано невозможное число витков!");
                        }
                        if (int.Parse(textBox_param2.Text) < 0)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указано неверное число витков!");
                        }
                        amount = int.Parse(textBox_param2.Text);
                        predres = magnit * amount / length;
                        break;
                    case "Число витков":
                        if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано невозможное значение ОТ числа витков!");
                        }
                        if (int.Parse(textBox_min.Text) <= 0)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано неверное значение ОТ числа витков!");
                        }
                        min = int.Parse(textBox_min.Text);
                        if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано невозможное значение ДО числа витков!");
                        }
                        if (int.Parse(textBox_max.Text) <= 0 || int.Parse(textBox_max.Text) < min)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано неверное значение ДО числа витков!");
                        }
                        max = int.Parse(textBox_max.Text);
                        if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указана невозможная длина!");
                        }
                        if (double.Parse(textBox_param1.Text) < 0)
                        {
                            textBox_param1.Clear();
                            throw new Exception("Указана неверная длина!");
                        }
                        length = double.Parse(textBox_param1.Text);
                        if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указана невозможная сила тока!");
                        }
                        if (double.Parse(textBox_param2.Text) < 0)
                        {
                            textBox_param2.Clear();
                            throw new Exception("Указана неверная сила тока!");
                        }
                        ampers = double.Parse(textBox_param2.Text);
                        predres = magnit * ampers / length;
                        break;
                    default:
                        throw new Exception("Параметр не выбран!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек.
            Series mySeriesOfPoint = new Series("Индукция");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = selected;
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Магнитная индукция (Тл)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += Math.Round((Math.Abs(min) + Math.Abs(max)) / 50))
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                switch (selected)
                {
                    case "Длина (м)":
                        res = predres / x;
                        break;
                    case "Сила тока (А)":
                        res = predres * x;
                        break;
                    case "Число витков":
                        res = predres * x;
                        break;
                    default:
                        break;
                }
                mySeriesOfPoint.Points.AddXY(x, res);
            }
            //Добавляем созданный набор точек в Chart
            chart.Series.Add(mySeriesOfPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.Visible = false;
            textBox_max.Enabled = false;
            textBox_min.Enabled = false;
            textBox_param1.Enabled = false;
            textBox_param2.Enabled = false;
        }
    }
}
