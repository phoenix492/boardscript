namespace BoardScriptCSharp {
    public class BaseActionNotFoundException : Exception {
        public BaseActionNotFoundException() {
        }
        public BaseActionNotFoundException(string message) : base (message) {
        }
        public BaseActionNotFoundException(string message, Exception inner) : base(message, inner) {
        }
    }
}
