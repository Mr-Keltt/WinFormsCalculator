using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalculatorLib
{
    /// <summary>
    /// Статический класс для валидации математических выражений.
    /// </summary>
    public static class ExpressionValidator
    {
        /// <summary>
        /// Метод для записи сообщений в консоль.
        /// </summary>
        /// <param name="message">Сообщение для записи.</param>
        private static void Log(string message)
        {
            try
            {
                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            }
            catch
            {
                // Если возникла ошибка при записи лога, пропускаем её.
            }
        }

        /// <summary>
        /// Нормализует выражение, заменяя Unicode символы на стандартные ASCII.
        /// </summary>
        /// <param name="expression">Выражение для нормализации.</param>
        /// <returns>Нормализованное выражение.</returns>
        private static string NormalizeExpression(string expression)
        {
            return expression.Replace("−", "-")
                             .Replace("×", "*")
                             .Replace("÷", "/")
                             .Replace("√", "sqrt")
                             .Replace("^", "^"); // если планируется поддержка степени
        }

        /// <summary>
        /// Валидатор математического выражения.
        /// </summary>
        /// <param name="expression">Математическое выражение для проверки.</param>
        /// <param name="isComplete">Флаг, указывающий, является ли выражение завершённым.</param>
        /// <returns>Возвращает true, если выражение валидно, иначе false.</returns>
        public static bool ValidateExpression(string expression, bool isComplete)
        {
            Log($"Начало валидации выражения: \"{expression}\", isComplete: {isComplete}");

            if (string.IsNullOrWhiteSpace(expression))
            {
                Log("Выражение пустое или содержит только пробелы. Возвращаем false.");
                return false;
            }

            // Нормализация выражения
            expression = NormalizeExpression(expression);
            Log($"После нормализации: \"{expression}\"");

            // Удаляем все пробелы из выражения для упрощения обработки
            expression = expression.Replace(" ", "");
            Log($"После удаления пробелов: \"{expression}\"");

            // Проверка, является ли выражение одним числом или отрицательным числом
            if (IsSingleNumber(expression))
            {
                Log("Выражение является одиночным числом. Возвращаем true.");
                return true;
            }

            // Дополнительная проверка: если выражение является одиночным '-', и не завершено
            if (!isComplete && expression == "-")
            {
                Log("Выражение является одиночным минусом и неполным. Возвращаем true.");
                return true;
            }

            // Проверка баланса скобок и правильного размещения содержимого внутри них
            if (!AreParenthesesProperlyPlaced(expression, isComplete))
            {
                Log("Баланс скобок нарушен или содержимое внутри скобок некорректно. Возвращаем false.");
                return false;
            }

            // Инициализация переменных для отслеживания состояния
            bool lastWasOperator = false;
            bool lastWasOpenParen = false;
            bool lastWasFunction = false;
            bool hasContentInsideCurrentParen = false;

            Stack<char> parenthesesStack = new Stack<char>();

            // Переменная для отслеживания позиции в выражении
            int i = 0;

            // Флаг для отслеживания наличия десятичной точки в текущем числе
            bool hasDecimalPoint = false;

            while (i < expression.Length)
            {
                char current = expression[i];
                char? previous = i > 0 ? (char?)expression[i - 1] : null;
                char? next = i < expression.Length - 1 ? (char?)expression[i + 1] : null;

                Log($"Итерация {i + 1}/{expression.Length}: текущий символ '{current}'");

                // Обработка функций: ln, sqrt и другие
                if (IsFunctionStart(expression, i, out string functionName))
                {
                    Log($"Обнаружена функция '{functionName}'");

                    // Проверка, что перед функцией стоит оператор, '(' или ничего
                    if (i > 0)
                    {
                        if (!(IsOperator(previous.GetValueOrDefault()) || previous == '('))
                        {
                            Log($"Перед функцией '{functionName}' стоит недопустимый символ '{previous ?? ' '}'. Возвращаем false.");
                            return false;
                        }
                        else
                        {
                            Log($"Перед функцией '{functionName}' стоит допустимый символ '{previous.Value}'.");
                        }
                    }

                    // Проверка, что после функции идет '('
                    int functionLength = functionName.Length;
                    if (i + functionLength >= expression.Length || expression[i + functionLength] != '(')
                    {
                        Log($"После функции '{functionName}' отсутствует '('. Возвращаем false.");
                        return false;
                    }

                    // Добавляем в стек открывающую скобку функции
                    parenthesesStack.Push('(');
                    Log($"Добавили '(' в стек скобок. Текущий размер стека: {parenthesesStack.Count}");

                    lastWasFunction = true;
                    lastWasOperator = false;
                    lastWasOpenParen = false;

                    // Перемещаем индекс после имени функции
                    i += functionLength;
                    hasContentInsideCurrentParen = false;
                    i++; // Перейти к символу после '('
                    continue;
                }

                // Обработка открывающей скобки '('
                if (current == '(')
                {
                    Log("Обнаружена открывающая скобка '('");

                    // Проверка, что перед '(' не стоит цифра без оператора
                    if (previous.HasValue && IsDigit(previous.Value))
                    {
                        Log($"Перед '(' стоит цифра '{previous.Value}', что недопустимо. Требуется оператор или '(' перед '('. Возвращаем false.");
                        return false;
                    }

                    parenthesesStack.Push('(');
                    Log($"Добавили '(' в стек скобок. Текущий размер стека: {parenthesesStack.Count}");

                    lastWasOpenParen = true;
                    lastWasOperator = false;
                    hasContentInsideCurrentParen = false;
                    i++;
                    continue;
                }

                // Обработка закрывающей скобки ')'
                if (current == ')')
                {
                    Log("Обнаружена закрывающая скобка ')'");

                    // Проверка, что стек не пуст и последняя открытая скобка соответствует
                    if (parenthesesStack.Count == 0)
                    {
                        Log("Закрывающая скобка ')' без соответствующей открывающей скобки. Возвращаем false.");
                        return false;
                    }

                    parenthesesStack.Pop();
                    Log($"Удалили '(' из стека скобок. Текущий размер стека: {parenthesesStack.Count}");

                    // Проверка, что перед ')' стоит число или другая ')'
                    if (!(IsDigit(previous.GetValueOrDefault()) || previous == ')'))
                    {
                        Log($"Перед ')' стоит недопустимый символ '{previous ?? ' '}'. Возвращаем false.");
                        return false;
                    }

                    // Проверка, что после ')' стоит оператор, другая ')' или конец выражения
                    if (isComplete)
                    {
                        if (next.HasValue && !(IsOperator(next.Value) || next == ')'))
                        {
                            Log($"После ')' стоит недопустимый символ '{next.Value}'. Возвращаем false.");
                            return false;
                        }
                        else
                        {
                            Log($"После ')' стоит допустимый символ '{next ?? ' '}'.");
                        }
                    }
                    else
                    {
                        if (next.HasValue && !(IsOperator(next.Value) || next == ')'))
                        {
                            Log($"После ')' стоит недопустимый символ '{next.Value}'. Возвращаем false.");
                            return false;
                        }
                        else
                        {
                            Log($"После ')' стоит допустимый символ '{next ?? ' '}'.");
                        }
                    }

                    lastWasOperator = false;
                    lastWasOpenParen = false;
                    hasContentInsideCurrentParen = true;
                    i++;
                    continue;
                }

                // Обработка операторов +, -, *, /, ×, ÷, √, ^
                if (IsOperator(current))
                {
                    Log($"Обнаружен оператор '{current}'");

                    // Специфическая проверка для "^"
                    if (current == '^')
                    {
                        if (previous == '(')
                        {
                            Log($"Перед оператором '^' не может стоять '('. Возвращаем false.");
                            return false;
                        }
                    }

                    // Запрещаем операторы после '(' кроме унарного минуса '-'
                    if (previous == '(' && current != '-')
                    {
                        Log($"После '(' может стоять только '-', но найден '{current}'. Возвращаем false.");
                        return false;
                    }

                    // Обработка унарного минуса
                    if (current == '-' && (i == 0 || previous == '(' || IsOperator(previous.Value)))
                    {
                        // Унарный минус допускается
                        Log("Разрешён унарный минус.");
                    }
                    else
                    {
                        // Проверка, что перед оператором стоит число, закрывающая скобка или функция
                        if (!(previous.HasValue && (IsDigit(previous.Value) || previous.Value == ')' || lastWasFunction)))
                        {
                            Log($"Перед оператором '{current}' стоит недопустимый символ '{previous.Value}'. Возвращаем false.");
                            return false;
                        }
                    }

                    // Проверка, что после оператора стоит число, открывающая скобка или функция
                    if (isComplete)
                    {
                        if (!(next.HasValue && (IsDigit(next.Value) || next.Value == '(' || IsFunctionStart(expression, i + 1, out _))))
                        {
                            Log($"После оператора '{current}' стоит недопустимый символ '{next ?? ' '}'. Возвращаем false.");
                            return false;
                        }
                        else
                        {
                            Log($"После оператора '{current}' стоит допустимый символ '{next ?? ' '}'.");
                        }
                    }
                    else
                    {
                        if (next.HasValue && !(IsDigit(next.Value) || next.Value == '(' || IsFunctionStart(expression, i + 1, out _)))
                        {
                            Log($"После оператора '{current}' стоит недопустимый символ '{next.Value}'. Возвращаем false.");
                            return false;
                        }
                        else
                        {
                            Log($"После оператора '{current}' стоит допустимый символ '{next ?? ' '}'.");
                        }
                    }

                    // Проверка, что два оператора не идут подряд (кроме унарного минуса)
                    if (lastWasOperator && !(current == '-' && (i == 0 || previous == '(' || IsOperator(previous.Value))))
                    {
                        Log($"Два оператора подряд '{current}'. Возвращаем false.");
                        return false;
                    }

                    // Сброс флага наличия десятичной точки после оператора
                    hasDecimalPoint = false;

                    lastWasOperator = true;
                    lastWasOpenParen = false;
                    hasContentInsideCurrentParen = false;
                    i++;
                    continue;
                }

                // Обработка десятичной точки '.'
                if (current == '.')
                {
                    Log("Обнаружена десятичная точка '.'");

                    // Проверка, что перед '.' стоит число
                    if (!(previous.HasValue && IsDigit(previous.Value)))
                    {
                        Log($"Перед '.' стоит недопустимый символ '{previous ?? ' '}'. Возвращаем false.");
                        return false;
                    }

                    // Если выражение завершено, после '.' должна стоять цифра
                    if (isComplete)
                    {
                        if (!(next.HasValue && IsDigit(next.Value)))
                        {
                            Log($"После '.' стоит недопустимый символ '{next ?? ' '}'. Возвращаем false.");
                            return false;
                        }
                    }
                    else
                    {
                        // Если выражение не завершено, после '.' может стоять цифра или ничего
                        if (next.HasValue && !IsDigit(next.Value))
                        {
                            Log($"После '.' стоит недопустимый символ '{next.Value}'. Возвращаем false.");
                            return false;
                        }
                    }

                    // Проверка, что в текущем числе еще нет точки
                    if (hasDecimalPoint)
                    {
                        Log("Множественные точки в числе. Возвращаем false.");
                        return false;
                    }

                    hasDecimalPoint = true;
                    lastWasOperator = false;
                    lastWasOpenParen = false;
                    hasContentInsideCurrentParen = true;
                    i++;
                    continue;
                }

                // Обработка цифр
                if (IsDigit(current))
                {
                    Log($"Обнаружена цифра '{current}'");

                    // Сброс флага десятичной точки при начале нового числа
                    if (lastWasOperator || lastWasOpenParen)
                    {
                        hasDecimalPoint = false;
                    }

                    // Проверка, что после ')' не идет число без оператора
                    if (previous == ')' && !lastWasOperator)
                    {
                        Log($"После ')' идет число без оператора. Возвращаем false.");
                        return false;
                    }

                    lastWasOperator = false;
                    lastWasOpenParen = false;
                    hasContentInsideCurrentParen = true;
                    i++;
                    continue;
                }

                // Если символ не распознан, возвращаем false
                Log($"Обнаружен неизвестный символ '{current}'. Возвращаем false.");
                return false;
            }

            // После итерации проверяем баланс скобок и корректность завершения функций
            if (isComplete && parenthesesStack.Count != 0)
            {
                Log($"Выражение завершено, но скобки не сбалансированы. Осталось открытых скобок: {parenthesesStack.Count}. Возвращаем false.");
                return false;
            }

            Log("Валидация завершена успешно. Возвращаем true.");
            return true;
        }

        /// <summary>
        /// Проверяет, является ли строка одиночным числом (целым или дробным, возможно с отрицательным знаком).
        /// </summary>
        /// <param name="expression">Выражение для проверки.</param>
        /// <returns>Возвращает true, если выражение является одним числом, иначе false.</returns>
        private static bool IsSingleNumber(string expression)
        {
            bool result = Regex.IsMatch(expression, @"^-?\d+(\.\d+)?$");
            Log($"Проверка IsSingleNumber для \"{expression}\": {result}");
            return result;
        }

        /// <summary>
        /// Проверяет, корректно ли размещены скобки и есть ли содержимое между ними.
        /// </summary>
        /// <param name="expression">Выражение для проверки.</param>
        /// <param name="isComplete">Флаг, указывающий, является ли выражение завершённым.</param>
        /// <returns>Возвращает true, если скобки размещены корректно, иначе false.</returns>
        private static bool AreParenthesesProperlyPlaced(string expression, bool isComplete)
        {
            Log("Начало проверки правильности размещения скобок.");

            Stack<char> stack = new Stack<char>();
            bool hasContent = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '(')
                {
                    stack.Push(c);
                    Log($"Добавили '(' в стек. Текущий размер стека: {stack.Count}");
                    hasContent = false; // Начинаем новую скобку, пока нет содержимого
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        Log($"Найдена закрывающая скобка ')' без соответствующей открывающей. Возвращаем false.");
                        return false;
                    }

                    stack.Pop();
                    Log($"Удалили '(' из стека. Текущий размер стека: {stack.Count}");

                    if (!hasContent)
                    {
                        Log("Найдены пустые скобки '()'. Возвращаем false.");
                        return false;
                    }

                    hasContent = true; // После закрытия скобки есть содержимое
                }
                else
                {
                    if (c != ' ')
                        hasContent = true; // Есть содержимое внутри скобок
                }
            }

            if (isComplete && stack.Count != 0)
            {
                Log($"Выражение завершено, но скобки не сбалансированы. Осталось открытых скобок: {stack.Count}. Возвращаем false.");
                return false;
            }

            Log("Проверка правильности размещения скобок завершена успешно.");
            return true;
        }

        /// <summary>
        /// Проверяет, начинается ли функция с текущей позиции.
        /// </summary>
        /// <param name="expression">Выражение.</param>
        /// <param name="index">Текущая позиция.</param>
        /// <param name="functionName">Название функции, если она начинается здесь.</param>
        /// <returns>Возвращает true, если функция начинается здесь, иначе false.</returns>
        private static bool IsFunctionStart(string expression, int index, out string functionName)
        {
            functionName = string.Empty;
            string[] functions = { "ln", "sqrt", "sin", "cos", "tan" }; // Добавьте необходимые функции

            foreach (var func in functions)
            {
                if (index + func.Length <= expression.Length &&
                    expression.Substring(index, func.Length).ToLower() == func)
                {
                    functionName = func;
                    Log($"Функция '{functionName}' начинается с позиции {index}.");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Проверяет, является ли символ оператором (+, -, *, /, ×, ÷, √, ^).
        /// </summary>
        /// <param name="c">Символ для проверки.</param>
        /// <returns>Возвращает true, если символ оператор, иначе false.</returns>
        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' ||
                   c == '×' || c == '÷' || c == '√' || c == '^';
        }

        /// <summary>
        /// Проверяет, является ли символ цифрой.
        /// </summary>
        /// <param name="c">Символ для проверки.</param>
        /// <returns>Возвращает true, если символ цифра, иначе false.</returns>
        private static bool IsDigit(char c)
        {
            return char.IsDigit(c);
        }
    }

    /// <summary>
    /// Перечисление типов токенов для отслеживания предыдущего символа.
    /// </summary>
    internal enum TokenType
    {
        None,
        Number,
        Operator,
        DecimalPoint,
        OpenParenthesis,
        CloseParenthesis,
        Function
    }
}
