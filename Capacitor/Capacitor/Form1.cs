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
        public double e0 = 8.85 * Math.Pow(10, -12);
        public string selected;
        public string type;
        public Form1()
        {
            InitializeComponent();
        }

        private void solve_button_Click(object sender, EventArgs e)
        {
            try
            {
                double diel_pr;
                switch (type)
                {
                    case "Плоский":
                        if (textBox_diel_pr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                        }
                        if (double.Parse(textBox_diel_pr.Text) < 0)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана неверная диэлектрическая проницаемость!");
                        }
                        diel_pr = double.Parse(textBox_diel_pr.Text);
                        if (textBox_param1_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указана невозможная площадь обкладки!");
                        }
                        if (double.Parse(textBox_param1_solve.Text) <= 0)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указана неверная площадь обкладки!");
                        }
                        double area = double.Parse(textBox_param1_solve.Text);
                        if (textBox_param2_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указано невозможное расстояние между обкладками!");
                        }
                        if (double.Parse(textBox_param2_solve.Text) <= 0)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указано неверное расстояние между обкладками!!");
                        }
                        double distance = double.Parse(textBox_param2_solve.Text);
                        label_result.Text = capacion(diel_pr, area, distance, 0).ToString();
                        break;
                    case "Цилиндрический":
                        if (textBox_diel_pr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                        }
                        if (double.Parse(textBox_diel_pr.Text) < 0)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана неверная диэлектрическая проницаемость!");
                        }
                        diel_pr = double.Parse(textBox_diel_pr.Text);
                        if (textBox_param1_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указана невозможная длина!");
                        }
                        if (double.Parse(textBox_param1_solve.Text) <= 0)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указана неверная длина!");
                        }
                        double length = double.Parse(textBox_param1_solve.Text);
                        if (textBox_param2_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указан невозможный внутренний радиус!");
                        }
                        if (double.Parse(textBox_param2_solve.Text) <= 0)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указан неверный внутренний радиус!");
                        }
                        double cilinder_rad1 = double.Parse(textBox_param2_solve.Text);
                        if (textBox_param3_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param3_solve.Clear();
                            throw new Exception("Указан невозможный внешний радиус!");
                        }
                        if (double.Parse(textBox_param3_solve.Text) <= 0 || double.Parse(textBox_param3_solve.Text) <= cilinder_rad1)
                        {
                            textBox_param3_solve.Clear();
                            throw new Exception("Указан неверный внешний радиус!");
                        }
                        double cilinder_rad2 = double.Parse(textBox_param3_solve.Text);
                        label_result.Text = capacion(diel_pr, length, cilinder_rad1, cilinder_rad2).ToString();
                        break;
                    case "Сферический":
                        if (textBox_diel_pr.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                        }
                        if (double.Parse(textBox_diel_pr.Text) < 0)
                        {
                            textBox_diel_pr.Clear();
                            throw new Exception("Указана неверная диэлектрическая проницаемость!");
                        }
                        diel_pr = double.Parse(textBox_diel_pr.Text);
                        if (textBox_param1_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указан невозможный внутренний радиус!");
                        }
                        if (double.Parse(textBox_param1_solve.Text) <= 0)
                        {
                            textBox_param1_solve.Clear();
                            throw new Exception("Указан неверный внутренний радиус!");
                        }
                        double sphere_rad1 = double.Parse(textBox_param1_solve.Text);
                        if (textBox_param2_solve.Text.All<char>(Char.IsDigit) == false)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указан невозможный внешний радиус!");
                        }
                        if (double.Parse(textBox_param2_solve.Text) <= 0 || double.Parse(textBox_param2_solve.Text) <= sphere_rad1)
                        {
                            textBox_param2_solve.Clear();
                            throw new Exception("Указан неверный внешний радиус!");
                        }
                        double sphere_rad2 = double.Parse(textBox_param2_solve.Text);
                        label_result.Text = capacion(diel_pr, sphere_rad1, sphere_rad2, 0).ToString();
                        break;
                    default:
                        throw new Exception("Ошибка выбора типа конденсатора!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double capacion(double diel_pr, double param1, double param2, double param3)
        {
            switch (type)
            {
                case "Плоский":
                    return diel_pr * e0 * param1 / param2;
                case "Цилиндрический":
                    return diel_pr * 2 * Math.PI * e0 * param1 / Math.Log(param3/param2);
                case "Сферический":
                    return diel_pr * 4 * Math.PI * e0 * param1 * param2 / (param2 - param1);
                default:
                    throw new Exception("Ошибка выбора типа конденсатора!");
            }
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selected = comboBox.Text;
            switch (type)
            {
                case "Плоский":
                    switch (selected)
                    {
                        case "Диэлектрическая проницаемость (Ф/м)":
                            label_param1.Text = "Площадь обкладки (м^2):";
                            label_param2.Text = "Расстояние между обладками (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Площадь обкладки (м^2)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Расстояние между обладками (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Расстояние между обладками (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Площадь обкладки (м^2):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Цилиндрический":
                    switch (selected)
                    {
                        case "Диэлектрическая проницаемость (Ф/м)":
                            label_param1.Text = "Длина (м):";
                            label_param2.Text = "Внутренний радиус (м):";
                            label_param3.Text = "Внешний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_param3.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            textBox_param3.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Длина (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Внутренний радиус (м):";
                            label_param3.Text = "Внешний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_param3.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            textBox_param3.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Внутренний радиус (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Длина (м):";
                            label_param3.Text = "Внешний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_param3.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            textBox_param3.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Внешний радиус (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Длина (м):";
                            label_param3.Text = "Внутренний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_param3.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            textBox_param3.Clear();
                            graphics_button.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Сферический":
                    switch (selected)
                    {
                        case "Диэлектрическая проницаемость (Ф/м)":
                            label_param1.Text = "Внутренний радиус (м):";
                            label_param2.Text = "Внешний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Внутренний радиус (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Внешний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        case "Внешний радиус (м)":
                            label_param1.Text = "Диэлектрическая проницаемость (Ф/м):";
                            label_param2.Text = "Внутренний радиус (м):";
                            textBox_max.Enabled = true;
                            textBox_min.Enabled = true;
                            textBox_param1.Enabled = true;
                            textBox_param2.Enabled = true;
                            textBox_max.Clear();
                            textBox_min.Clear();
                            textBox_param1.Clear();
                            textBox_param2.Clear();
                            graphics_button.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            chart.Visible = false;
        }

        private void graphics_button_Click(object sender, EventArgs e)
        {
            double min = 0, max = 0, predres = 0;
            double rad1 = 1, rad2 = 2, diel_pr;
            chart.Visible = true;
            try
            {
                switch (type)
                {
                    case "Плоский":
                        double distance, area;
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ диэлектрической проницаемости!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО диэлектрической проницаемости!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная площадь обкладки!");
                                }
                                if (double.Parse(textBox_param1.Text) < 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная площадь обкладки!");
                                }
                                area = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указано невозможное расстояние между обкладками!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указано неверное расстояние между обкладками!");
                                }
                                distance = double.Parse(textBox_param2.Text);
                                predres = e0 * area / distance;
                                break;
                            case "Площадь обкладки (м^2)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ площади обкладки!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ площади обкладки!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО площади обкладки!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО площади обкладки!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) < 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указано невозможное расстояние между обкладками!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указано неверное расстояние между обкладками!");
                                }
                                distance = double.Parse(textBox_param2.Text);
                                predres = e0 * diel_pr / distance;
                                break;
                            case "Расстояние между обкладками (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ расстояния между обкладками!");
                                }
                                if (double.Parse(textBox_min.Text) <= 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ расстояния между обкладками!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО расстояния между обкладками!");
                                }
                                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО расстояния между обкладками!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) < 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана невозможная площадь обкладки!");
                                }
                                if (double.Parse(textBox_param2.Text) < 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана неверная площадь обкладки!");
                                }
                                area = double.Parse(textBox_param2.Text);
                                predres = e0 * diel_pr * area;
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
                        break;
                    case "Цилиндрический":
                        double length;
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ диэлектрической проницаемости!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО диэлектрической проницаемости!");
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
                                    throw new Exception("Указан невозможный внутренний радиус!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан неверный внутренний радиус!");
                                }
                                rad1 = double.Parse(textBox_param2.Text);
                                if (textBox_param3.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан невозможный внешний радиус!");
                                }
                                if (double.Parse(textBox_param3.Text) <= 0 || double.Parse(textBox_param3.Text) <= rad1)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан неверный внешний радиус!");
                                }
                                rad2 = double.Parse(textBox_param3.Text);
                                predres = 2 * Math.PI * e0 * length / Math.Log(rad2/rad1);
                                break;
                            case "Длина (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ длины!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
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
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО длины!");
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
                                    throw new Exception("Указан невозможный внутренний радиус!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан неверный внутренний радиус!");
                                }
                                rad1 = double.Parse(textBox_param2.Text);
                                if (textBox_param3.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан невозможный внешний радиус!");
                                }
                                if (double.Parse(textBox_param3.Text) <= 0 || double.Parse(textBox_param3.Text) <= rad1)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан неверный внешний радиус!");
                                }
                                rad2 = double.Parse(textBox_param3.Text);
                                predres = 2 * Math.PI * e0 * length / Math.Log(rad2 / rad1);
                                break;
                            case "Внутренний радиус (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ внутреннего радиуса!");
                                }
                                if (double.Parse(textBox_min.Text) <= 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ внутреннего радиуса!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО внутреннего радиуса!");
                                }
                                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО внутреннего радиуса!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) <= 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана невозможная длина!");
                                }
                                if (double.Parse(textBox_param2.Text) < 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана неверная длина!");
                                }
                                length = double.Parse(textBox_param2.Text);
                                if (textBox_param3.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан невозможный внешний радиус!");
                                }
                                if (double.Parse(textBox_param3.Text) <= 0 || double.Parse(textBox_param3.Text) <= min)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан неверный внешний радиус!");
                                }
                                rad2 = double.Parse(textBox_param3.Text);
                                predres = 2 * Math.PI * e0 * length;
                                break;
                            case "Внешний радиус (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ внешнего радиуса!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ внешнего радиуса!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО внешнего радиуса!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО внешнего радиуса!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) <= 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана невозможная длина!");
                                }
                                if (double.Parse(textBox_param2.Text) < 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указана неверная длина!");
                                }
                                length = double.Parse(textBox_param2.Text);
                                if (textBox_param3.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан невозможный внутренний радиус!");
                                }
                                if (double.Parse(textBox_param3.Text) <= 0)
                                {
                                    textBox_param3.Clear();
                                    throw new Exception("Указан неверный внутренний радиус!");
                                }
                                rad1 = double.Parse(textBox_param3.Text);
                                predres = 2 * Math.PI * e0 * length;
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
                        break;
                    case "Сферический":
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ диэлектрической проницаемости!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО диэлектрической проницаемости!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указан невозможный внутренний радиус!");
                                }
                                if (double.Parse(textBox_param1.Text) <= 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указан неверный внутренний радиус!");
                                }
                                rad1 = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан невозможный внешний радиус!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0 || double.Parse(textBox_param2.Text) <= rad1)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан неверный внешний радиус!");
                                }
                                rad2 = double.Parse(textBox_param2.Text);
                                predres = 4 * Math.PI * e0 * rad1 * rad2 / (rad2 - rad1);
                                break;
                            case "Внутренний радиус (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ внутреннего радиуса!");
                                }
                                if (double.Parse(textBox_min.Text) <= 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ внутреннего радиуса!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО внутреннего радиуса!");
                                }
                                if (double.Parse(textBox_max.Text) <= 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО внутреннего радиуса!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) <= 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан невозможный внешний радиус!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0 || double.Parse(textBox_param2.Text) <= min)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан неверный внешний радиус!");
                                }
                                rad2 = double.Parse(textBox_param2.Text);
                                predres = 4 * Math.PI * e0 * rad2;
                                break;
                            case "Внешний радиус (м)":
                                if (textBox_min.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано невозможное значение ОТ диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_min.Text) < 0)
                                {
                                    textBox_min.Clear();
                                    throw new Exception("Указано неверное значение ОТ диэлектрической проницаемости!");
                                }
                                min = double.Parse(textBox_min.Text);
                                if (textBox_max.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано невозможное значение ДО диэлектрической проницаемости!");
                                }
                                if (double.Parse(textBox_max.Text) < 0 || double.Parse(textBox_max.Text) < min)
                                {
                                    textBox_max.Clear();
                                    throw new Exception("Указано неверное значение ДО диэлектрической проницаемости!");
                                }
                                max = double.Parse(textBox_max.Text);
                                if (textBox_param1.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана невозможная диэлектрическая проницаемость!");
                                }
                                if (double.Parse(textBox_param1.Text) <= 0)
                                {
                                    textBox_param1.Clear();
                                    throw new Exception("Указана неверная диэлектрическая проницаемость!");
                                }
                                diel_pr = double.Parse(textBox_param1.Text);
                                if (textBox_param2.Text.All<char>(Char.IsDigit) == false)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан невозможный внутренний радиус!");
                                }
                                if (double.Parse(textBox_param2.Text) <= 0)
                                {
                                    textBox_param2.Clear();
                                    throw new Exception("Указан неверный внутренний радиус!");
                                }
                                rad1 = double.Parse(textBox_param2.Text);
                                predres = 4 * Math.PI * e0 * rad1;
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПроверьте введёные данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chart.Series.Clear();
            //Создаем и настраиваем набор точек для рисования графика, в том не забыв указать имя области на которой хотим отобразить этот набор точек
            Series mySeriesOfPoint = new Series("Электроёмкость");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = chart.ChartAreas[0].Name;
            Axis ax = new Axis();
            ax.Title = selected;
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Электроёмкость (Ф)";
            chart.ChartAreas[0].AxisY = ay;
            for (double x = min; x <= max; x += Math.Round((Math.Abs(min) + Math.Abs(max)) / 50))
            {
                if (x + Math.Round((Math.Abs(min) + Math.Abs(max)) / 50) >= max) x = max;
                double res = 0;
                switch (type)
                {
                    case "Плоский":
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                res = predres * x;
                                break;
                            case "Площадь обкладки (м^2)":
                                res = predres * x;
                                break;
                            case "Расстояние между обкладками (м)":
                                res = predres / x;
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
                        break;
                    case "Цилиндрический":
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                res = predres * x;
                                break;
                            case "Длина (м)":
                                res = predres * x;
                                break;
                            case "Внутренний радиус (м)":
                                res = predres / Math.Log(rad2 / x);
                                break;
                            case "Внешний радиус (м)":
                                res = predres / Math.Log(x / rad1);
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
                        break;
                    case "Сферический":
                        switch (selected)
                        {
                            case "Диэлектрическая проницаемость (Ф/м)":
                                res = predres * x;
                                break;
                            case "Внутренний радиус (м)":
                                res = predres * x / (rad2 - x);
                                break;
                            case "Внешний радиус (м)":
                                res = predres * x / (x - rad1);
                                break;
                            default:
                                throw new Exception("Параметр не выбран!");
                        }
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
            comboBox.Items.Clear();
            textBox_param1_solve.Enabled = false;
            textBox_param2_solve.Enabled = false;
            textBox_param3_solve.Enabled = false;
            textBox_max.Enabled = false;
            textBox_min.Enabled = false;
            textBox_param1.Enabled = false;
            textBox_param2.Enabled = false;
            textBox_param3.Enabled = false;
            textBox_diel_pr.Enabled = false;
            graphics_button.Enabled = false;
            solve_button.Enabled = false;
        }

        private void comboBox_type_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_type.Text)
            {
                case "Плоский":
                    //solving
                    label_param1_solve.Text = "Площадь обладки (м^2):";
                    label_param2_solve.Text = "Расстояние между обкладками (м):";
                    label_param3_solve.Visible = false;
                    label_param3_solve.Text = "Параметр 3:";
                    label_result.Text = "" ;
                    textBox_param1_solve.Clear();
                    textBox_param1_solve.Enabled = true;
                    textBox_param2_solve.Clear();
                    textBox_param2_solve.Enabled = true;
                    textBox_param3_solve.Clear();
                    textBox_param3_solve.Enabled = false;
                    textBox_param3_solve.Visible = false;
                    textBox_diel_pr.Enabled = true;
                    //graphics
                    label_param1.Text = "Параметр 1:";
                    label_param2.Text = "Параметр 2:";
                    label_param3.Text = "Параметр 3:";
                    comboBox.SelectedValue = "";
                    label_param3.Visible = false;
                    textBox_max.Clear();
                    textBox_max.Enabled = false;
                    textBox_min.Clear();
                    textBox_min.Enabled = false;
                    textBox_param1.Clear();
                    textBox_param1.Enabled = false;
                    textBox_param2.Clear();
                    textBox_param2.Enabled = false;
                    textBox_param3.Clear();
                    textBox_param3.Enabled = false;
                    textBox_param3.Visible = false;
                    type = "Плоский";
                    chart.Visible = false;
                    comboBox.Items.Clear();
                    comboBox.Items.Add("Диэлектрическая проницаемость (Ф/м)");
                    comboBox.Items.Add("Площадь обладки (м^2)");
                    comboBox.Items.Add("Расстояние между обкладками (м)");
                    solve_button.Enabled = true;
                    graphics_button.Enabled = false;
                    textBox_diel_pr.Enabled = true;
                    break;
;                case "Цилиндрический":
                    //solving
                    label_param1_solve.Text = "Длина (м):";
                    label_param2_solve.Text = "Внутренний радиус (м):";
                    label_param3_solve.Visible = true;
                    label_param3_solve.Text = "Внешний радиус (м):";
                    label_result.Text = "";
                    textBox_param1_solve.Clear();
                    textBox_param1_solve.Enabled = true;
                    textBox_param2_solve.Clear();
                    textBox_param2_solve.Enabled = true;
                    textBox_param3_solve.Clear();
                    textBox_param3_solve.Enabled = true;
                    textBox_param3_solve.Visible = true;
                    textBox_param3_solve.Clear();
                    //graphics
                    label_param1.Text = "Параметр 1:";
                    label_param2.Text = "Параметр 2:";
                    label_param3.Text = "Параметр 3:";
                    comboBox.SelectedValue = "";
                    label_param3.Visible = true;
                    textBox_max.Clear();
                    textBox_max.Enabled = false;
                    textBox_min.Clear();
                    textBox_min.Enabled = false;
                    textBox_param1.Clear();
                    textBox_param1.Enabled = false;
                    textBox_param2.Clear();
                    textBox_param2.Enabled = false;
                    textBox_param3.Clear();
                    textBox_param3.Enabled = false;
                    textBox_param3.Visible = true;
                    type = "Цилиндрический";
                    chart.Visible = false;
                    comboBox.Items.Clear();
                    comboBox.Items.Add("Диэлектрическая проницаемость (Ф/м)");
                    comboBox.Items.Add("Длина (м)");
                    comboBox.Items.Add("Внутренний радиус (м)");
                    comboBox.Items.Add("Внешний радиус (м)");
                    solve_button.Enabled = true;
                    graphics_button.Enabled = false;
                    textBox_diel_pr.Enabled = true;
                    break;
                case "Сферический":
                    //solving
                    label_param1_solve.Text = "Внутренний радиус (м):";
                    label_param2_solve.Text = "Внешний радиус (м):";
                    label_param3_solve.Visible = false;
                    label_param3_solve.Text = "Параметр 3:";
                    label_result.Text = "";
                    textBox_param1_solve.Clear();
                    textBox_param1_solve.Enabled = true;
                    textBox_param2_solve.Clear();
                    textBox_param2_solve.Enabled = true;
                    textBox_param3_solve.Clear();
                    textBox_param3_solve.Enabled = false;
                    textBox_param3_solve.Visible = false;
                    //graphics
                    label_param1.Text = "Параметр 1:";
                    label_param2.Text = "Параметр 2:";
                    label_param3.Text = "Параметр 3:";
                    comboBox.SelectedValue = "";
                    textBox_max.Clear();
                    textBox_max.Enabled = false;
                    textBox_min.Clear();
                    textBox_min.Enabled = false;
                    textBox_param1.Clear();
                    textBox_param1.Enabled = false;
                    textBox_param2.Clear();
                    textBox_param2.Enabled = false;
                    textBox_param3.Clear();
                    textBox_param3.Enabled = false;
                    textBox_param3.Visible = false;
                    type = "Сферический";
                    chart.Visible = false;
                    comboBox.Items.Clear();
                    comboBox.Items.Add("Диэлектрическая проницаемость (Ф/м)");
                    comboBox.Items.Add("Внутренний радиус (м)");
                    comboBox.Items.Add("Внешний радиус (м)");
                    solve_button.Enabled = true;
                    graphics_button.Enabled = false;
                    textBox_diel_pr.Enabled = true;
                    break;
                default:
                    break;
            }
            chart.Visible = false;
        }
    }
}
