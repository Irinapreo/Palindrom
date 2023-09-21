
Console.WriteLine("Enter a word to check if it's a palindrome"); 
string word = Console.ReadLine(); 
string palindromeCheck = word; 

for (int i = 0; i < word.Length; i++) 
{ 
    var letter = word[i]; 
    string index = letter.ToString(); 
    word = word.Remove(i, 1).Insert(0, index); 
}

for (int i = 0; i < palindromeCheck.Length; i++) 
{ 
    var letter = word[i]; 
    string index = letter.ToString(); 
    palindromeCheck = palindromeCheck.Remove(i, 1).Insert(0, index); 
}

if (palindromeCheck == word) 
{ 
    Console.WriteLine("The word is a palindrome"); 
} 
else 
{ 
    Console.WriteLine("The word is not a palindrome"); 
}
