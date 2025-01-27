using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработка нажатия цифр
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                AppendToDisplay(btn.Text);
            }
        }

        // Обработка нажатия десятичной точки
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            AppendToDisplay(".");
        }

        // Обработка нажатия операций
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AppendToDisplay("+");
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            AppendToDisplay("−");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AppendToDisplay("×");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            AppendToDisplay("÷");
        }

        private void BtnOpenParen_Click(object sender, EventArgs e)
        {
            AppendToDisplay("(");
        }

        private void BtnCloseParen_Click(object sender, EventArgs e)
        {
            AppendToDisplay(")");
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            AppendToDisplay("√(");
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            AppendToDisplay("^2");
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            AppendToDisplay("^");
        }

        // Обработка очистки дисплея
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Обработка удаления последнего символа
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        // Обработка изменения знака числа
        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Поиск последнего числа в строке
                int lastOperatorIndex = txtDisplay.Text.LastIndexOfAny(new char[] { '+', '-', '×', '÷', '^' });
                if (lastOperatorIndex == -1)
                {
                    lastOperatorIndex = 0;
                }
                else
                {
                    lastOperatorIndex += 1;
                }

                string number = txtDisplay.Text.Substring(lastOperatorIndex).Trim();
                if (double.TryParse(number, out double result))
                {
                    result = -result;
                    txtDisplay.Text = txtDisplay.Text.Substring(0, lastOperatorIndex) + result.ToString();
                }
            }
        }

        // Обработка нажатия равно
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtDisplay.Text.Replace("×", "*").Replace("÷", "/").Replace("−", "-").Replace("^", "^");
                double result = 12345.6789;
                txtDisplay.Text += Environment.NewLine + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка вычисления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для добавления текста в дисплей с поддержкой переноса строк
        private void AppendToDisplay(string text)
        {
            // Проверка длины строки и добавление переноса, если необходимо
            if (txtDisplay.Text.Length > 1000) // Порог длины можно настроить
            {
                txtDisplay.Text = txtDisplay.Text.Substring(txtDisplay.Text.Length - 1000);
            }
            txtDisplay.AppendText(text);
        }
    }
}
