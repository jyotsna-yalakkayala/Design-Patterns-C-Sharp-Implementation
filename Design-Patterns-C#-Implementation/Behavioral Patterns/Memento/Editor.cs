namespace Design_Patterns_C__Implementation.Behavioral_Patterns.Memento
{
    //Originator
    public class Editor
    {

        //🔍 public string Content { get; private set; } in Editor
        //This means:

        //Any class can read the value(public get)

        //But only the Editor class itself can set the value(private set)

        //Why do we do this?
        //Because in the Memento pattern:

        //The Editor(originator) is responsible for modifying its own state(Content)

        //But no one else should be able to modify Content from outside — they can only save/restore via the Memento

        //This keeps your code clean and safe.

        public string Content { get; private set; }

        public void Type(string words) {
            Content += words;
        }

        public EditorState Save() { 
            return new EditorState(Content);
        }

        public void Restore(EditorState state) { 
            Content = state.Content;
        }
    }
}
