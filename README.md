# Mastermind Game (C# Console Application)

This project is a console-based implementation of the classic Mastermind game, created for the Steer Elite Internship Program - Gameplay Programming Track.

## 🎮 Game Overview

- The game generates a secret 4-digit code (or accepts one via command line).
- The digits are from `0` to `8`, and **must be distinct**.
- The player has a limited number of attempts (default: 10) to guess the code.
- After each guess, the game shows:
  - `Well placed pieces`: Correct digits in the correct position.
  - `Misplaced pieces`: Correct digits but in the wrong position.
- If the code is guessed correctly, the game ends with:  
  **"Congratz! You did it!"**

## 🛠 How to Run

From Windows Terminal / CMD:


### Parameters:
- `-c "1234"` (optional): Provide a secret code.
- `-t 12` (optional): Set the number of attempts (default is 10).

If `-c` is not provided, the game generates a random code with 4 unique digits.

## ⌨️ Input & Output

- Input guesses via keyboard (Console.ReadLine).
- To exit the game early, press `Ctrl + D` (EOF).
- If input is invalid (not 4 distinct digits between 0-8), it shows:


## ✅ Features

- Object-Oriented structure using classes and encapsulation.
- Input validation and user-friendly error handling.
- Random code generation when no `-c` is given.
- Clean and readable codebase.

## 📦 Structure

- `Program.cs`: Entry point and argument parsing
- `Game.cs`: Game loop and logic
- `Validator.cs`: Input/code validation
- `CodeGenerator.cs`: Random code generator
- `CodeChecker.cs`: Core logic to compare guesses

## 💻 Requirements

- .NET SDK (Core or later)
- Windows Console / Terminal

## 👨‍💻 Author

Created by [Abdulaziz mohammed almutairi] for Steer Elite Internship Program (2025)  
GitHub: [https://github.com/AbdulazizDev00/SteerEliteMastermind]

