using System.Data;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        //separar text en palabras y agregarlo a la lista words
        
        List<string> textWords = text.Split(' ').ToList();
        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }       
        //assignar la variable referencia a reference
        _reference = Reference;
        
    }

    public void HideRandomWords(int numberToHide)
    {
        //elegir un numero x entre 1 y 3 esto lo hago en program

        //elegir x=numberToHide items en una lista
        Random number = new Random();
        int numbers = number.Next(_words.Count);
        //cambiar esoso items en palabras ocultas
        
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            string text = word;
        }
        string verse = ;

        //devolver la lista uniendola nuevamente en un string
        return _reference.GetDisplayText(); //sumar referencia y lista de texto y devolverla
        
    }

    // public bool IsCompleteHidden()
    // {
    //     //verificar q todas las palabras de la lista esten ocultas, si es asi entonces finalizar el programa
    //     return true; //modificar
    // }
}