// Polygon Shape class
public class Polygon : Shape
{
    public string Points { get; private set; }
    public int Id { get; private set; }
    public Polygon(string points,int id)
    {
        Points = points;Id=id;
    }

    public override string ToString()
    {
        return "Polygon (id: " + Id+", points: " + Points + ")";
    }
}