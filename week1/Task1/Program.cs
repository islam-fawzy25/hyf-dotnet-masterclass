// See https://aka.ms/new-console-template for more information
string input = "world of Csharp";
string ReverseString(string input){
    
char[] inputArray = input.ToCharArray();

Array.Reverse(inputArray);
return new string (inputArray);

}; //TODO: Implement ReverseString
string reversed = ReverseString(input);
Console.WriteLine($"Reversed input value: {reversed}");

