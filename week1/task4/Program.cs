
// 4. Classical task

// Create function Fibonacci that returns N'th element of Fibonacci sequence (classic programming task).

int n = 6;

int Fibonacci(int input)
{

    int[] fibonacciArray = new int[input + 1];
    fibonacciArray[0] = 0;
    fibonacciArray[1] = 1;

    for (var i = 2; i <= input; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1];

    }
    return fibonacciArray[fibonacciArray.Length - 1];

}

int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

