// Text Shape class
public class WordMaker : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Info { get; private set; }
    public int Id { get; private set; }

    public WordMaker(int x, int y, string information,int id)
    {
        X = x; Y = y; Info = information;Id=id;
    }

    public override string ToString()
    {
        return "Text (id: " +Id+", x: " + X + ", y: " + Y + ", Text: " + Info + ")";
    }
}