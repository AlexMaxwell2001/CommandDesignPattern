// Path Shape class
public class Path : Shape
{
    public string D { get; private set; }
    public int Id { get; private set; }
    public Path(string d,int id)
    {
        D = d;Id=id;
    }

    public override string ToString()
    {
        return "Path (id: " + Id+ ", d: " + D + ")";
    }
}