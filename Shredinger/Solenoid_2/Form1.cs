using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double h = 6.626;//10^-34

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_level.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_level.Clear();
                    throw new Exception("Указан невозможный энергетический уровень!");
                }
                if (int.Parse(textBox_level.Text) < 1 || int.Parse(textBox_level.Text) > 118)
                {
                    textBox_level.Clear();
                    throw new Exception("Указан неверный энергетический уровень!");
                }
                int level = int.Parse(textBox_level.Text);
                if (textBox_mass.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mass.Clear();
                    throw new Exception("Указана невозможная масса!");
                }
                if (double.Parse(textBox_mass.Text) <= 0)
                {
                    textBox_mass.Clear();
                    throw new Exception("Указана неверная масса!");
                }
                double mass = double.Parse(textBox_mass.Text);
                if (textBox_wide.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_wide.Clear();
                    throw new Exception("Указана невозможная ширина!");
                }
                if (double.Parse(textBox_wide.Text) <= 0)
                {
                    textBox_wide.Clear();
                    throw new Exception("Указана неверная ширина!");
                }
                double wide = double.Parse(textBox_wide.Text);
                label_result.Text = energy(level, mass, wide).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double energy(int level, double mass, double wide)
        {
            return (10 * level*level * h*h) / (8 * mass * wide*wide);
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0, predres = 0;
            int level = 1;
            double mass = 1;
            chart.Visible = true;
            try
            {
                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано невозможное значение ОТ ширины!");
                }
                if (double.Parse(textBox_min.Text) <= 0)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано неверное значение ОТ ширины!");
                }
                min = double.Parse(textBox_min.Text);
                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано невозможное значение ДО ширины!");
                }
                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано неверное значение ДО ширины!");
                }
                max = double.Parse(textBox_max.Text);
                if (textBox_level_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_level_gr.Clear();
                    throw new Exception("Указан невозможный энергетический уровень!");
                }
                if (int.Parse(textBox_level_gr.Text) <= 0)
                {
                    textBox_level_gr.Clear();
                    throw new Exception("Указан неверный энергетический уровень!");
                }
                level = int.Parse(textBox_level_gr.Text);
                if (textBox_mass_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mass_gr.Clear();
                    throw new Exception("Указано невозможное время!");
                }
                if (double.Parse(textBox_mass_gr.Text) >= 1000)
                {
                    textBox_mass_gr.Clear();
                    throw new Exception("Указано неверное время!");
                }
                mass = double.Parse(textBox_mass_gr.Text);
                predres = (level * level * h * h) / (8 * mass);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Энергия");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = "Ширина (мм)";
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Энергия (Дж)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += (Math.Abs(min) + Math.Abs(max)) / 50)
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                res = 10 * predres / (x*x);
                mySeriesOfPoint.Points.AddXY(x, res);
            }
            //Добавляем созданный набор точек в Chart
            chart.Series.Add(mySeriesOfPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
