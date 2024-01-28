using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference ()                                                             //create constructor with no parameters
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse)                           //create constructor with 3 parameters
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)        //create constructor with 4 parameters, start and end verse
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse; 
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_chapter == 0 && _verse == 0 && _endVerse == 0)                         //applying initial values to check
        {
            return "Invalid Scripture";
        }
        else if (_endVerse == 0)                                                    //using constructor with 3 parameters
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else                                                                        //using constructor with 4 parameters
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        
    }

}

