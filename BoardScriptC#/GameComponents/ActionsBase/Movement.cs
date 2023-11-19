using System;

namespace BoardScriptCSharp {
    class Movement : IBasePieceAction {

        public string Symbol {
            get {
                return "m";
            }
        }

        public Square StartingSquare {
            get;
        }

        public Square TargetSquare {
            get;
        }

        public Movement(Square start, Square end) {
            this.StartingSquare = start;
            this.TargetSquare = end;
        }

    }
}
