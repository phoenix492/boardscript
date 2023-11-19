namespace BoardScriptCSharp {

    public class Program {

        public static void Main(string[] args) {



            var chessDictBuilder = PieceDictionary.GetPieceDictionaryBuilder();
            chessDictBuilder.Add(new PieceDefinition("R", "Rook"))
                            .Add(new PieceDefinition("P", "Pawn"))
                            .Add(new PieceDefinition("K", "King"))
                            .Add(new PieceDefinition("Q", "Queen"))
                            .Add(new PieceDefinition("N", "Knight"))
                            .Add(new PieceDefinition("B", "Bishop"));
            PieceDictionary chessDict = chessDictBuilder.Build();

            var chessRulesetBuilder = Ruleset.GetRulesetBuilder();
                chessRulesetBuilder.BoardWidth = 8;
                chessRulesetBuilder.BoardLength = 8;
                chessRulesetBuilder.PieceSet = chessDict;
                chessRulesetBuilder.InitialLayout = "wR.wN.wB.wQ.wK.wB.wN.wR-" +
                                                    "wP.wP.wP.wP.wP.wP.wP.wP-" +
                                                    "n.n.n.n.n.n.n.n-" +
                                                    "n.n.n.n.n.n.n.n-" +
                                                    "n.n.n.n.n.n.n.n-" +
                                                    "n.n.n.n.n.n.n.n-" +
                                                    "bP.bP.bP.bP.bP.bP.bP.bP-" +
                                                    "bR.bN.bB.bQ.bK.bB.bN.bR";
            Ruleset chessRules = chessRulesetBuilder.Compile();

        }
    }
}
