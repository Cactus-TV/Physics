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

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_charge.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_charge.Clear();
                    throw new Exception("Указана невозможный заряд!");
                }
                if (double.Parse(textBox_charge.Text) <= 0)
                {
                    textBox_charge.Clear();
                    throw new Exception("Указана неверный заряд!");
                }
                double charge = double.Parse(textBox_charge.Text);
                if (textBox_mag.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mag.Clear();
                    throw new Exception("Указано невозможное значение магнитного потока!");
                }
                if (double.Parse(textBox_mag.Text) <= 0)
                {
                    textBox_mag.Clear();
                    throw new Exception("Указано неверное значение магнитного потока!");
                }
                double mag = double.Parse(textBox_mag.Text) / 1000;
                if (textBox_rad.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_rad.Clear();
                    throw new Exception("Указан невозможный радиус дуант!");
                }
                if (double.Parse(textBox_rad.Text) <= 0)
                {
                    textBox_rad.Clear();
                    throw new Exception("Указан неверный радиус дуант!");
                }
                double rad = double.Parse(textBox_rad.Text);
                if (textBox_mass.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mass.Clear();
                    throw new Exception("Указана невозможная температура!");
                }
                if (double.Parse(textBox_mass.Text) <= 0)
                {
                    textBox_mass.Clear();
                    throw new Exception("Указана неверная температура!");
                }
                double mass = double.Parse(textBox_mass.Text);
                label_result.Text = energy(charge, mag, rad, mass).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double energy(double charge, double mag, double rad, double mass)
        {
            return 1/2 * charge * charge * mag * mag * rad * rad / mass;
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0, predres = 0;
            double charge = 0, mag = 0, mass = 10;
            chart.Visible = true;
            try
            {
                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано невозможное значение ОТ радиуса!");
                }
                if (double.Parse(textBox_min.Text) <= 0)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано неверное значение ОТ радиуса!");
                }
                min = double.Parse(textBox_min.Text);
                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано невозможное значение ДО радиуса!");
                }
                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано неверное значение ДО радиуса!");
                }
                max = double.Parse(textBox_max.Text);
                if (textBox_charge_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_charge_gr.Clear();
                    throw new Exception("Указана невозможный заряд!");
                }
                if (double.Parse(textBox_charge_gr.Text) <= 0)
                {
                    textBox_charge_gr.Clear();
                    throw new Exception("Указана неверный заряд!");
                }
                charge = double.Parse(textBox_charge_gr.Text);
                if (textBox_mag_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mag_gr.Clear();
                    throw new Exception("Указано невозможное значение магнитного потока!");
                }
                if (double.Parse(textBox_mag_gr.Text) <= 0)
                {
                    textBox_mag_gr.Clear();
                    throw new Exception("Указано неверное значение магнитного потока!");
                }
                mag = double.Parse(textBox_mag_gr.Text) / 1000;
                if (textBox_mass_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_mass_gr.Clear();
                    throw new Exception("Указана невозможная температура!");
                }
                if (double.Parse(textBox_mass_gr.Text) <= 0)
                {
                    textBox_mass_gr.Clear();
                    throw new Exception("Указана неверная температура!");
                }
                mass = double.Parse(textBox_mass_gr.Text);
                predres = 1 / 2 * charge * charge * mag * mag / mass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Максимальная энергия");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = "Радиус (м)";
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Энергия (Дж)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += (Math.Abs(min) + Math.Abs(max)) / 50)
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                res = predres * x * x;
                mySeriesOfPoint.Points.AddXY(x, res);
            }
            //Добавляем созданный набор точек в Chart
            chart.Series.Add(mySeriesOfPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
