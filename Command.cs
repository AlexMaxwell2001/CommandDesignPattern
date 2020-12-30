        public abstract class Command
        {
            public abstract void Do();     // what happens when we execute (do)
            public abstract void Undo();   // what happens when we unexecute (undo)
        }