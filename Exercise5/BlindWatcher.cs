namespace Exercise5;

public class BlindWatcher
{
    public void WatchesBird(string s)
    {
        switch (s)
        {
            case "Flaps wings": Console.WriteLine("Hear his wings!");
                break;
            case "Whistles": Console.WriteLine("truly amazing!");
                break;
            default: Console.WriteLine("Why is everyone excited?");
                break;
        }
    }
}