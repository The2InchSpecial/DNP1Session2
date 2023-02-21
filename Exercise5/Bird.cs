namespace Exercise5;

public class Bird
{
    public Action<string> doesThings { get; set; }

    public void DoesSomething(string text)
    {
        Console.WriteLine(text);
        Thread.Sleep(500);
        doesThings?.Invoke(text);
    }
}