//Написать программу масштабирования фигуры

void f(double x, double y, double k){
    Console.WriteLine($"({k*x};{k*y})");
}


Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine()?? "");
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine()?? "");
Console.WriteLine("Введите коэфицент k");
double k = Convert.ToDouble(Console.ReadLine()?? "");
f(x,y,k);

