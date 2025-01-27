using System;
using System.Globalization;
using System.Linq.Expressions;
using NCalc;

namespace CalculatorLib
{
    public static class Calculator
    {
        // Определение приоритетов операторов
        private static readonly Dictionary<string, int> OperatorPrecedence = new Dictionary<string, int>
        {
            { "+", 2 },
            { "-", 2 },
            { "*", 3 },
            { "/", 3 },
            { "^", 4 }
        };

        // Определение ассоциативности операторов
        private static readonly Dictionary<string, string> OperatorAssociativity = new Dictionary<string, string>
        {
            { "+", "Left" },
            { "-", "Left" },
            { "*", "Left" },
            { "/", "Left" },
            { "^", "Right" }
        };

        /// <summary>
        /// Вычисляет математическое выражение и возвращает результат.
        /// </summary>
        /// <param name="expression">Строковое выражение для вычисления.</param>
        /// <returns>Результат вычисления в виде числа double.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если выражение некорректно.</exception>
        public static double Calculate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Выражение не может быть пустым.");

            // Токенизация выражения
            List<string> tokens = Tokenize(expression);

            // Преобразование в RPN
            List<string> rpn = ConvertToRPN(tokens);

            // Вычисление RPN
            double result = EvaluateRPN(rpn);

            return result;
        }

        /// <summary>
        /// Разбивает выражение на токены.
        /// </summary>
        /// <param name="expression">Строковое выражение.</param>
        /// <returns>Список токенов.</returns>
        private static List<string> Tokenize(string expression)
        {
            List<string> tokens = new List<string>();
            int i = 0;
            while (i < expression.Length)
            {
                char c = expression[i];

                // Пропуск пробелов
                if (char.IsWhiteSpace(c))
                {
                    i++;
                    continue;
                }

                // Число (целое или дробное)
                if (char.IsDigit(c) || c == '.')
                {
                    string number = "";
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        number += expression[i];
                        i++;
                    }
                    tokens.Add(number);
                    continue;
                }

                // Функции: sqrt, ln
                if (char.IsLetter(c))
                {
                    string func = "";
                    while (i < expression.Length && char.IsLetter(expression[i]))
                    {
                        func += expression[i];
                        i++;
                    }
                    tokens.Add(func.ToLower()); // Приведение к нижнему регистру
                    continue;
                }

                // Оператор или скобка
                if ("+-*/^()√".IndexOf(c) != -1)
                {
                    if (c == '√')
                    {
                        tokens.Add("sqrt");
                        i++;
                        continue;
                    }
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }

                throw new ArgumentException($"Недопустимый символ в выражении: '{c}'");
            }

            return tokens;
        }

        /// <summary>
        /// Преобразует токены из инфиксной нотации в постфиксную (RPN) с использованием алгоритма Шунтинг-Йардн.
        /// </summary>
        /// <param name="tokens">Список токенов.</param>
        /// <returns>Список токенов в постфиксной нотации.</returns>
        private static List<string> ConvertToRPN(List<string> tokens)
        {
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>();

            foreach (var token in tokens)
            {
                double number;
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                {
                    // Число добавляется в выход
                    output.Add(token);
                }
                else if (IsFunction(token))
                {
                    // Функция добавляется в стек операторов
                    operators.Push(token);
                }
                else if (IsOperator(token))
                {
                    while (operators.Count > 0 && IsOperator(operators.Peek()))
                    {
                        string topOp = operators.Peek();
                        if ((OperatorAssociativity[token] == "Left" && OperatorPrecedence[token] <= OperatorPrecedence[topOp]) ||
                            (OperatorAssociativity[token] == "Right" && OperatorPrecedence[token] < OperatorPrecedence[topOp]))
                        {
                            output.Add(operators.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                    operators.Push(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Count > 0 && operators.Peek() != "(")
                    {
                        output.Add(operators.Pop());
                    }

                    if (operators.Count == 0)
                        throw new ArgumentException("Несбалансированные скобки.");

                    operators.Pop(); // Удаление "("

                    // Если на вершине стека функция, добавляем её в выход
                    if (operators.Count > 0 && IsFunction(operators.Peek()))
                    {
                        output.Add(operators.Pop());
                    }
                }
                else
                {
                    throw new ArgumentException($"Неизвестный токен: '{token}'");
                }
            }

            while (operators.Count > 0)
            {
                string op = operators.Pop();
                if (op == "(" || op == ")")
                    throw new ArgumentException("Несбалансированные скобки.");
                output.Add(op);
            }

            return output;
        }

        /// <summary>
        /// Вычисляет выражение в постфиксной нотации (RPN).
        /// </summary>
        /// <param name="rpn">Список токенов в RPN.</param>
        /// <returns>Результат вычисления.</returns>
        private static double EvaluateRPN(List<string> rpn)
        {
            Stack<double> stack = new Stack<double>();

            foreach (var token in rpn)
            {
                double number;
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token))
                {
                    if (stack.Count < 2)
                        throw new ArgumentException("Некорректное выражение.");

                    double right = stack.Pop();
                    double left = stack.Pop();
                    double result = ApplyOperator(token, left, right);
                    stack.Push(result);
                }
                else if (IsFunction(token))
                {
                    if (stack.Count < 1)
                        throw new ArgumentException("Некорректное выражение.");

                    double arg = stack.Pop();
                    double result = ApplyFunction(token, arg);
                    stack.Push(result);
                }
                else
                {
                    throw new ArgumentException($"Неизвестный токен в RPN: '{token}'");
                }
            }

            if (stack.Count != 1)
                throw new ArgumentException("Некорректное выражение.");

            return stack.Pop();
        }

        /// <summary>
        /// Проверяет, является ли токен оператором.
        /// </summary>
        /// <param name="token">Токен.</param>
        /// <returns>Возвращает true, если токен оператор, иначе false.</returns>
        private static bool IsOperator(string token)
        {
            return OperatorPrecedence.ContainsKey(token);
        }

        /// <summary>
        /// Проверяет, является ли токен функцией.
        /// </summary>
        /// <param name="token">Токен.</param>
        /// <returns>Возвращает true, если токен функция, иначе false.</returns>
        private static bool IsFunction(string token)
        {
            return token == "sqrt" || token == "ln";
            // Добавьте другие функции по необходимости
        }

        /// <summary>
        /// Применяет оператор к двум операндам.
        /// </summary>
        /// <param name="op">Оператор.</param>
        /// <param name="left">Левый операнд.</param>
        /// <param name="right">Правый операнд.</param>
        /// <returns>Результат применения оператора.</returns>
        private static double ApplyOperator(string op, double left, double right)
        {
            switch (op)
            {
                case "+": return left + right;
                case "-": return left - right;
                case "*": return left * right;
                case "/":
                    if (right == 0)
                        throw new DivideByZeroException("Деление на ноль.");
                    return left / right;
                case "^": return Math.Pow(left, right);
                default:
                    throw new ArgumentException($"Неизвестный оператор: '{op}'");
            }
        }

        /// <summary>
        /// Применяет функцию к операнду.
        /// </summary>
        /// <param name="func">Функция.</param>
        /// <param name="arg">Аргумент.</param>
        /// <returns>Результат применения функции.</returns>
        private static double ApplyFunction(string func, double arg)
        {
            switch (func)
            {
                case "sqrt":
                    if (arg < 0)
                        throw new ArgumentException("Аргумент функции sqrt() не может быть отрицательным.");
                    return Math.Sqrt(arg);
                case "ln":
                    if (arg <= 0)
                        throw new ArgumentException("Аргумент функции ln() должен быть больше нуля.");
                    return Math.Log(arg);
                default:
                    throw new ArgumentException($"Неизвестная функция: '{func}'");
            }
        }
    }
}
