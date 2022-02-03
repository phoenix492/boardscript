# Stages
Original Boardscript development will take place over multiple stages. The 
first task will be to get a working input/output function and a CLI that can
interface with that function. Then work can begin on making games playable.

- Stage 1: Should be basic input/output system
- Stage 2: Basic rules of chess are able to be applied to a board in B(M) mode.
This excludes rules like En Passant and Castling. Hardcoding them may work for
now, but as soon as possible...
- Stage 3: Develop a system to input rulesets into the game. Have boardscript 
pull in this ruleset. Move chess rules out of boardscript into a ruleset.
- Stage 4: Finish work on boardscript. Add B(B, M) and B(R, B, M) modes. All 
further extensions should be exclusively to the compenent responsible for 
handling rulesets. 
- Stage 5: Expand ruleset capabilites to make En Passant and Castling possible.

The program is now capable of encoding standard Western chess, and as such is 
"Complete," further extensions should now be focused on increasing flexability
and ability of Rulesets. Below are ideas for various quality of life and 
extension ideas.

- Development of UCI compatability layer is now an option.
- Add M(R, B) mode.
- Expand ruleset's capabilites to encode the 10 variants listed in
this paper: https://arxiv.org/pdf/2009.04374.pdf , I believe this to be a good 
baseline for the programs ability to be flexible. 
- Make it possible to play Shogi, this involves somehow keeping track
of taken pieces. 
- add Xiangqi
