using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double k = 1.38;//10^-23

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_distance.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_distance.Clear();
                    throw new Exception("Указана невозможная дистанция!");
                }
                if (double.Parse(textBox_distance.Text) <= 0)
                {
                    textBox_distance.Clear();
                    throw new Exception("Указана неверная дистанция!");
                }
                double distance = double.Parse(textBox_distance.Text);
                if (textBox_elec.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_elec.Clear();
                    throw new Exception("Указано невозможное отношение анодных токов!");
                }
                if (double.Parse(textBox_elec.Text) >= 1000)
                {
                    textBox_elec.Clear();
                    throw new Exception("Указано неверное отношение анодных токов!");
                }
                double elec = double.Parse(textBox_elec.Text) / 1000;
                if (textBox_pressure.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_pressure.Clear();
                    throw new Exception("Указано невозможное давление!");
                }
                if (double.Parse(textBox_pressure.Text) <= 0)
                {
                    textBox_pressure.Clear();
                    throw new Exception("Указано неверное давление!");
                }
                double pressure = double.Parse(textBox_pressure.Text);
                if (textBox_temperature.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_temperature.Clear();
                    throw new Exception("Указана невозможная температура!");
                }
                if (int.Parse(textBox_temperature.Text) <= 0)
                {
                    textBox_temperature.Clear();
                    throw new Exception("Указана неверная температура!");
                }
                int temperature = int.Parse(textBox_temperature.Text);
                label_result.Text = cut(distance, elec, pressure, temperature).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double cut(double distance, double elec, double pressure, int temperature)
        {
            return (elec * k * temperature) / (distance * pressure);
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0, predres = 0;
            double dist = 1, pressure = 1, elec = 0.1;
            chart.Visible = true;
            try
            {
                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано невозможное значение ОТ температуры!");
                }
                if (double.Parse(textBox_min.Text) <= 0)
                {
                    textBox_min.Clear();
                    throw new Exception("Указано неверное значение ОТ температуры!");
                }
                min = double.Parse(textBox_min.Text);
                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано невозможное значение ДО температуры!");
                }
                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                {
                    textBox_max.Clear();
                    throw new Exception("Указано неверное значение ДО температуры!");
                }
                max = double.Parse(textBox_max.Text);
                if (textBox_distance_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_distance_gr.Clear();
                    throw new Exception("Указана невозможная дистанция!");
                }
                if (double.Parse(textBox_distance_gr.Text) <= 0)
                {
                    textBox_distance_gr.Clear();
                    throw new Exception("Указана неверная дистанция!");
                }
                dist = double.Parse(textBox_distance_gr.Text);
                if (textBox_elec_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_elec_gr.Clear();
                    throw new Exception("Указано невозможное время!");
                }
                if (double.Parse(textBox_elec_gr.Text) >= 1000)
                {
                    textBox_elec_gr.Clear();
                    throw new Exception("Указано неверное время!");
                }
                elec = double.Parse(textBox_elec_gr.Text)/1000;
                if (textBox_pressure_gr.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_pressure_gr.Clear();
                    throw new Exception("Указано невозможное время!");
                }
                if (double.Parse(textBox_pressure_gr.Text) <= 0)
                {
                    textBox_pressure_gr.Clear();
                    throw new Exception("Указано неверное время!");
                }
                pressure = double.Parse(textBox_pressure_gr.Text);
                predres = (elec * k) / (dist * pressure);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Сечение");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = "Температура (К)";
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Сечение (барн)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += (Math.Abs(min) + Math.Abs(max)) / 50)
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                res = predres * x;
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
