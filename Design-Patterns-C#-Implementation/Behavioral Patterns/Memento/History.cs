namespace Design_Patterns_C__Implementation.Behavioral_Patterns.Memento
{
    //CareTaker
    public class History
    {
        private List<EditorState> editorStates = new List<EditorState>();

        public void Push(EditorState state) { 
            editorStates.Add(state);
        }

        public EditorState Pop() {
            var index = editorStates.Count - 1;
            var state = editorStates[index];
            editorStates.Remove(state);

            return state;
        }
    }
}
