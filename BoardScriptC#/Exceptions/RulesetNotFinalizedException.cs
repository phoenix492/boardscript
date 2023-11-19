namespace BoardScriptCSharp {
    public class RulesetNotFinalizedException : Exception {
        public RulesetNotFinalizedException() : this("Required properties of ruleset not set") {

        }
        public RulesetNotFinalizedException(string message) : base (message) {
        }
        public RulesetNotFinalizedException(string message, Exception inner) : base(message, inner) {
        }
    }
}
