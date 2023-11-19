namespace BoardScriptCSharp {

    public interface IBasePieceAction {
        /*/ 
         *  TODO: These should probably be configurable and user defined. 
         *  Moreover, rather than base actions having a symbol,
         *  users probably shouldn't use these directly and instead should be 
         *  mirrored by derrived actions that use only them.
        /*/
        public string Symbol {
            get;
        }
    }
}
