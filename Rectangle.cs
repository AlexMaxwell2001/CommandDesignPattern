// Rectangle Shape class
using System;
using  System.IO;
public class Rectangle : Shape
{
    public  int X { get; private set; }
    public int Y { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int Id { get; private set; }
    public Rectangle(int x, int y, int width, int height,int id)
    {
        X = x; Y = y; Width= width;Height= height;Id=id;
    }
    public override string ToString()
    {
        return "Rectangle (id: " + Id + ", x: " + X + ", y: " + Y + ", width: " + Width + ", height: " + Height +")";
    }
}