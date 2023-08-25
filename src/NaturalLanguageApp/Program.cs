// See https://aka.ms/new-console-template for more information


using NaturalLanguageApp.Services;
using NaturalLanguageApp.Services.Processing;

Console.WriteLine("Hello, World!");




var text =@"Jessica front in manager has no customer service. Their hot tub did not work and was like warm and half full Friday when checked in. Saturday it was empty. When I talked with her and asked for a partial refund, she basically called me a liar and said it was working when we checked in. I talked with another person before her and they said they had called for repairs from other complaints. Jessica never apologized just said no to a refund and I was wrong. So why was a repair man coming. Other things went bad as well and she does not give a crap.";

NLPService service = new MicrosoftNLPService();

var sentiment = await service.RunSentimentAnalyzeAsync(text);


Console.WriteLine($"Score: {sentiment.Score}");
Console.WriteLine($"Magnitude: {sentiment.Magnitude}");






