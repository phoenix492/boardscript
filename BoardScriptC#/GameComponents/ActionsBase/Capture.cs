namespace BoardScriptCSharp {
    class Capture : IBasePieceAction {
        
        public string Symbol {
            get {
                return "c";
            }
        }

        public Square TargetSquare {
            get;
        }

        public Capture(Square end) {
            this.TargetSquare = end;
        }
    }
}
