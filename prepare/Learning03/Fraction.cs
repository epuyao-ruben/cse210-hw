using System;
public class Fraction {

    private int _top;
    private int _bottom;

    public Fraction() //Constructor
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)  //constructor
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //constructor
    {
        _top = top;
        _bottom = bottom;

    }


    public string GetFractionString() //method
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue() //method
    { 
        return (double)_top/(double)_bottom;
    }

}


