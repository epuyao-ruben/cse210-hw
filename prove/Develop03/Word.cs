using System;

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
        foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz;,.")  //check every of this char and change for _
        {
            _text = _text.Replace(letter, '_'); 
        }
        _isHidden = true; 
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
