// See https://aka.ms/new-console-template for more information


using NaturalLanguageApp.Services;
using NaturalLanguageApp.Services.Processing;

Console.WriteLine("Hello, World!");

string file = @"key.json";

var json = File.ReadAllText(file);
var text = "Yaptıgım davranıstan dolayı çok utandım, bir daha tekrarlamıyacağım.";

NLPService service = new GoogleNLPService();
service.Confugure(json);
var sentiment = await service.AnalyzeSentimentAsync(text);


Console.WriteLine($"Score: {sentiment.Score}");
Console.WriteLine($"Magnitude: {sentiment.Magnitude}");






