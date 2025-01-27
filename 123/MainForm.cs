using System;
using System.Windows.Forms;
using CalculatorLib;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private const int MaxСharacters = 100;
        private bool isResultDisplayed = false;

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
            AppendToDisplay("^(2)");
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            AppendToDisplay("^(");
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

        // Обработка нажатия логарифма
        private void BtnLog_Click(object sender, EventArgs e)
        {
            AppendToDisplay("ln(");
        }

        // Обработка нажатия равно
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtDisplay.Text.Replace("×", "*").Replace("÷", "/").Replace("−", "-").Replace("^", "^");
                double result = 12345.6789;

                // Очистка дисплея и отображение результата
                txtDisplay.Clear();
                txtDisplay.AppendText(result.ToString());

                isResultDisplayed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка вычисления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для добавления текста в дисплей с поддержкой переноса строк
        private void AppendToDisplay(string text)
        {
            if (isResultDisplayed && !char.IsDigit(text, 0) && text != ".")
            {
                // Если был показан результат и пользователь нажимает операцию, оставляем результат
                isResultDisplayed = false;
            }
            else if (isResultDisplayed)
            {
                // Если был показан результат и пользователь начинает вводить новое число, очищаем дисплей
                txtDisplay.Clear();
                isResultDisplayed = false;
            }

            // Проверка количества символов
            if (txtDisplay.Text.Length > MaxСharacters)
            {
                // Уведомление пользователя
                MessageBox.Show("Достигнут лимит длины операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string expression = txtDisplay.Text + text;
                bool isValid = ExpressionValidator.ValidateExpression(expression, false);

                if (isValid)
                {
                    txtDisplay.AppendText(text);
                }
            }
        }
    }
}
