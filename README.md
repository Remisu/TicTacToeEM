
# TicTacToeEM - Tic Tac Toe Game

## Project Overview

**TicTacToeEM** is a fully functional Tic Tac Toe game developed entirely for fun and without consulting external sources. The game was built using simple conditionals (`if`/`else` statements) and function calls to implement the core mechanics of Tic Tac Toe. Despite the straightforward approach, the game is fully operational and provides an enjoyable experience.

## Features

- **Player Turn Management**: Alternates between player 'X' and player 'O'.
- **Win Condition Checking**: The game checks for winning combinations after each move.
- **Score Tracking**: Keeps track of the score for both players.
- **Reset Board**: The board resets after a player wins, allowing for continuous play.

## Key Files and Classes

- `FrmTicTacToe.cs`: The main form and logic of the game. Handles player turns, button clicks, and win condition checking.
- `Functions.cs`: Contains helper functions for resetting the board and checking the winner.
- `FrmTicTacToe.Designer.cs`: The form designer file, which defines the layout of the buttons and score display.
- `Program.cs`: The entry point of the application, responsible for launching the game.

## How It Works

The game operates by alternating between player X and player O each turn. After each move, the game checks if there is a winner by comparing all possible winning combinations (rows, columns, and diagonals) using simple conditionals. If a winner is found, the game displays a message and resets the board. The scores are updated accordingly.

## How to Run

1. Clone the repository.
   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory and build the solution:
   ```bash
   cd TicTacToeEM
   dotnet build
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

## Project Structure

- **FrmTicTacToe.cs**: Contains the logic for handling button clicks and player moves.
- **Functions.cs**: Contains utility functions like resetting the board and checking for a winner.
- **Program.cs**: Initializes the game and launches the form.

## Tags

- `Tic Tac Toe`
- `C#`
- `Windows Forms`
- `Simple Conditionals`
- `Game Development`
- `Fun Project`
