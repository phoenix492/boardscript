namespace BoardScriptCSharp {

    public class Move {

        public Piece Target {
            get;
        }

        public IBasePieceAction Action {
            get;
        }

        public Square Square {
            get;
        }

        public Move(Piece p, IBasePieceAction a, Square s) {
            Target = p;
            Action = a;
            Square = s;
        }

        public Move(string m) {
            string[] splitMove = m.Split('-');

            if (splitMove.Length != 3) {
                throw new FormatException("Move string not in form Target-Action-Square");
            }


        }

        public override string ToString() {
            return $"{Target}-{Action}-{Square}";
        }
    }
}
