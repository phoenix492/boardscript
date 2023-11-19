namespace BoardScriptCSharp {

    public class Square {

        public int X {
            get {
                return index % rules.BoardWidth;
            }
        }

        public int Y {
            get {
                return index % rules.BoardWidth;
            }
        }

        public Piece? Piece {

            get;
            private set;
        }

        private int index;

        private Ruleset rules;

        public Square(int index, Ruleset rules) {
            this.index = index;
            this.rules = rules;
        }

        public bool InsertPiece(Piece p) {
            Piece = p;
            if (Piece == p) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
