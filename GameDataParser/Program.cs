var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFileReader());
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception e)
{
    Console.WriteLine("Sorry! the application has experienced an unexpected error and will have to close.");
    logger.Log(e);
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();