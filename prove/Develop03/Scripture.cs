public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return ""; //modificar
    }

    public bool IsCompleteHidden()
    {
        return true; //modificar
    }
}