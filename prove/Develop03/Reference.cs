public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference ()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse; 
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_chapter == 0 && _verse == 0 && _endVerse == 0)
        {
            return "Invalid Scripture";
        }
        else if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        
    }

}

