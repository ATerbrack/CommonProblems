// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

// Q1
Console.WriteLine("\n=== Reversing a String ===");

string str1 = "racecar";
string str2 = "palindrome";

Console.WriteLine($"{str1} => {ReverseString(str1)}");
Console.WriteLine($"{str2} => {ReverseString(str2)}");

string ReverseString(string forward)
{
    char[] charArray = forward.ToCharArray();
    string reverse = "";

    for (int i = forward.Length - 1; i >= 0; --i)
    {
        reverse += charArray[i];
    }
    return reverse;
}

// Q2
Console.WriteLine("\n=== Palindrome Checker ===");

Console.WriteLine($"{str1} {(IsPalindrome(str1) ? "is" : "is not")} a palindrome.");
Console.WriteLine($"{str2} {(IsPalindrome(str2) ? "is" : "is not")} a palindrome.");

bool IsPalindrome(string str)
{
    return str == ReverseString(str);
}

// Q3
Console.WriteLine("\n=== Counting Characters in a String ===");

char char1 = 'a';
char char2 = 'e';
Console.WriteLine($"'{char1}' appears in \"{str1}\" {CountCharactersInString(char1, str1)} times");
Console.WriteLine($"'{char2}' appears in \"{str1}\" {CountCharactersInString(char2, str1)} times");
Console.WriteLine($"'{char1}' appears in \"{str2}\" {CountCharactersInString(char1, str2)} times");
Console.WriteLine($"'{char2}' appears in \"{str2}\" {CountCharactersInString(char2, str2)} times");

int CountCharactersInString(char CharacterToSearchFor, string StringToSearch)
{
    int occurences = 0;

    char[] charArray = StringToSearch.ToCharArray();

    for (int i = 0; i < charArray.Length; ++i)
    {
        if (charArray[i] == CharacterToSearchFor)
        {
            occurences++;
        }
    }

    return occurences;
}

// Q4

Console.WriteLine("\n=== Anagrams ===");

Console.WriteLine($"\"{str1}\" and \"{str2}\" {(AreStringsAnagrams(str1, str2) ? "are" : "are not")} anagrams");
Console.WriteLine($"\"{str2}\" and \"{ReverseString(str2)}\" {(AreStringsAnagrams(str2, ReverseString(str2)) ? "are" : "are not")} anagrams");

bool AreStringsAnagrams(string str1, string str2)
{
    char[] charArray1 = str1.ToCharArray();
    char[] charArray2 = str2.ToCharArray();

    Array.Sort(charArray1);
    Array.Sort(charArray2);

    return charArray1.SequenceEqual(charArray2);
}

// Q5

Console.WriteLine("\n=== Bubble Sort ===");

int[] array = {1, 7, 2, 3, 9, 24, 91, 10, 5};

Console.WriteLine($"{WriteIntArray(array)} bubble sorted => {WriteIntArray(BubbleSortIntegersAscending(array))}");

int[] BubbleSortIntegersAscending(int[] input)
{
    int[] output = (int[])input.Clone();
    for (int i = 0; i < output.Length; ++i)
    {
        for (int j = i+1; j < output.Length; j++)
        {
            if (output[j] < output[i])
            {
                SwitchEntries(output, j, i);
                i = 0;
            }
        }
    }

    return output.ToArray();
}

void SwitchEntries(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

string WriteIntArray(int[] array)
{
    string str = "{ ";
    for (int i = 0 ; i< array.Length; ++i)
    {
        str += $"{array[i]}, ";
    }
    str += "}";
    return str;
}

// Q6

Console.WriteLine("\n=== Insertion Sort ===");

Console.WriteLine($"{WriteIntArray(array)} insertion sorted => {WriteIntArray(InsertionSortIntegersAscending(array))}");

int[] InsertionSortIntegersAscending(int[] input)
{
    int[] output = (int[])input.Clone();
    for (int i = 1; i < output.Length; ++i)
    {
        int key = output[i];
        int j = i - 1;

        while (j >= 0 && output[j] < key)
        {
            output[j+1] = output[j];
            j--;
        }
        output[j+1] = key;
    }

    return output;
}

// Q6

//Console.WriteLine("\n=== Binary Search Tree ===");
//
//Node* CreateRandomTree()
//
//public class Node{
//    int data;
//    Node left;
//    Node right;
//}

// Q7

Console.WriteLine("\n=== Fizzbuzz ===");

for (int i = 1; i <= 100; ++i)
{
    Console.WriteLine(WriteFizzAndOrBuzzAndOrBazz(i));
}

string WriteFizzAndOrBuzz(int i)
{
    string output = $"{i} ";
    if (i % 3 == 0) output += "Fizz";
    if (i % 5 == 0) output += "Buzz";

    return output;
}

string WriteFizzAndOrBuzzAlt(int i)
{
    //if (i % 15 == 0) return "FizzBuzz";
    if (i % 3 == 0 && i % 5 == 0) return "FizzBuzz";
    if (i % 3 == 0) return "Fizz";
    if (i % 5 == 0) return "Buzz";

    return i.ToString();
}

string WriteFizzAndOrBuzzAndOrBazz(int i)
{
    string output = $"{i} ";
    
    if (i % 3 == 0) output += "Fizz";
    if (i % 5 == 0) output += "Buzz";
    if (i % 7 == 0) output += "Bazz";

    return output;
}