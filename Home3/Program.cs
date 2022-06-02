Console.Clear();
Console.WriteLine("Написать программу копирования массива");
Console.Write("Введите данные массива (размер, минимальное и макисмальное значение, через пробел): ");
string SettingArr =  Console.ReadLine() ?? "0";
string[] SetArr = SettingArr.Split(" ");
int[] array = new int[Convert.ToInt32(SetArr[0])];
int NewSize = Convert.ToInt32(SetArr[0]);
int[] newArray = new int[NewSize];

for (int i=0; i<NewSize; i++)
{
    array[i] = new Random().Next(Convert.ToInt32(SetArr[1]),Convert.ToInt32(SetArr[2]));
    newArray[i] = array[i]; 
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

Console.WriteLine("Новый массив: ");
foreach (int k in newArray)
    Console.Write($"{k} ");