namespace Design_Patterns_C__Implementation.Behavioral_Patterns.Memento
{
    //Memento
    public class EditorState
    {
        // Why Content { get; }
        // and constructor instead of Content { get; set; }?

        //In the Memento pattern:
        //Mementos should be immutable — once you capture the state, it shouldn't change.
        //Only the originator(e.g., Editor) should be able to set the content, and that happens during memento creation.
        public string Content { get; }

        public EditorState(string Content)
        {
            this.Content = Content;
        }


        //Summary
        //Using a getter-only property with constructor-based initialization ensures:

        //Immutability: No one can change the state after creation.

        //Encapsulation: Originator controls the memento’s state.

        //Cleaner, safer design aligned with design pattern intent.
    }
}
