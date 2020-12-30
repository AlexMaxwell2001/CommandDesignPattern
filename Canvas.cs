using System.Collections.Generic;
using System;
        public class Canvas
        {
            private Stack<Shape> canvas = new Stack<Shape>();

            public void Add(Shape s)
            {
                canvas.Push(s);
                Console.WriteLine("Added Shape to canvas: {0}" + Environment.NewLine, s);
            }
            public Shape Remove()
            {
                Shape s = canvas.Pop();
                Console.WriteLine("Removed Shape from canvas: {0}" + Environment.NewLine, s);
                return s;
            }

            public Canvas()
            {
                Console.WriteLine("\nCanvas Created - use commands to add shapes to	the canvas"); Console.WriteLine();
            }

            public override string ToString()
            {
                String str = "Canvas (" + canvas.Count + " elements): " + Environment.NewLine + Environment.NewLine;
                foreach (Shape s in canvas)
                {
                    str += "   > " + s + Environment.NewLine;
                }
                return str;
            }

        }