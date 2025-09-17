using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор — шаги реализации: Add/Subtract/Multiply/Divide");

        // TODO #1: Реализуй ввод чисел и операцию
        //  - используй double.TryParse для безопасного ввода
        //  - для начала можешь запросить 2 числа и одну операцию, затем вызвать нужный метод

        // Пример вызова (реализуй сам):
        // double a = ReadDouble("Введите первое число: ");
        // double b = ReadDouble("Введите второе число: ");
        // char op = ReadOperation("Введите операцию (+ - * /): ");
        // double result = 0;
        // switch (op) { case '+': result = Add(a, b); break; ... }
        // Console.WriteLine($"Результат: {result}");

        // TODO #2: Добавь меню/цикл (позже)
    }

    // TODO #A: реализуй методы ниже по очереди
    public static double Add(double a, double b)
    {
        throw new NotImplementedException(); // реализуй и коммить
    }

    public static double Subtract(double a, double b)
    {
        throw new NotImplementedException();
    }

    public static double Multiply(double a, double b)
    {
        throw new NotImplementedException();
    }

    public static double Divide(double a, double b)
    {
        // Обязательная проверка деления на ноль
        throw new NotImplementedException();
    }

    // Подсказка: можешь добавить вспомвапвапваогательные методы для ввода:
    // static double ReadDouble(string prompt) { ... }
    // static char ReadOperation(string prompt) { ... }
}
