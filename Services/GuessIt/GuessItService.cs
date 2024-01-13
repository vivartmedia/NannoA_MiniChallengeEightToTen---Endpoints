

namespace NannoA_MiniChallengeEightToTen___Endpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string EasyGuess(string InputNumber)
    {
        Random ranNum = new Random();
        int CorrectNum = ranNum.Next(1, 11);

        if ((int.TryParse(InputNumber, out int num)) && num <= 10 && num >= 1)
        {
            if (num < CorrectNum)
            {
                return $"Your guessed number was less than the random number: {CorrectNum}.";
            }
            else if (num > CorrectNum)
            {
                return $"Your guessed number was higher than the random number: {CorrectNum}.";
            }
            else
            {
                return "You guessed it; you won!";
            }
        }
        else
        {
            return "Invalid Number: Please enter a whole numbers between 1-10";
        }
    }
    public string MediumGuess(string InputNumber)
    {
        Random ranNum = new Random();
        int CorrectNum = ranNum.Next(1, 51);

        if ((int.TryParse(InputNumber, out int num)) && num <= 50 && num >= 1)
        {
            if (num < CorrectNum)
            {
                return $"Your guessed number was less than the random number: {CorrectNum}.";
            }
            else if (num > CorrectNum)
            {
                return $"Your guessed number was higher than the random number: {CorrectNum}.";
            }
            else
            {
                return "You guessed it; you won!";
            }
        }
        else
        {
            return "Invalid Number: Please enter a whole numbers between 1-50";
        }
    }
    public string HardGuess(string InputNumber)
    {
        Random ranNum = new Random();
        int CorrectNum = ranNum.Next(1, 101);

        if ((int.TryParse(InputNumber, out int num)) && num <= 100 && num >= 1)
        {
            if (num < CorrectNum)
            {
                return $"Your guessed number was less than the random number: {CorrectNum}.";
            }
            else if (num > CorrectNum)
            {
                return $"Your guessed number was higher than the random number: {CorrectNum}.";
            }
            else
            {
                return "You guessed it; you won!";
            }
        }
        else
        {
            return "Invalid Number: Please enter a whole numbers between 1-100";
        }
    }
}
