namespace BoardScriptCSharp {

    public sealed class PieceDefinition {
        public string Name {
            get;
        }

        public string Symbol {
            get;
        }

        public PieceDefinition(string n, string s) {
            Name = n;
            Symbol = s;
        }
    }
}
