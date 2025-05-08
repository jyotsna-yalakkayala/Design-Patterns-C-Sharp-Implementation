using Design_Patterns_C__Implementation.Behavioral_Patterns.Memento;

namespace Design_Patterns_C__Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Revising Design Patterns is Fun!");


            #region Memento

            var editor = new Editor();
            var history = new History();

            editor.Type("This is the ");
            history.Push(editor.Save());

            editor.Type("example for implementing ");
            history.Push(editor.Save());

            editor.Type("Memento Pattern ");
            history.Push(editor.Save());

            editor.Restore(history.Pop());
            Console.WriteLine("After first Undo: " + editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine($"After Second Undo: {editor.Content}");
            #endregion
        }
    }
}
