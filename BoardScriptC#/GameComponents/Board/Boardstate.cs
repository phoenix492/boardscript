namespace BoardScriptCSharp {

    public class Boardstate {

        public int X {
            get {
                return rules.BoardWidth;
            }
        }
        
        public int Y {
            get {
                return rules.BoardLength;
            }
        }

        public int SquareCount {
            get {
                return X * Y;
            }
        }

        private Square[] squares;

        private Ruleset rules;

        public Boardstate(Ruleset rules) {
            this.rules = rules;

            squares = new Square[SquareCount];
            for (int i = 0; i < Y; i++) {
                for (int j = 0; j < X; j++) {
                    squares[X * i + j] = new Square(X * i + j, rules);
                }
            }
        }

        public Boardstate(Ruleset rules, string layout) : this(rules) {
            PopulateBoardstate(layout);
        }

        public void PopulateBoardstate(string layoutString) {
            List<List<string>> layout = DecomposeLayout(layoutString);
            int i = 0;
            foreach (var e in layout) {
                
            }
        }

        // TODO: Actually implement this
        public bool ApplyMove(Move m) {
            return m is null; // NOP
        }

        public Square GetSquare(int index) {
             return squares[index];
        }

        public Square GetSquare(int x, int y) {
            return squares[X * y + x];
        }

        private static List<List<string>> DecomposeLayout(string layoutString) {
            List<List<string>> list = new();
            string[] rows = layoutString.Split('-');
            foreach (string s in rows) {
                list.Add(new List<string>(s.Split('.')));   
            }

            return list;
        }
    }
}
