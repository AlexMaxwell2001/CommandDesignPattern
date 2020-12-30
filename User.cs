using System;
using System.Collections.Generic;
public class User
{
    private Stack<Command> undo;
    private Stack<Command> redo;
    public int UndoCount { get => undo.Count; }
    public int RedoCount { get => undo.Count; }
    public User()
    {
        Reset();
    }
    public void Reset()
    {
        undo = new Stack<Command>();
        redo = new Stack<Command>();
    }

    public void Action(Command command)
    {
        undo.Push(command);  // save the command to the undo command
        redo.Clear();        // once a new command is issued, the redo stack clears


        Type t = command.GetType();
        if (t.Equals(typeof(AddShapeCommand)))
        {
            Console.WriteLine("Command Received: Add new Shape!" + Environment.NewLine);
            command.Do();
        }
        if (t.Equals(typeof(DeleteShapeCommand)))
        {
            Console.WriteLine("Command Received: Delete last Shape!" + Environment.NewLine);
            command.Do();
        }
    }

    // Undo
    public void Undo()
    {
        Console.WriteLine("Undoing operation!"); Console.WriteLine();
        if (undo.Count > 0)
        {
            Command c = undo.Pop(); c.Undo(); redo.Push(c);
        }
    }

    // Redo
     public void Redo()
    {
        Console.WriteLine("Redoing operation!"); Console.WriteLine();
        if (redo.Count > 0)
        {
            Command c = redo.Pop(); c.Do(); undo.Push(c);
        }
    }
}