namespace BoardScriptCSharp {

    public sealed class Ruleset {

        public PieceDictionary PieceSet {
            get;
        }

        public ActionDictionary ActionSet {
            get;
        }

        public int BoardWidth {
            get;
        }

        public int BoardLength {
            get;
        }

        public string PieceLayout {
            get;
        }

        private Piece NonePiece {
            get {
                return new Piece(PieceSet.Get("n"), PieceColors.NONE);
            }
        }

        public Piece PieceOf(string piece) {
            string color = piece[..1];
            string pieceSymbol;

            try {
                pieceSymbol = piece[1..];
            }
            catch (IndexOutOfRangeException) {
                return NonePiece;
            }

            PieceColors c;
            if (color.Equals("w")) {
                c = PieceColors.WHITE;
            }
            else if (color.Equals("b")) {
                c = PieceColors.BLACK;
            }
            else {
                return NonePiece;
            }

            if (!PieceSet.Check(pieceSymbol)) {
                return NonePiece;
            }

            return new Piece(PieceSet.Get(pieceSymbol), c);
        }

        private Ruleset(PieceDictionary pDict, ActionDictionary aDict, int wid, int len, string layout) {
            PieceSet = pDict;
            ActionSet = aDict;
            BoardWidth = wid;
            BoardLength = len;
            PieceLayout = layout;

        }

        public static RulesetBuilder GetRulesetBuilder() {
            return new RulesetBuilder();
        }

        public sealed class RulesetBuilder {

            public int? BoardWidth {
                get;
                set;
            }

            public int? BoardLength {
                get;
                set;
            }

            public string? InitialLayout {
                get;
                set;
            }

            public PieceDictionary? PieceSet {
                get;
                set;
            }

            public ActionDictionary? ActionSet {
                get;
                set;
            }
            
            public RulesetBuilder() {
                
            }

            public Ruleset Compile() {

                if (BoardWidth is null || BoardLength is null || InitialLayout is null || PieceSet is null || ActionSet is null) {
                    throw new RulesetNotFinalizedException();
                }
                else {
                    return new Ruleset(PieceSet, ActionSet, (int) BoardWidth, (int) BoardLength, InitialLayout);
                }

            }
        }
    }
}
