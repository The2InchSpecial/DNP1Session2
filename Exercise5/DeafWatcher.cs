namespace Exercise5;

public class DeafWatcher
{
    public void WatchesBird(string s)
    {
        switch (s)
        {
            case "Flaps wings": Console.WriteLine("Fantastic!");
                break;
            case "Whistles": Console.WriteLine("I wish i could hear :(");
                break;
            default: Console.WriteLine("Extraordinary!");
                break;
        }
    }
}