using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CalculatorLib;
using static System.Net.Mime.MediaTypeNames;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        // Импортируем функцию AllocConsole из kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        // Импортируем функцию FreeConsole для освобождения консоли (опционально)
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();


        private const int MaxСharacters = 100;
        private bool isResultDisplayed = false;

        public MainForm()
        {
            InitializeComponent();

            // Вызываем AllocConsole для создания консольного окна
            // AllocConsole();
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
                bool isValid = ExpressionValidator.ValidateExpression(txtDisplay.Text, true);
                
                if (!isValid)
                {
                    MessageBox.Show("Не валидное выражение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string expression = txtDisplay.Text.Replace("×", "*").Replace("÷", "/").Replace("−", "-").Replace("^", "^");
                double result = Calculator.Calculate(expression);

                // Очистка дисплея и отображение результата
                txtDisplay.Clear();
                txtDisplay.AppendText(result.ToString().Replace(',', '.'));

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
                string expression = txtDisplay.Text;
                bool substitution = false;

                if ("+×÷−".Contains(text) && "+×÷−".Contains((char)expression[^1]))
                {
                    expression = expression.Substring(0, expression.Length - 1);
                    substitution = true;
                }

                expression += text;

                bool isValid = ExpressionValidator.ValidateExpression(expression, false);

                if (isValid)
                {
                    if (substitution)
                    {
                        txtDisplay.Text = expression;
                    }
                    else
                    {
                        txtDisplay.AppendText(text);
                    }
                }
            }
        }

        // Освобождение консоли при закрытии формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FreeConsole();
            base.OnFormClosing(e);
        }
    }
}
