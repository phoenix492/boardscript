# Boardscript
Boardscript is a text based format for encoding the layout, rules, and pieces of chesslike games.
Key design principles include:
- Completeness
- Simplicity
- Modularity

## Completeness
Boardscript should be able to encode any move on an NxM board. Exceptions once raised should be swiftly corrected in a revision.
Examples Include:
- NxM movement (2x3, 3x4, 1x2, etc) (Example: Knight's 2x3 movement in Chess)
- Vector Movement (Orthogonal, Diagonal, Forward/Back, etc) (Example: Rooks and Bishops in Chess)
- Turn Count Movement (Piece's first move, player's first move, etc) (Example: Pawn 2 squares forward in Chess)
- Piece Dependant Movement (Involving the state of other pieces) (Example: Cannon in Xiangqi)
- Moving Other Pieces 
- Any Combonation of the Above (Castling in Western Chess involves the state of the Rook and King, as well as moving both pieces)

## Simplicity 
BoardScript shouldn't be dense, hard to read, excessively short, excessively verbose, or anything that the average computer user who can edit a text file would find difficult to open and modify.
- No dense 4-tab indent trees of data
- As much data as possible should be simple key/value pairs
- Basically, it shouldn't be JSON.

## Modularity
Boardscript, ideally, should be a simple i-o program, taking inputs of moves and outputting board states. 
The exact nature of this IO is undecided, but the base boardscript implementation should **NOT**
- Provide a GUI
- Facilitate playing of games directly
- Contain hardcoded boards/pieces/rules

