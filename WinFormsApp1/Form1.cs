using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear(); // Очищаем ListBox

            if (int.TryParse(txtN.Text, out int n) && n > 0)
            {
                var fibonacciNumbers = GetFibonacciNumbers(n);

                foreach (var num in fibonacciNumbers)
                {
                    listBox.Items.Add(num);
                }

                if (checkNum.Checked)
                {
                    txtNum.Text = fibonacciNumbers.Count.ToString();
                }

                if (checkSum.Checked)
                {
                    txtSum.Text = GetFibonacciSum(fibonacciNumbers).ToString();
                }
            }
            else
            {
                MessageBox.Show("Введите натуральное число в поле N.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<int> GetFibonacciNumbers(int max)
        {
            var result = new List<int>();
            int a = 0, b = 1;

            while (a <= max)
            {
                result.Add(a);
                int temp = a + b;
                a = b;
                b = temp;
            }

            return result;
        }

        private int GetFibonacciSum(List<int> numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Этот метод оставлен пустым
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out _))
            {
                MessageBox.Show("Введите только натуральные числа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                MessageBox.Show($"Вы выбрали число {listBox.SelectedItem}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkNum_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkNum.Checked)
            {
                txtNum.Clear();
            }
        }

        private void checkSum_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkSum.Checked)
            {
                txtSum.Clear();
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            // Автоматическое поведение не требуется
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            // Автоматическое поведение не требуется
        }
    }
}
