public class Fraction
{
    private int _top;
    private int _bottom;
    public decimal _dec;


    public void Display()
    {
        Console.WriteLine($"{_bottom}");
    }

    public Fraction()
    {
        _top = 1/1;
        _bottom = 1/1;
        // _dec = numerator/denominator;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // public decimal getdec()
    // {
    //     return _dec;
    // }

    public void SetTop(int top)
    {
        if (top == 1)
        {
            _bottom = top/1;
        }
        
        else if (top == 5)
        {
            _bottom = top/1;
        }

        else if (top == 3/4)
        {
            _bottom = top;
        }

        else if (top == 3/4)
        {
            _bottom = top;
        }

        else if (top == 1/3)
        {
            _bottom = top;
        }


        else
        {
            Console.WriteLine("I don't know.");
        }
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
}