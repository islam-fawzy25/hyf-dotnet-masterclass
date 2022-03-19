// Return the number (count) of vowels in the given string. Consider a, e, i, o, u as vowels.

string input = "Intellectualization";
string vowels = "aeiou" ;

int GetVowelCount(string input){
int count=0;
char[] inputArray =input.ToLower().ToCharArray();

foreach(char letter in inputArray){
 if(vowels.Contains(letter))  count ++ ;
}
return count;
};

int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 
Console.WriteLine($"Number of vowels: {vowelCount}");

// Example: 
// 'Intellectualization' => Number of vowels: 9
