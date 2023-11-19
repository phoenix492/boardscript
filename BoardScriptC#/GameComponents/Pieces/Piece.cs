namespace BoardScriptCSharp {

    public sealed class Piece {

        public string Symbol {
            get {
                return PieceDef.Symbol;
            }
        }

        public string Name {
            get {
                return PieceDef.Name;
            }
        }

        public PieceColors Color {
            get;
        }

        private PieceDefinition PieceDef;

        public Piece(PieceDefinition d, PieceColors c) {
            this.PieceDef = d;
            this.Color = c;
        }

    }
}
