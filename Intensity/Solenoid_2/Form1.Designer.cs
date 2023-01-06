
using System;

namespace Intensity
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_param1_solve = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_capacity = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_counting = new System.Windows.Forms.Label();
            this.textBox_energy = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_radius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_param2_gr = new System.Windows.Forms.TextBox();
            this.label_param2_gr = new System.Windows.Forms.Label();
            this.textBox_param1_gr = new System.Windows.Forms.TextBox();
            this.label_param1_gr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "chartarea";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
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
            this.label_param1_solve.Location = new System.Drawing.Point(574, 48);
            this.label_param1_solve.Name = "label_param1_solve";
            this.label_param1_solve.Size = new System.Drawing.Size(116, 21);
            this.label_param1_solve.TabIndex = 5;
            this.label_param1_solve.Text = "Энергия (Дж):";
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
            this.label_capacity.Location = new System.Drawing.Point(574, 201);
            this.label_capacity.Name = "label_capacity";
            this.label_capacity.Size = new System.Drawing.Size(199, 21);
            this.label_capacity.TabIndex = 29;
            this.label_capacity.Text = "Интенсивность (Вт/м^2):";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(12, 349);
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
            this.label_graphics.Location = new System.Drawing.Point(731, 281);
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
            this.label_counting.Location = new System.Drawing.Point(731, 9);
            this.label_counting.Name = "label_counting";
            this.label_counting.Size = new System.Drawing.Size(90, 30);
            this.label_counting.TabIndex = 31;
            this.label_counting.Text = "Рассчёт";
            // 
            // textBox_energy
            // 
            this.textBox_energy.Location = new System.Drawing.Point(736, 49);
            this.textBox_energy.Name = "textBox_energy";
            this.textBox_energy.Size = new System.Drawing.Size(236, 20);
            this.textBox_energy.TabIndex = 2;
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
            // comboBox
            // 
            this.comboBox.AllowDrop = true;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Энергия (Дж)",
            "Радиус (м)",
            "Время (с)"});
            this.comboBox.Location = new System.Drawing.Point(11, 317);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(435, 29);
            this.comboBox.TabIndex = 26;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve_button.Location = new System.Drawing.Point(572, 132);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(400, 60);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать интенсивность сферической волны\r\n";
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
            this.graphics_button.Size = new System.Drawing.Size(214, 44);
            this.graphics_button.TabIndex = 9;
            this.graphics_button.Text = "Построить график";
            this.graphics_button.UseVisualStyleBackColor = false;
            this.graphics_button.Click += new System.EventHandler(this.graphics_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Intensity.Properties.Resources.Spherical_Wave;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 351);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(574, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Радиус (м):";
            // 
            // textBox_radius
            // 
            this.textBox_radius.Location = new System.Drawing.Point(736, 75);
            this.textBox_radius.Name = "textBox_radius";
            this.textBox_radius.Size = new System.Drawing.Size(236, 20);
            this.textBox_radius.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(574, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Время (с):";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(736, 104);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(236, 20);
            this.textBox_time.TabIndex = 49;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(779, 201);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 21);
            this.label_result.TabIndex = 50;
            // 
            // textBox_param2_gr
            // 
            this.textBox_param2_gr.Location = new System.Drawing.Point(736, 368);
            this.textBox_param2_gr.Name = "textBox_param2_gr";
            this.textBox_param2_gr.Size = new System.Drawing.Size(234, 20);
            this.textBox_param2_gr.TabIndex = 54;
            // 
            // label_param2_gr
            // 
            this.label_param2_gr.AutoSize = true;
            this.label_param2_gr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param2_gr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param2_gr.Location = new System.Drawing.Point(574, 369);
            this.label_param2_gr.Name = "label_param2_gr";
            this.label_param2_gr.Size = new System.Drawing.Size(103, 21);
            this.label_param2_gr.TabIndex = 53;
            this.label_param2_gr.Text = "Параметр 2:";
            // 
            // textBox_param1_gr
            // 
            this.textBox_param1_gr.Location = new System.Drawing.Point(736, 339);
            this.textBox_param1_gr.Name = "textBox_param1_gr";
            this.textBox_param1_gr.Size = new System.Drawing.Size(234, 20);
            this.textBox_param1_gr.TabIndex = 51;
            // 
            // label_param1_gr
            // 
            this.label_param1_gr.AutoSize = true;
            this.label_param1_gr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1_gr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1_gr.Location = new System.Drawing.Point(574, 336);
            this.label_param1_gr.Name = "label_param1_gr";
            this.label_param1_gr.Size = new System.Drawing.Size(100, 21);
            this.label_param1_gr.TabIndex = 52;
            this.label_param1_gr.Text = "Параметр 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.textBox_param2_gr);
            this.Controls.Add(this.label_param2_gr);
            this.Controls.Add(this.textBox_param1_gr);
            this.Controls.Add(this.label_param1_gr);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_radius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_energy);
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
            this.Text = "Интенсивность сферической волны";
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
        private System.Windows.Forms.TextBox textBox_energy;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_radius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_param2_gr;
        private System.Windows.Forms.Label label_param2_gr;
        private System.Windows.Forms.TextBox textBox_param1_gr;
        private System.Windows.Forms.Label label_param1_gr;
    }
}

