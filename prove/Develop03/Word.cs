

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;   
    }

    public void Hide()
    {
        //string _originalText = _text; // Guarda el valor original de la palabra
        foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz;,") // Recorre todas las letras del alfabeto
        {
            _text = _text.Replace(letter, '_'); // Reemplaza cada letra por '_'
        }
        _isHidden = true; // Indica que la palabra está oculta
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else{
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
