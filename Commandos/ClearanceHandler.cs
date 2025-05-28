namespace Commandos;

public class ClearanceHandler
{
    public static string GetName(string commanderRank, string name, string codeName)
    {
        switch (commanderRank.ToUpper())
        {
            case "GENERAL":
                return name;
            case "COLONEL":
                return codeName;
            default:
                return "Your level is too low to receive the information.";
        }
    }
}