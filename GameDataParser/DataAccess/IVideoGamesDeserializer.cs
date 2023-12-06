
public interface IVideoGamesDeserializer
{
    List<VideoGame> DeseriealizeFrom(string fileName, string fileContents);
}