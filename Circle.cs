// Circle Shape class
public class Circle : Shape
{
    public int CX { get; private set; }
    public int CY { get; private set; }
    public int R { get; private set; }
    public int Id { get; private set; }

    public Circle(int cx, int cy, int r,int id)
    {
        CX = cx; CY = cy; R = r;Id=id;
    }

    public override string ToString()
    {
        return "Circle (id: " + Id +", cx: " + CX + ", cy: " + CY + ", r: " + R + ")";
    }
}