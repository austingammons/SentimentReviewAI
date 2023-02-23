using MyMLApp;

Console.WriteLine("Press q to quit");

bool quitFlag = false;
while (!quitFlag)
{
    Console.WriteLine("Write your review here:");
    string? input;
    input = Console.ReadLine();
    if (input == "q")
    {
        quitFlag = true;
    }
    else
    {
        var data = new SentimentModel.ModelInput()
        {
            Col0 = input!
        };

        var result = SentimentModel.Predict(data);
        var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
        Console.WriteLine($"Sentiment: {sentiment}\n");
    }
}