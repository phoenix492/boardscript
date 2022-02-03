# Questions
## Behavior (Solved: Modal) 
Let B be the board state, M be a move of a piece, and R be the current ruleset.
These variables are related by one of the below functions:

B(M), implying an internally managed board and ruleset

B(B, M), implying internally managed rules and a user provided board & move

B(R, B, M), implying user provided rules, board state, and move, with 
Boardscript's implementation serving only as a simple input output function. 

Which of these should be boardscript's behavior model?

B(M) is a monolithic continuously running program, requiring minimal input from
clients and managing everything itself. This limits flexibility heavily, but
it's in question whether that even matters. Boardscript is the game being 
played. 

B(B, M) requires loading only the irules of the game being played, allowing it 
to serve as a way of transforming boards that already exist according to a move
operation. Boardscript is an engine that facilitates the playing of games.

B(R, B, M) requires doing **more** but keeping track of **naught**. Boardscript
applies M transformation to B according to R, then terminates. Boardscript is a
stateless function. 

Upon thinking, it seems the only difference between these 3 is WHEN the board 
or rules are loaded. As such, it may be worth simply launching the program in 
3 different modes, "Game Mode," "Engine Mode," and "Function Mode" respectively
for the above functions of B. Polymorphism perhaps?

