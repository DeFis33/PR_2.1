namespace PR2._2
{
    partial class Project
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
            this.condition2 = new System.Windows.Forms.Label();
            this.btnMath1 = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.Button();
            this.decision2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.decision2.SuspendLayout();
            this.SuspendLayout();
            // 
            // condition2
            // 
            this.condition2.AutoSize = true;
            this.condition2.BackColor = System.Drawing.Color.SeaGreen;
            this.condition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition2.ForeColor = System.Drawing.Color.Transparent;
            this.condition2.Location = new System.Drawing.Point(24, 20);
            this.condition2.Name = "condition2";
            this.condition2.Size = new System.Drawing.Size(311, 20);
            this.condition2.TabIndex = 4;
            this.condition2.Text = "Введите числа, чтобы их перемножить:";
            // 
            // btnMath1
            // 
            this.btnMath1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMath1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMath1.Location = new System.Drawing.Point(12, 171);
            this.btnMath1.Name = "btnMath1";
            this.btnMath1.Size = new System.Drawing.Size(171, 47);
            this.btnMath1.TabIndex = 5;
            this.btnMath1.Text = "Рассчитать";
            this.btnMath1.UseVisualStyleBackColor = true;
            this.btnMath1.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(121, 48);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(181, 26);
            this.textBoxInput.TabIndex = 6;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxResult.Location = new System.Drawing.Point(121, 82);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(181, 26);
            this.textBoxResult.TabIndex = 7;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.BackColor = System.Drawing.Color.SeaGreen;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.ForeColor = System.Drawing.Color.Transparent;
            this.input.Location = new System.Drawing.Point(13, 51);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(102, 20);
            this.input.TabIndex = 8;
            this.input.Text = "Ввод чисел:";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.BackColor = System.Drawing.Color.SeaGreen;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2.ForeColor = System.Drawing.Color.Transparent;
            this.result2.Location = new System.Drawing.Point(13, 85);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(93, 20);
            this.result2.TabIndex = 9;
            this.result2.Text = "Результат:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(375, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem,
            this.clear,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.вычислитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation2});
            this.вычислитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // calculation2
            // 
            this.calculation2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.calculation2.ForeColor = System.Drawing.Color.White;
            this.calculation2.Name = "calculation2";
            this.calculation2.Size = new System.Drawing.Size(159, 26);
            this.calculation2.Text = "Рассчитать";
            this.calculation2.Click += new System.EventHandler(this.calculation2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 26);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.info_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(192, 171);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 47);
            this.exit.TabIndex = 11;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // decision2
            // 
            this.decision2.BackColor = System.Drawing.Color.SeaGreen;
            this.decision2.Controls.Add(this.textBoxResult);
            this.decision2.Controls.Add(this.textBoxInput);
            this.decision2.Controls.Add(this.input);
            this.decision2.Controls.Add(this.result2);
            this.decision2.Controls.Add(this.condition2);
            this.decision2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decision2.ForeColor = System.Drawing.Color.White;
            this.decision2.Location = new System.Drawing.Point(12, 39);
            this.decision2.Name = "decision2";
            this.decision2.Size = new System.Drawing.Size(351, 129);
            this.decision2.TabIndex = 13;
            this.decision2.TabStop = false;
            this.decision2.Text = "Решение:";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(375, 227);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.decision2);
            this.Controls.Add(this.btnMath1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(391, 266);
            this.MinimumSize = new System.Drawing.Size(391, 266);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.decision2.ResumeLayout(false);
            this.decision2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label condition2;
        private System.Windows.Forms.Button btnMath1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculation2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox decision2;
    }
}

