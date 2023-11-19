﻿namespace BoardScriptCSharp {
    public class PieceNotFoundException : Exception {
        public PieceNotFoundException() {
        }
        public PieceNotFoundException(string message) : base (message) {
        }
        public PieceNotFoundException(string message, Exception inner) : base(message, inner) {
        }
    }
}
