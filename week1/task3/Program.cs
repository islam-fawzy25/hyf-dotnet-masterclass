// 3. Math/Array

// Given an array of the numbers return an array with two elements where first element represents 
//sum of all negative numbers and second element represents multiplication of all positive numbers;

int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 };


int[] GetResult( int[] input){
int sumNigavtiveNumbers = 0;
int sumPossitiveNumbers =1;

foreach(int number in input){
if(number < 0) sumNigavtiveNumbers += number ;
if(number >0) sumPossitiveNumbers *= number ;


}
return new int [] {sumNigavtiveNumbers,sumPossitiveNumbers};
};

 int[] result = GetResult(arr); //TODO: Implement GetResult
 Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");

//EX
// new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 } => Sum of negative numbers: -2022. Multiplication of positive numbers: 20222022