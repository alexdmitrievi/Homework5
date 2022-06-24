//Написать программу масштабирования фигуры

void f(double x, double y, double k){
    Console.WriteLine($"({k*x};{k*y})");
}


Console.WriteLine("введите координаты списком");
string input = Console.ReadLine() ?? "";
Console.WriteLine("Введите коэфицент k");
double k = Convert.ToDouble(Console.ReadLine()?? "");
string[] array = input.Split(" ");
for (int i = 0; i < 7; i +=2){
    f(Convert.ToDouble(array[i]), Convert.ToDouble(array[i+1]), k);  
}