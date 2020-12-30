// Polyline Shape class
public class Polyline : Shape
{
    public string Points { get; private set; }
    public int Id { get; private set; }
    public Polyline(string points,int id)
    {
        Points = points;Id=id;
    }

    public override string ToString()
    {
        return "Polyline (id: " + Id+", points: " + Points + ")";
    }
}