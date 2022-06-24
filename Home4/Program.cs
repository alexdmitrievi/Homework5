
int Factorial(int n) {
if ( n == 1){
    return 1;
} 
return Factorial(n-1)*n;
}

int sum(int n){
    int summ = 0;
    for (int i = 1; i <= n; i++){
        summ = summ + Factorial(i);
    }
    return summ;
}    


Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(sum(n)); 