
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
            this.pictureBox_gif = new System.Windows.Forms.PictureBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_length = new System.Windows.Forms.Label();
            this.label_ampers = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_induction = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_counting = new System.Windows.Forms.Label();
            this.label_otvet = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_param1 = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_ampers = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_param2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.solve_button = new System.Windows.Forms.Button();
            this.graphics_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "chartarea";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(10, 375);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(779, 408);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // pictureBox_gif
            // 
            this.pictureBox_gif.ErrorImage = null;
            this.pictureBox_gif.Image = global::Solenoid.Properties.Resources.IMG_9131;
            this.pictureBox_gif.InitialImage = global::Solenoid.Properties.Resources.IMG_9131;
            this.pictureBox_gif.Location = new System.Drawing.Point(10, 3);
            this.pictureBox_gif.Name = "pictureBox_gif";
            this.pictureBox_gif.Size = new System.Drawing.Size(479, 369);
            this.pictureBox_gif.TabIndex = 1;
            this.pictureBox_gif.TabStop = false;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_amount.Location = new System.Drawing.Point(495, 60);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(119, 21);
            this.label_amount.TabIndex = 5;
            this.label_amount.Text = "Число витков:";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_length.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_length.Location = new System.Drawing.Point(495, 35);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(88, 21);
            this.label_length.TabIndex = 3;
            this.label_length.Text = "Длина (м):";
            // 
            // label_ampers
            // 
            this.label_ampers.AutoSize = true;
            this.label_ampers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_ampers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_ampers.Location = new System.Drawing.Point(495, 85);
            this.label_ampers.Name = "label_ampers";
            this.label_ampers.Size = new System.Drawing.Size(113, 21);
            this.label_ampers.TabIndex = 7;
            this.label_ampers.Text = "Сила тока (А):";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_to.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_to.Location = new System.Drawing.Point(495, 258);
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
            this.label_param1.Location = new System.Drawing.Point(495, 282);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(100, 21);
            this.label_param1.TabIndex = 34;
            this.label_param1.Text = "Параметр 1:";
            // 
            // label_induction
            // 
            this.label_induction.AutoSize = true;
            this.label_induction.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_induction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_induction.Location = new System.Drawing.Point(495, 146);
            this.label_induction.Name = "label_induction";
            this.label_induction.Size = new System.Drawing.Size(203, 21);
            this.label_induction.TabIndex = 29;
            this.label_induction.Text = "Магнитная индукция (Тл):";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_from.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_from.Location = new System.Drawing.Point(495, 234);
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
            this.label_param2.Location = new System.Drawing.Point(495, 306);
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
            this.label_graphics.Location = new System.Drawing.Point(605, 170);
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
            this.label_counting.Location = new System.Drawing.Point(604, 2);
            this.label_counting.Name = "label_counting";
            this.label_counting.Size = new System.Drawing.Size(90, 30);
            this.label_counting.TabIndex = 31;
            this.label_counting.Text = "Рассчёт";
            // 
            // label_otvet
            // 
            this.label_otvet.AutoSize = true;
            this.label_otvet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_otvet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_otvet.Location = new System.Drawing.Point(701, 145);
            this.label_otvet.Name = "label_otvet";
            this.label_otvet.Size = new System.Drawing.Size(0, 21);
            this.label_otvet.TabIndex = 30;
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(589, 34);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(200, 20);
            this.textBox_length.TabIndex = 2;
            // 
            // textBox_param1
            // 
            this.textBox_param1.Location = new System.Drawing.Point(620, 281);
            this.textBox_param1.Name = "textBox_param1";
            this.textBox_param1.Size = new System.Drawing.Size(169, 20);
            this.textBox_param1.TabIndex = 33;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(539, 257);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(250, 20);
            this.textBox_max.TabIndex = 17;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(539, 233);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(250, 20);
            this.textBox_min.TabIndex = 10;
            // 
            // textBox_ampers
            // 
            this.textBox_ampers.Location = new System.Drawing.Point(614, 84);
            this.textBox_ampers.Name = "textBox_ampers";
            this.textBox_ampers.Size = new System.Drawing.Size(175, 20);
            this.textBox_ampers.TabIndex = 6;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(620, 59);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(169, 20);
            this.textBox_amount.TabIndex = 4;
            // 
            // textBox_param2
            // 
            this.textBox_param2.Location = new System.Drawing.Point(620, 305);
            this.textBox_param2.Name = "textBox_param2";
            this.textBox_param2.Size = new System.Drawing.Size(169, 20);
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
            this.comboBox.Location = new System.Drawing.Point(495, 202);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(294, 29);
            this.comboBox.TabIndex = 26;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // solve_button
            // 
            this.solve_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.solve_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.solve_button.Location = new System.Drawing.Point(495, 108);
            this.solve_button.Name = "solve_button";
            this.solve_button.Size = new System.Drawing.Size(294, 38);
            this.solve_button.TabIndex = 0;
            this.solve_button.Text = "Посчитать индукцию";
            this.solve_button.UseVisualStyleBackColor = false;
            this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
            // 
            // graphics_button
            // 
            this.graphics_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphics_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphics_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.graphics_button.Location = new System.Drawing.Point(495, 329);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(294, 40);
            this.graphics_button.TabIndex = 9;
            this.graphics_button.Text = "Построить график";
            this.graphics_button.UseVisualStyleBackColor = false;
            this.graphics_button.Click += new System.EventHandler(this.graphics_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 781);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.solve_button);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_param2);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_ampers);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_param1);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.label_otvet);
            this.Controls.Add(this.label_counting);
            this.Controls.Add(this.label_graphics);
            this.Controls.Add(this.label_param2);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_induction);
            this.Controls.Add(this.label_param1);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_ampers);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.pictureBox_gif);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 820);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 820);
            this.Name = "Form1";
            this.Text = "Соленоид";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox pictureBox_gif;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_ampers;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_induction;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_counting;
        private System.Windows.Forms.Label label_otvet;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_param1;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_ampers;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_param2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button solve_button;
        private System.Windows.Forms.Button graphics_button;
    }
}

