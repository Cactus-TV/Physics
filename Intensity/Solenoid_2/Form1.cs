using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Intensity
{
    public partial class Form1 : Form
    {
        public string selected;
        public Form1()
        {
            InitializeComponent();
        }

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                double energy;

                if (textBox_energy.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_energy.Clear();
                    throw new Exception("Указана невозможная энергия!");
                }
                if (double.Parse(textBox_energy.Text) < 0)
                {
                    textBox_energy.Clear();
                    throw new Exception("Указана неверная энергия!");
                }
                energy = double.Parse(textBox_energy.Text);
                if (textBox_radius.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_radius.Clear();
                    throw new Exception("Указан невозможный радиус!");
                }
                if (double.Parse(textBox_radius.Text) <= 0)
                {
                    textBox_radius.Clear();
                    throw new Exception("Указан неверный радиус!");
                }
                double radius = double.Parse(textBox_radius.Text);
                if (textBox_time.Text.All<char>(Char.IsDigit) == false)
                {
                    textBox_time.Clear();
                    throw new Exception("Указано невозможное время!");
                }
                if (double.Parse(textBox_time.Text) <= 0)
                {
                    textBox_time.Clear();
                    throw new Exception("Указано неверное время!");
                }
                double time = double.Parse(textBox_time.Text);
                label_result.Text = intense(energy, radius, time).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double intense(double energy, double radius, double time)
        {
            return energy / (4 * Math.PI * Math.Pow(radius, 2) * time);
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selected = comboBox.Text;
            switch (selected)
            {
                case "Энергия (Дж)":
                    label_param1_gr.Text = "Радиус (м)";
                    label_param2_gr.Text = "Время (с)";
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1_gr.Enabled = true;
                    textBox_param2_gr.Enabled = true;
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1_gr.Clear();
                    textBox_param2_gr.Clear();
                    graphics_button.Enabled = true;
                    break;
                case "Радиус (м)":
                    label_param1_gr.Text = "Энергия (Дж)";
                    label_param2_gr.Text = "Время (с)";
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1_gr.Enabled = true;
                    textBox_param2_gr.Enabled = true;
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1_gr.Clear();
                    textBox_param2_gr.Clear();
                    graphics_button.Enabled = true;
                    break;
                case "Время (с)":
                    label_param1_gr.Text = "Энергия (Дж)";
                    label_param2_gr.Text = "Радиус (м)";
                    textBox_max.Enabled = true;
                    textBox_min.Enabled = true;
                    textBox_param1_gr.Enabled = true;
                    textBox_param2_gr.Enabled = true;
                    textBox_max.Clear();
                    textBox_min.Clear();
                    textBox_param1_gr.Clear();
                    textBox_param2_gr.Clear();
                    graphics_button.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0, predres = 0;
            double energy = 0, radius = 1, time = 1; 
            chart.Visible = true;
            try
            {
                switch (selected)
                {
                    case "Энергия (Дж)":
                        if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано невозможное значение ОТ энергии!");
                        }
                        if (double.Parse(textBox_min.Text) < 0)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано неверное значение ОТ энергии!");
                        }
                        min = double.Parse(textBox_min.Text);
                        if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано невозможное значение ДО энергии!");
                        }
                        if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано неверное значение ДО энергии!");
                        }
                        max = double.Parse(textBox_max.Text);
                        if (textBox_param1_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указан невозможный радиус!");
                        }
                        if (double.Parse(textBox_param1_gr.Text) <= 0)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указан неверный радиус!");
                        }
                        radius = double.Parse(textBox_param1_gr.Text);
                        if (textBox_param2_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указано невозможное время!");
                        }
                        if (double.Parse(textBox_param2_gr.Text) <= 0)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указано неверное время!");
                        }
                        time = double.Parse(textBox_param2_gr.Text);
                        predres = 4 * Math.PI * Math.Pow(radius, 2) * time;
                        break;
                    case "Радиус (м)":
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
                        if (textBox_param1_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указана невозможная энергия!");
                        }
                        if (double.Parse(textBox_param1_gr.Text) < 0)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указана неверная энергия!");
                        }
                        energy = double.Parse(textBox_param1_gr.Text);
                        if (textBox_param2_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указано невозможное время!");
                        }
                        if (double.Parse(textBox_param2_gr.Text) <= 0)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указано неверное время!");
                        }
                        time = double.Parse(textBox_param2_gr.Text);
                        predres = energy / (4 * Math.PI * time);
                        break;
                    case "Время (с)":
                        if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано невозможное значение ОТ времени!");
                        }
                        if (double.Parse(textBox_min.Text) < 0)
                        {
                            textBox_min.Clear();
                            throw new Exception("Указано неверное значение ОТ времени!");
                        }
                        min = double.Parse(textBox_min.Text);
                        if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано невозможное значение ДО времени!");
                        }
                        if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                        {
                            textBox_max.Clear();
                            throw new Exception("Указано неверное значение ДО времени!");
                        }
                        max = double.Parse(textBox_max.Text);
                        if (textBox_param1_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указана невозможная энергия!");
                        }
                        if (double.Parse(textBox_param1_gr.Text) <= 0)
                        {
                            textBox_param1_gr.Clear();
                            throw new Exception("Указана неверная энергия!");
                        }
                        energy = double.Parse(textBox_param1_gr.Text);
                        if (textBox_param2_gr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указан невозможный радиус!");
                        }
                        if (double.Parse(textBox_param2_gr.Text) <= 0)
                        {
                            textBox_param2_gr.Clear();
                            throw new Exception("Указан неверный радиус!");
                        }
                        radius = double.Parse(textBox_param2_gr.Text);
                        predres = energy / (4 * Math.PI * Math.Pow(radius, 2));
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
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Интенсивность");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = selected;
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Интенсивность (Вт/м^2)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += (Math.Abs(min) + Math.Abs(max)) / 50)
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                switch (selected)
                {
                    case "Энергия (Дж)":
                        res = x / predres;
                        break;
                    case "Радиус (м)":
                        res = predres / Math.Pow(x, 2);
                        break;
                    case "Время (с)":
                        res = predres / x;
                        break;
                    default:
                        throw new Exception("Параметр не выбран!");
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
            textBox_param1_gr.Enabled = false;
            textBox_param2_gr.Enabled = false;
            graphics_button.Enabled = false;
        }
    }
}
