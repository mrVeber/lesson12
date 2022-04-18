using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка работоспособности статического класса для работы с окружностью.");
            Console.Write("Введите радиус окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Х для точки: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Y для точки: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Длинна окружности равна: {Circle.GetCircumference(r)}");
            Console.Write($"\nПлощадь окружности равна: {Circle.GetAreaOfACircle(r)}");
            Console.Write($"\nПроверка принадлежит ли точка с координатами ({x},{y}) окружности с радиусом {r} : {Circle.GetOwnershipChek(r,x,y)}");
            Console.ReadKey();
        }
    }
}
