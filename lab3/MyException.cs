using System;
using System.Runtime.Serialization;

[Serializable]
internal class MyException : Exception
{
    private double priceV;
    public double PriceV { get { return priceV; } }

    public MyException(double price, string message) : base(message)
    {
        priceV = price;
    }
}