// Add Shape Command - it is a ConcreteCommand Class (extends Command)
// This adds a Shape (Circle) to the Canvas as the "Do" action
public class AddShapeCommand : Command
{
    Shape shape;
    Canvas canvas;
    public AddShapeCommand(Shape s, Canvas c)
    {
        shape = s;
        canvas = c;
    }

    // Adds a shape to the canvas as "Do" action
    public override void Do()
    {
        canvas.Add(shape);
    }
    // Removes a shape from the canvas as "Undo" action
    public override void Undo()
    {
        shape = canvas.Remove();
    }
}