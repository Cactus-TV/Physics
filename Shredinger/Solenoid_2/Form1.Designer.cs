
using System;

namespace Energy
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
            this.textBox_level = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_wide = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_mass_gr = new System.Windows.Forms.TextBox();
            this.textBox_level_gr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.chart.Location = new System.Drawing.Point(10, 344);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(962, 605);
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
            this.label_param1_solve.Size = new System.Drawing.Size(209, 21);
            this.label_param1_solve.TabIndex = 5;
            this.label_param1_solve.Text = "Энергетический уровень: ";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_to.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_to.Location = new System.Drawing.Point(12, 319);
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
            this.label_capacity.Location = new System.Drawing.Point(473, 203);
            this.label_capacity.Name = "label_capacity";
            this.label_capacity.Size = new System.Drawing.Size(188, 21);
            this.label_capacity.TabIndex = 29;
            this.label_capacity.Text = "Энергия частицы (Дж): ";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(12, 294);
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
            this.label_graphics.Location = new System.Drawing.Point(186, 169);
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
            // textBox_level
            // 
            this.textBox_level.Location = new System.Drawing.Point(688, 48);
            this.textBox_level.Name = "textBox_level";
            this.textBox_level.Size = new System.Drawing.Size(284, 20);
            this.textBox_level.TabIndex = 2;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(56, 318);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(169, 20);
            this.textBox_max.TabIndex = 17;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(56, 294);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(169, 20);
            this.textBox_min.TabIndex = 10;
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve_button.Location = new System.Drawing.Point(473, 128);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(501, 60);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать энергию частицы";
            this.solve_button.UseVisualStyleBackColor = false;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // graphics_button
            // 
            this.graphics_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphics_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphics_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.graphics_button.Location = new System.Drawing.Point(232, 294);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(235, 44);
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
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Масса частицы (кг * 10^-31):";
            // 
            // textBox_mass
            // 
            this.textBox_mass.Location = new System.Drawing.Point(688, 74);
            this.textBox_mass.Name = "textBox_mass";
            this.textBox_mass.Size = new System.Drawing.Size(284, 20);
            this.textBox_mass.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(473, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ширина потенциальной ямы (мм):";
            // 
            // textBox_wide
            // 
            this.textBox_wide.Location = new System.Drawing.Point(753, 102);
            this.textBox_wide.Name = "textBox_wide";
            this.textBox_wide.Size = new System.Drawing.Size(219, 20);
            this.textBox_wide.TabIndex = 49;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(682, 203);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 21);
            this.label_result.TabIndex = 50;
            // 
            // textBox_mass_gr
            // 
            this.textBox_mass_gr.Location = new System.Drawing.Point(237, 235);
            this.textBox_mass_gr.Name = "textBox_mass_gr";
            this.textBox_mass_gr.Size = new System.Drawing.Size(230, 20);
            this.textBox_mass_gr.TabIndex = 60;
            // 
            // textBox_level_gr
            // 
            this.textBox_level_gr.Location = new System.Drawing.Point(227, 208);
            this.textBox_level_gr.Name = "textBox_level_gr";
            this.textBox_level_gr.Size = new System.Drawing.Size(240, 20);
            this.textBox_level_gr.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ширина потенциальной ямы (мм):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Масса частицы (кг * 10^-31):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Энергетический уровень: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Energy.Properties.Resources.Schrödinger_equation_wave_packet;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_mass_gr);
            this.Controls.Add(this.textBox_level_gr);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_wide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_mass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_level);
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
            this.Text = "Энергия частицы (через уравнение Шрёдингера)";
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
        private System.Windows.Forms.TextBox textBox_level;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_wide;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_mass_gr;
        private System.Windows.Forms.TextBox textBox_level_gr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

