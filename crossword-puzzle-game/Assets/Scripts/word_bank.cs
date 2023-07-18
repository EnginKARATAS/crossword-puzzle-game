using UnityEngine;
using System.Collections.Generic; 
// File: word_bank.cs
public class WordBank
{
    private List<string> words;

    public WordBank(List<string> wordList)
    {
        words = wordList;
    }

    public List<string> GetWordList()
    {
        // Implementation to get the list of words from the word bank
        // Randomize the order of words for variety in each puzzle generation
        return words;
    }
}