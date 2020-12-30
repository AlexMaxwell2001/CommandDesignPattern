// Line Shape class
public class Line : Shape
{
    public int X1 { get; private set; }
    public int X2 { get; private set; }
    public int Y1 { get; private set; }
    public int Y2 { get; private set; }
    public int Id { get; private set; }
    public Line(int x1, int x2, int y1,int y2,int id)
    {
        X1 = x1; X2 = x2; Y1 = y1;Y2=y2;Id=id;
    }

    public override string ToString()
    {
        return "Line (id: "+Id+", x1: " + X1 + ", x2: " + X2 + ", y1: " + Y1 + ", y2: " + Y2 + ")";
    }
}