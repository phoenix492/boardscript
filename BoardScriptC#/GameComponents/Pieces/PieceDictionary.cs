namespace BoardScriptCSharp {

    public sealed class PieceDictionary {

        private Dictionary<string, PieceDefinition> defs;

        private PieceDictionary(Dictionary<string, PieceDefinition> defs) {
            this.defs = defs;
        }

        public static PieceDictionaryBuilder GetPieceDictionaryBuilder() {
            return new PieceDictionaryBuilder();
        }

        public sealed class PieceDictionaryBuilder {
            
            private Dictionary<string, PieceDefinition> defs;

            public PieceDictionaryBuilder() {
                this.defs = new Dictionary<string, PieceDefinition>();
                defs.Add("n", new PieceDefinition("None", "n"));
            }

            public PieceDictionaryBuilder Add(PieceDefinition d) {
                defs.Add(d.Symbol, d);
                return this;
            }

            public PieceDictionary Build(){
                return new PieceDictionary(defs);
            }

        }

        public bool Check(string s) {
            return defs.ContainsKey(s);
        }

        public PieceDefinition Get(string s) {
            if (!Check(s)) {
                throw new PieceNotFoundException();
            }
            return defs[s];
        }

    }
}
