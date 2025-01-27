namespace CalculatorApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        // Запуск основной формы калькулятора
        Application.Run(new MainForm());
    }
}
