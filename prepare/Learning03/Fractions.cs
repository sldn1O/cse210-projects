using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNum)
    {
        _numerator = wholeNum;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public double GetDecimal()
    {
        return (double)_numerator / (double)_denominator;
    }

    public string GetFraction()
    {
        string value = $"{_numerator}/{_denominator}";
        return value;
    }
}