/*Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
Написать программу копирования массива*/

double f(double k1, double k2, double b1, double b2){
    if (k1 != k2){
        return (b2-b1)/(k1-k2);
    }
    Console.WriteLine("прямые параллельные или совпадают");
    return -1;
}




Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine()?? "");
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine()?? "");
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine()?? "");
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine()?? "");
double x = f(k1,k2,b1,b2);
Console.WriteLine($"{x},{k1*x+b1}");
