using System;

public class Square : Program
{
    private double side;

    public void setSide(double side)
    {
        this.side = side;
    }
    public double area()
    {
        return Math.Pow(this.side, 2);
    }
}


