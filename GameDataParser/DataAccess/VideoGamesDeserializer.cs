using System.Text.Json;

public class VideoGamesDeserializer: IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public List<VideoGame> DeseriealizeFrom(string fileName, string fileContents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException e)
        {
            var defaultConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            _userInteractor.PrintMessage($"JSON in {fileName} file was not in a valid format. Json body:");
            _userInteractor.PrintMessage(fileContents);
            Console.ForegroundColor = defaultConsoleColor;

            throw new JsonException($"{e.Message} The file is: {fileName}", e);
        }
    }


}