# Principles
## Modal
Boardscript should have 3 modes, defined as follows.
Let B be the state of a board, M be a move to be applied to that board, and R 
be the ruleset for the game being played on that board. 

Boardscript's three modes are defined by the behavior of the multivariable 
function B(xyz).

B(M) : Game Mode : Boardscript keeps internal track of the boardstate _and_ 
the rules. Moves are provided by the user. In this mode, boardscript is 
effectively the game that is being played.

B(B, M) : Engine Mode : Boardscript keeps internal track only of the rules of 
the game. Boardstates and the moves to be applied to them are passed in. In 
theory, one Boardscript instance could serve as an "engine" for several games.

B(R, B, M) : Function Mode : Boardscript applies M transformation to B 
boardstate according to R rules. Boardscript is effectively a deterministic
stateless I/O function.

Boardscript _may_ have a fourth mode with a non-boardstate output, M(R, B) 
where it calculates and outputs every legal move in boardstate B according to 
R rules. I'll _creatively_ refer to it as "Calculate Mode."
