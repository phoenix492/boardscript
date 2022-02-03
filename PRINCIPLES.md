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

## Data Structure
There are three main data structures that Boardscript should operate on.
These are the Move, the Boardstate, and the Ruleset. Deliberation on the "Move"
structure reveals the need for internal, non-operand structures. Of these are 
the "Action," and components of the ruleset. 

Each Data Structure presents its own unique challeneges.
- Moves are simple strings, but how can boardscript parse them?
- Boardstates provide simple i/o info about the board, but how does boardscript 
apply M transformation to the board with R ruleset. 
- Rulesets are the primary source of customization and complexity in the
project. How does boardscript take the user facing files, and parse them into 
the program. Should these files be compiled into a more machine friendly format
(JSON?) At what point would the user prefer editing these awful JSON files 
directly? 

### Move 
- This can be a simple string. Move notation from chess provides the 
inspiration. "Ke2" is a direction to move the piece designated "K" to square 
"e2." 
- However, this begs the question, how should Boardscript parse moves? There 
are only so many symbols to assign to pieces. The chariot in Xi Qinyang is 
commonly designated with "Ch" instead of just a single letter, potentially 
muddying where "piece" ends and "square" ends.
- There are options. The safest way is to require moves to be formated as 
(Piece)-[Actions]-(Square). For example, "Knight to e5" in chess notation would
be "Ne5" while in this notation it would be "Knight-m-e5."
- A fun way to try for compatability with things like Stockfish and other Chess 
standards would be to create a translation layer between the two that converts 
something like "O-O-O" into "King-c-g1"
- Actions require their own internal data structure defined below.

### Actions
- Boths Boardscript builtins and Ruleset defined custom actions
- Boardscript builtins are basic and should be expanded through requests and
revisions. (takes, move, etc)
- Ruleset actions should be combonations of these basic moves, which can be
conditional and complex. (Castling invloves the _condition_ of an unmoved king 
and rook, _move_ the king 2 or 3 spaces right/left, _move_ the rook the same 
amount of spaces left/right + 1. 

### Boardstates
- Boardstates are extremely simple. They provide information about the pieces 
on the board.
- Internally can likely be represented as a 2d "array" of objects. One for each
space and can contain pieces.
- Externally should be a string, possibly similar to PGN or FEN notation but 
with the expansions from **Move** taken into account. 
- The Chess Compat Layer could convert this string to/from PGN or FEN notation.

### Rulesets
- These are the most fundamentally complex part of this entire project.
- These are the way through which users define custom games and encompass 90%
of the program's functionality
- On the most basic level, must define board size(s), pieces (along with their
legal moves and custom actions) and an initial setup for B(M). 
