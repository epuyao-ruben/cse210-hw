using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();
    private List<int> _indexWordsList = new List<int>();                                    //Exceeding requeriments

    public Scripture(Reference Reference, string text)
    {
        //Split list in diferentes word and add to new list, then change to a Word class and create a new list of numbers that are the index of this list
        List<string> textWords = text.Split(' ').ToList();
        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }       
        //assign reference class
        _reference = Reference;    

        for (int i = 0; i < textWords.Count; i++)                                           //support list for iteration and hide() without repeat
        {
            _indexWordsList.Add(i);
        }   
    }
    public void HideRandomWords(int numberToHide)
    {
        Random index = new Random();
        //iterate x  = numberToHide times 
        for (int i = 0; i < numberToHide; i++)
        {   
            int randomPos = index.Next(_words.Count);                                       //Random number between index of the list _words
            while (!_indexWordsList.Contains(randomPos) && _indexWordsList.Count > 0)       //loop while the support list contains elements
            {
                randomPos = index.Next(_words.Count);                                       //make sure to select and existing index to hide() as a position
            }
            Word wordToHide = _words[randomPos];                                            //create nre Word and select frmo the list
            wordToHide.Hide();                                                              //change to "_______"
            _indexWordsList.Remove(randomPos);                                              //remode number index from list
   
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        List<string> verse = new List<string>();
        foreach (Word word in _words)
        {
            string text = word.GetDisplayText();
            verse.Add(text); 
        }
        return reference + ": " + String.Join(" ",verse) + "\n";                                   //sreturn string from reference and from list of words (verse)   
    }

    public bool IsCompleteHidden()
    {
    
        if (_indexWordsList.Count == 0)
            return true; 
        else{
            return false;
        }
    }
}