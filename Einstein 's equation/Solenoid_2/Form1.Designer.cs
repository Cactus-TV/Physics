
using System;

namespace einstein_equation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_param1_solve = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_energy = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_counting = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_work = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_param1_gr = new System.Windows.Forms.TextBox();
            this.label_param1_gr = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.button_colour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_final = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea5.Name = "chartarea";
            this.chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart.Legends.Add(legend5);
            this.chart.Location = new System.Drawing.Point(12, 400);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(962, 549);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label_param1_solve
            // 
            this.label_param1_solve.AutoSize = true;
            this.label_param1_solve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1_solve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1_solve.Location = new System.Drawing.Point(533, 48);
            this.label_param1_solve.Name = "label_param1_solve";
            this.label_param1_solve.Size = new System.Drawing.Size(150, 21);
            this.label_param1_solve.TabIndex = 5;
            this.label_param1_solve.Text = "Длина волны (нм):";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_to.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_to.Location = new System.Drawing.Point(534, 368);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(38, 21);
            this.label_to.TabIndex = 27;
            this.label_to.Text = "ДО:";
            // 
            // label_energy
            // 
            this.label_energy.AutoSize = true;
            this.label_energy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_energy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_energy.Location = new System.Drawing.Point(534, 164);
            this.label_energy.Name = "label_energy";
            this.label_energy.Size = new System.Drawing.Size(296, 21);
            this.label_energy.TabIndex = 29;
            this.label_energy.Text = "Кинетическая энергия (Дж * 10^(-19)):";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(534, 344);
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
            this.label_graphics.Location = new System.Drawing.Point(731, 239);
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
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(765, 49);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(183, 20);
            this.textBox_length.TabIndex = 2;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(582, 368);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(169, 20);
            this.textBox_max.TabIndex = 17;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(582, 344);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(169, 20);
            this.textBox_min.TabIndex = 10;
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solve_button.Location = new System.Drawing.Point(533, 101);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(439, 60);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать кинетическую энергию фотоэлектронов\r\n";
            this.solve_button.UseVisualStyleBackColor = false;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // graphics_button
            // 
            this.graphics_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphics_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphics_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.graphics_button.Location = new System.Drawing.Point(760, 344);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(214, 44);
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
            this.label1.Location = new System.Drawing.Point(534, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Работа выхода (Дж 10^(-19)):";
            // 
            // textBox_work
            // 
            this.textBox_work.Location = new System.Drawing.Point(765, 75);
            this.textBox_work.Name = "textBox_work";
            this.textBox_work.Size = new System.Drawing.Size(207, 20);
            this.textBox_work.TabIndex = 47;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(779, 220);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 21);
            this.label_result.TabIndex = 50;
            // 
            // textBox_param1_gr
            // 
            this.textBox_param1_gr.Location = new System.Drawing.Point(765, 279);
            this.textBox_param1_gr.Name = "textBox_param1_gr";
            this.textBox_param1_gr.Size = new System.Drawing.Size(207, 20);
            this.textBox_param1_gr.TabIndex = 51;
            // 
            // label_param1_gr
            // 
            this.label_param1_gr.AutoSize = true;
            this.label_param1_gr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1_gr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1_gr.Location = new System.Drawing.Point(533, 279);
            this.label_param1_gr.Name = "label_param1_gr";
            this.label_param1_gr.Size = new System.Drawing.Size(225, 21);
            this.label_param1_gr.TabIndex = 52;
            this.label_param1_gr.Text = "Работа выхода (Дж 10^(-19)):";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Red;
            this.colorDialog.SolidColorOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(533, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Длина волны световой волны (нм):";
            // 
            // button_colour
            // 
            this.button_colour.BackgroundImage = global::einstein_equation.Properties.Resources.color_picker;
            this.button_colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_colour.Location = new System.Drawing.Point(954, 49);
            this.button_colour.Name = "button_colour";
            this.button_colour.Size = new System.Drawing.Size(20, 20);
            this.button_colour.TabIndex = 57;
            this.button_colour.UseVisualStyleBackColor = true;
            this.button_colour.Click += new System.EventHandler(this.button_colour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::einstein_equation.Properties.Resources.photoelectric_effect;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 385);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_final.Location = new System.Drawing.Point(836, 164);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(49, 21);
            this.label_final.TabIndex = 58;
            this.label_final.Text = "ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label_final);
            this.Controls.Add(this.button_colour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_param1_gr);
            this.Controls.Add(this.label_param1_gr);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_work);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.label_counting);
            this.Controls.Add(this.label_graphics);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_energy);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_param1_solve);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Уравнение Эйнштейна для фотоэффекта";
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
        private System.Windows.Forms.Label label_energy;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_counting;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_work;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_param1_gr;
        private System.Windows.Forms.Label label_param1_gr;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_colour;
        private System.Windows.Forms.Label label_final;
    }
}

