namespace BoardScriptCSharp {

    public class ActionDictionary {
        private Dictionary<string, IBasePieceAction> defs;

        private ActionDictionary(Dictionary<string, IBasePieceAction> defs) {
            this.defs = defs;
        }

        public static BaseActionDictionaryBuilder GetBaseActionDictionaryBuilder() {
            return new BaseActionDictionaryBuilder();
        }

        public sealed class BaseActionDictionaryBuilder {
            private Dictionary<string, IBasePieceAction> defs;

            public BaseActionDictionaryBuilder() {
                this.defs = new Dictionary<string, IBasePieceAction>();
            }

            public BaseActionDictionaryBuilder Add(IBasePieceAction d) {
                defs.Add(d.Symbol, d);
                return this;
            }

            public ActionDictionary Build() {
                return new ActionDictionary(defs);
            }
        
        }

        public bool Check(string s) {
            return defs.ContainsKey(s);
        }

        public IBasePieceAction Get(string s) {
            if (!Check(s)) {
                throw new BaseActionNotFoundException();
            }
            return defs[s];
        }

    }
}
