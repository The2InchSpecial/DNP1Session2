namespace Exercise5;

public class BirdWatcher
{
    public void WatchesBird(string s)
    {
        switch (s)
        {
            case "Flaps wings": Console.WriteLine("Fantastic!");
                break;
            case "Whistles": Console.WriteLine("truly amazing!");
                break;
            default: Console.WriteLine("Extraordinary!");
                break;
        }
    }
}