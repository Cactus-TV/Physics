
namespace Solenoid_2
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
            this.label_diel_pr = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_capacity = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_counting = new System.Windows.Forms.Label();
            this.textBox_diel_pr = new System.Windows.Forms.TextBox();
            this.textBox_param1 = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_param2_solve = new System.Windows.Forms.TextBox();
            this.textBox_param1_solve = new System.Windows.Forms.TextBox();
            this.textBox_param2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_param2_solve = new System.Windows.Forms.Label();
            this.label_param3_solve = new System.Windows.Forms.Label();
            this.textBox_param3_solve = new System.Windows.Forms.TextBox();
            this.textBox_param3 = new System.Windows.Forms.TextBox();
            this.label_param3 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
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
            this.chart.Location = new System.Drawing.Point(10, 355);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(962, 594);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label_param1_solve
            // 
            this.label_param1_solve.AutoSize = true;
            this.label_param1_solve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1_solve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1_solve.Location = new System.Drawing.Point(499, 99);
            this.label_param1_solve.Name = "label_param1_solve";
            this.label_param1_solve.Size = new System.Drawing.Size(100, 21);
            this.label_param1_solve.TabIndex = 5;
            this.label_param1_solve.Text = "Параметр 1:";
            // 
            // label_diel_pr
            // 
            this.label_diel_pr.AutoSize = true;
            this.label_diel_pr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_diel_pr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_diel_pr.Location = new System.Drawing.Point(499, 74);
            this.label_diel_pr.Name = "label_diel_pr";
            this.label_diel_pr.Size = new System.Drawing.Size(317, 21);
            this.label_diel_pr.TabIndex = 3;
            this.label_diel_pr.Text = "Диэлектрическая проницаемость (Ф/м):";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_to.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_to.Location = new System.Drawing.Point(12, 330);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(38, 21);
            this.label_to.TabIndex = 27;
            this.label_to.Text = "ДО:";
            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param1.Location = new System.Drawing.Point(502, 271);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(100, 21);
            this.label_param1.TabIndex = 34;
            this.label_param1.Text = "Параметр 1:";
            // 
            // label_capacity
            // 
            this.label_capacity.AutoSize = true;
            this.label_capacity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_capacity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_capacity.Location = new System.Drawing.Point(501, 213);
            this.label_capacity.Name = "label_capacity";
            this.label_capacity.Size = new System.Drawing.Size(165, 21);
            this.label_capacity.TabIndex = 29;
            this.label_capacity.Text = "Электроёмкость (Ф):";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(12, 306);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(34, 21);
            this.label_from.TabIndex = 28;
            this.label_from.Text = "ОТ:";
            // 
            // label_param2
            // 
            this.label_param2.AutoSize = true;
            this.label_param2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param2.Location = new System.Drawing.Point(502, 300);
            this.label_param2.Name = "label_param2";
            this.label_param2.Size = new System.Drawing.Size(103, 21);
            this.label_param2.TabIndex = 36;
            this.label_param2.Text = "Параметр 2:";
            // 
            // label_graphics
            // 
            this.label_graphics.AutoSize = true;
            this.label_graphics.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_graphics.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_graphics.Location = new System.Drawing.Point(703, 240);
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
            this.label_counting.Location = new System.Drawing.Point(703, 41);
            this.label_counting.Name = "label_counting";
            this.label_counting.Size = new System.Drawing.Size(90, 30);
            this.label_counting.TabIndex = 31;
            this.label_counting.Text = "Рассчёт";
            // 
            // textBox_diel_pr
            // 
            this.textBox_diel_pr.Location = new System.Drawing.Point(822, 75);
            this.textBox_diel_pr.Name = "textBox_diel_pr";
            this.textBox_diel_pr.Size = new System.Drawing.Size(150, 20);
            this.textBox_diel_pr.TabIndex = 2;
            // 
            // textBox_param1
            // 
            this.textBox_param1.Location = new System.Drawing.Point(822, 273);
            this.textBox_param1.Name = "textBox_param1";
            this.textBox_param1.Size = new System.Drawing.Size(150, 20);
            this.textBox_param1.TabIndex = 33;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(56, 329);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(169, 20);
            this.textBox_max.TabIndex = 17;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(56, 305);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(169, 20);
            this.textBox_min.TabIndex = 10;
            // 
            // textBox_param2_solve
            // 
            this.textBox_param2_solve.Location = new System.Drawing.Point(822, 124);
            this.textBox_param2_solve.Name = "textBox_param2_solve";
            this.textBox_param2_solve.Size = new System.Drawing.Size(150, 20);
            this.textBox_param2_solve.TabIndex = 6;
            // 
            // textBox_param1_solve
            // 
            this.textBox_param1_solve.Location = new System.Drawing.Point(822, 99);
            this.textBox_param1_solve.Name = "textBox_param1_solve";
            this.textBox_param1_solve.Size = new System.Drawing.Size(150, 20);
            this.textBox_param1_solve.TabIndex = 4;
            // 
            // textBox_param2
            // 
            this.textBox_param2.Location = new System.Drawing.Point(822, 301);
            this.textBox_param2.Name = "textBox_param2";
            this.textBox_param2.Size = new System.Drawing.Size(150, 20);
            this.textBox_param2.TabIndex = 35;
            // 
            // comboBox
            // 
            this.comboBox.AllowDrop = true;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Длина (м)",
            "Число витков",
            "Сила тока (А)"});
            this.comboBox.Location = new System.Drawing.Point(10, 271);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(435, 29);
            this.comboBox.TabIndex = 26;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.solve_button.Location = new System.Drawing.Point(499, 172);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(473, 38);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать электроёмкость";
            this.solve_button.UseVisualStyleBackColor = false;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // graphics_button
            // 
            this.graphics_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphics_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphics_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.graphics_button.Location = new System.Drawing.Point(231, 305);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(214, 44);
            this.graphics_button.TabIndex = 9;
            this.graphics_button.Text = "Построить график";
            this.graphics_button.UseVisualStyleBackColor = false;
            this.graphics_button.Click += new System.EventHandler(this.graphics_button_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AllowDrop = true;
            this.comboBox_type.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Плоский",
            "Сферический",
            "Цилиндрический"});
            this.comboBox_type.Location = new System.Drawing.Point(651, 4);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(321, 29);
            this.comboBox_type.TabIndex = 37;
            this.comboBox_type.SelectedValueChanged += new System.EventHandler(this.comboBox_type_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Тип конденсатора:";
            // 
            // label_param2_solve
            // 
            this.label_param2_solve.AutoSize = true;
            this.label_param2_solve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param2_solve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param2_solve.Location = new System.Drawing.Point(499, 123);
            this.label_param2_solve.Name = "label_param2_solve";
            this.label_param2_solve.Size = new System.Drawing.Size(103, 21);
            this.label_param2_solve.TabIndex = 39;
            this.label_param2_solve.Text = "Параметр 2:";
            // 
            // label_param3_solve
            // 
            this.label_param3_solve.AutoSize = true;
            this.label_param3_solve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param3_solve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param3_solve.Location = new System.Drawing.Point(499, 147);
            this.label_param3_solve.Name = "label_param3_solve";
            this.label_param3_solve.Size = new System.Drawing.Size(103, 21);
            this.label_param3_solve.TabIndex = 41;
            this.label_param3_solve.Text = "Параметр 3:";
            // 
            // textBox_param3_solve
            // 
            this.textBox_param3_solve.Location = new System.Drawing.Point(822, 149);
            this.textBox_param3_solve.Name = "textBox_param3_solve";
            this.textBox_param3_solve.Size = new System.Drawing.Size(150, 20);
            this.textBox_param3_solve.TabIndex = 40;
            // 
            // textBox_param3
            // 
            this.textBox_param3.Location = new System.Drawing.Point(822, 329);
            this.textBox_param3.Name = "textBox_param3";
            this.textBox_param3.Size = new System.Drawing.Size(150, 20);
            this.textBox_param3.TabIndex = 42;
            // 
            // label_param3
            // 
            this.label_param3.AutoSize = true;
            this.label_param3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_param3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_param3.Location = new System.Drawing.Point(502, 326);
            this.label_param3.Name = "label_param3";
            this.label_param3.Size = new System.Drawing.Size(103, 21);
            this.label_param3.TabIndex = 43;
            this.label_param3.Text = "Параметр 3:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(672, 216);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 15);
            this.label_result.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 261);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_param3);
            this.Controls.Add(this.label_param3);
            this.Controls.Add(this.label_param3_solve);
            this.Controls.Add(this.textBox_param3_solve);
            this.Controls.Add(this.label_param2_solve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_param2);
            this.Controls.Add(this.textBox_param1_solve);
            this.Controls.Add(this.textBox_param2_solve);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_param1);
            this.Controls.Add(this.textBox_diel_pr);
            this.Controls.Add(this.label_counting);
            this.Controls.Add(this.label_graphics);
            this.Controls.Add(this.label_param2);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_capacity);
            this.Controls.Add(this.label_param1);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_diel_pr);
            this.Controls.Add(this.label_param1_solve);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Конденсатор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label_param1_solve;
        private System.Windows.Forms.Label label_diel_pr;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_capacity;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_counting;
        private System.Windows.Forms.TextBox textBox_diel_pr;
        private System.Windows.Forms.TextBox textBox_param1;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_param2_solve;
        private System.Windows.Forms.TextBox textBox_param1_solve;
        private System.Windows.Forms.TextBox textBox_param2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_param2_solve;
        private System.Windows.Forms.Label label_param3_solve;
        private System.Windows.Forms.TextBox textBox_param3_solve;
        private System.Windows.Forms.TextBox textBox_param3;
        private System.Windows.Forms.Label label_param3;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

