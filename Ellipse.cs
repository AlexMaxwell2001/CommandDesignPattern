// Ellipse Shape class
public class Ellipse : Shape
{
    public int CX { get; private set; }
    public int CY { get; private set; }
    public int RX { get; private set; }
    public int RY { get; private set; }
    public int Id { get; private set; }
    public Ellipse(int cx, int cy, int rx,int ry,int id)
    {
        CX = cx; CY = cy; RX = rx;RY=ry;Id=id;
    }

    public override string ToString()
    {
        return "Ellipse (id: " + Id + ", cx: " + CX + ", cy: " + CY + ", rx: " + RX + ", ry: " + RY +")";
    }
}