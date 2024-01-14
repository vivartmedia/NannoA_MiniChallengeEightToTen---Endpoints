
namespace NannoA_MiniChallengeEightToTen___Endpoints.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string Magic8Ball()
    {
        string[] responses = {
            "Yes, definitely.",
            "It is certain.",
            "As I see it, yes.",
            "Most likely.",
            "Outlook good.",
            "Yes.",
            "Signs point to yes.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Cannot predict now."
        };

        Random random = new Random();
        int index = random.Next(responses.Length);
        return "Magic 8-Ball says: " + responses[index];
    }
}
