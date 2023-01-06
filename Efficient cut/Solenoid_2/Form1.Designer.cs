﻿
using System;

namespace Cut
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_param1_solve = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_capacity = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_counting = new System.Windows.Forms.Label();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_elec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pressure = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_temperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pressure_gr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_elec_gr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_distance_gr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea4.Name = "chartarea";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(10, 398);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(962, 551);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label_param1_solve
            // 
            this.label_param1_solve.AutoSize = true;
            this.label_param1_solve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1_solve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1_solve.Location = new System.Drawing.Point(473, 47);
            this.label_param1_solve.Name = "label_param1_solve";
            this.label_param1_solve.Size = new System.Drawing.Size(239, 21);
            this.label_param1_solve.TabIndex = 5;
            this.label_param1_solve.Text = "Расстояние катод-сетка (мкм):";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_to.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_to.Location = new System.Drawing.Point(12, 373);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(38, 21);
            this.label_to.TabIndex = 27;
            this.label_to.Text = "ДО:";
            // 
            // label_capacity
            // 
            this.label_capacity.AutoSize = true;
            this.label_capacity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_capacity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_capacity.Location = new System.Drawing.Point(473, 217);
            this.label_capacity.Name = "label_capacity";
            this.label_capacity.Size = new System.Drawing.Size(129, 21);
            this.label_capacity.TabIndex = 29;
            this.label_capacity.Text = "Сечение (барн):";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(12, 348);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(34, 21);
            this.label_from.TabIndex = 28;
            this.label_from.Text = "ОТ:";
            // 
            // label_graphics
            // 
            this.label_graphics.AutoSize = true;
            this.label_graphics.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_graphics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_graphics.Location = new System.Drawing.Point(693, 271);
            this.label_graphics.Name = "label_graphics";
            this.label_graphics.Size = new System.Drawing.Size(88, 30);
            this.label_graphics.TabIndex = 32;
            this.label_graphics.Text = "График";
            // 
            // label_counting
            // 
            this.label_counting.AutoSize = true;
            this.label_counting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_counting.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_counting.Location = new System.Drawing.Point(691, 8);
            this.label_counting.Name = "label_counting";
            this.label_counting.Size = new System.Drawing.Size(90, 30);
            this.label_counting.TabIndex = 31;
            this.label_counting.Text = "Рассчёт";
            // 
            // textBox_distance
            // 
            this.textBox_distance.Location = new System.Drawing.Point(718, 48);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(254, 20);
            this.textBox_distance.TabIndex = 2;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(56, 372);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(169, 20);
            this.textBox_max.TabIndex = 17;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(56, 348);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(169, 20);
            this.textBox_min.TabIndex = 10;
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve_button.Location = new System.Drawing.Point(475, 154);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(497, 60);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать эффективное сечение неупругих столкновений";
            this.solve_button.UseVisualStyleBackColor = false;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // graphics_button
            // 
            this.graphics_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphics_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphics_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.graphics_button.Location = new System.Drawing.Point(232, 348);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(217, 44);
            this.graphics_button.TabIndex = 9;
            this.graphics_button.Text = "Построить график";
            this.graphics_button.UseVisualStyleBackColor = false;
            this.graphics_button.Click += new System.EventHandler(this.graphics_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(473, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Отношение анодного тока (dI/I, 10^-3):";
            // 
            // textBox_elec
            // 
            this.textBox_elec.Location = new System.Drawing.Point(783, 74);
            this.textBox_elec.Name = "textBox_elec";
            this.textBox_elec.Size = new System.Drawing.Size(189, 20);
            this.textBox_elec.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Давление газов (Па):";
            // 
            // textBox_pressure
            // 
            this.textBox_pressure.Location = new System.Drawing.Point(646, 102);
            this.textBox_pressure.Name = "textBox_pressure";
            this.textBox_pressure.Size = new System.Drawing.Size(326, 20);
            this.textBox_pressure.TabIndex = 49;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(604, 217);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 21);
            this.label_result.TabIndex = 50;
            // 
            // textBox_temperature
            // 
            this.textBox_temperature.Location = new System.Drawing.Point(614, 128);
            this.textBox_temperature.Name = "textBox_temperature";
            this.textBox_temperature.Size = new System.Drawing.Size(358, 20);
            this.textBox_temperature.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(473, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Температура (К):";
            // 
            // textBox_pressure_gr
            // 
            this.textBox_pressure_gr.Location = new System.Drawing.Point(646, 369);
            this.textBox_pressure_gr.Name = "textBox_pressure_gr";
            this.textBox_pressure_gr.Size = new System.Drawing.Size(326, 20);
            this.textBox_pressure_gr.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(473, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Давление газов (Па):";
            // 
            // textBox_elec_gr
            // 
            this.textBox_elec_gr.Location = new System.Drawing.Point(783, 341);
            this.textBox_elec_gr.Name = "textBox_elec_gr";
            this.textBox_elec_gr.Size = new System.Drawing.Size(189, 20);
            this.textBox_elec_gr.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(473, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Отношение анодного тока (dI/I, 10^-3):";
            // 
            // textBox_distance_gr
            // 
            this.textBox_distance_gr.Location = new System.Drawing.Point(718, 315);
            this.textBox_distance_gr.Name = "textBox_distance_gr";
            this.textBox_distance_gr.Size = new System.Drawing.Size(254, 20);
            this.textBox_distance_gr.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(473, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Расстояние катод-сетка (мкм):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Температура (К):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cut.Properties.Resources.collision;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 310);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_pressure_gr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_elec_gr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_distance_gr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_temperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_pressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_elec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_distance);
            this.Controls.Add(this.label_counting);
            this.Controls.Add(this.label_graphics);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_capacity);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_param1_solve);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Эффективное сечение неупругих столкновений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label_param1_solve;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_capacity;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_counting;
        private System.Windows.Forms.TextBox textBox_distance;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_elec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pressure;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_temperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pressure_gr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_elec_gr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_distance_gr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

