using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PR2._2
{
    public partial class Project : Form
    {
        private Dictionary<string, int> mydict = new Dictionary<string, int>();

        public Project()
        {
            InitializeComponent();
        }
        private void btnMath_Click(object sender, EventArgs e)
        {
            try
            {
                mydict.Clear();
                string input = textBoxInput.Text.Trim();
                string[] inputs = input.Split(',');

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Введите числа!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxResult.Clear();
                    textBoxInput.Clear();
                    return;
                }
                foreach (string s in inputs)
                {
                    if (Int32.TryParse(s.Trim(), out int value)) mydict.Add("значение" + (mydict.Count + 1), value);
                    else
                    {
                        MessageBox.Show("Введите числа через запятую правильно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxResult.Clear();
                        textBoxInput.Clear();
                        return;
                    }
                }
                int result = 1;
                try
                {
                    checked
                    {
                        foreach (int value in mydict.Values) result *= value;
                    }
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Результат умножения слишком большой!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxResult.Clear();
                    textBoxInput.Clear();
                    return;
                }
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            exit_Click(sender, e);
        }
        private void calculation2_Click(object sender, EventArgs e)
        {
            btnMath_Click(sender, e);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            textBoxInput.Clear();
        }
        private void info_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
    }
}