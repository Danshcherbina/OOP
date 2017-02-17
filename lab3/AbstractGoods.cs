using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[Serializable]
abstract public class AbstractGoods
{
    public int price;
    public string name;
    abstract public void check();
    abstract public void stole();
    abstract public void toBeChecked();

}