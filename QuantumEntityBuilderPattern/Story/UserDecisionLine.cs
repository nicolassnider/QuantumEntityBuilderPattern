using System;
using QuantumEntityBuilderPattern.Entities;

namespace QuantumEntityBuilderPattern.Story;

/// <summary>
/// Represents a story element that pauses to ask the user a question before determining the outcome.
/// </summary>
public class UserDecisionLine : IQuantumStoryElement
{
    private readonly string _prompt;
    private readonly Action<bool> _onDecision;
    private readonly Func<bool, string> _resultTextFunc;

    public UserDecisionLine(string prompt, Action<bool> onDecision, Func<bool, string> resultTextFunc)
    {
        _prompt = prompt;
        _onDecision = onDecision;
        _resultTextFunc = resultTextFunc;
    }

    public string Render()
    {
        Console.Write($"\n> {_prompt} (y/n): ");
        bool decision = false;
        
        while (true)
        {
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                decision = true;
                break;
            }
            else if (key == ConsoleKey.N)
            {
                decision = false;
                break;
            }
            // If any other key, loop and wait
        }
        Console.WriteLine(); // move to next line after input
        
        _onDecision(decision);
        return _resultTextFunc(decision);
    }
}
