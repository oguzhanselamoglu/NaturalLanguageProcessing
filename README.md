# NaturalLanguageProcessing
Sentiment, Entity and Syntax analysis in net core

# Google

The Google Cloud [Natural Language API](https://cloud.google.com/natural-language/docs/)  provides natural language understanding technologies to developers, including sentiment analysis, entity analysis, and syntax analysis.

## Enable the Natural Language API
- Sign-in to the [Google Cloud Console](http://console.cloud.google.com/) and create a new project or reuse an existing one. If you don't already have a Gmail or Google Workspace account, you must create one.
- You'll need to enable billing in the Cloud Console to use Cloud resources/APIs.

## Authentication
For authentication you can authenticate by downloading a service account JSON file and setting the GOOGLE_APPLICATION_CREDENTIALS environment variable to refer to it. This will tell your code to use the credentials in the JSON file to authenticate your API calls.
- Go to the [Google Cloud Console](http://console.cloud.google.com/)
- Click the Credentials tab.
- Click the Create credentials button and select Service account key.
- Select the JSON key type and click the Create button.
- Download the JSON file to your computer.

# Google Nuget Package
- dotnet add package Google.Cloud.Language.V1
```bash 
        static void Main(string[] args)
        {
            var text = "Yukihiro Matsumoto is great!";
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeSentiment(Document.FromPlainText(text));
            var sentiment = response.DocumentSentiment;
            Console.WriteLine($"Score: {sentiment.Score}");
            Console.WriteLine($"Magnitude: {sentiment.Magnitude}");
        }
```