namespace Exercise3;

public class WaitingRoom
{
    public Action<int> NumberChange;
    private int currentNumber = 0;
    private int ticketCount = 0;

    public void RunWaitingRoom()
    {
        while (currentNumber < ticketCount)
        {
            currentNumber++;
            Console.WriteLine($"Patient number "+currentNumber+" can now enter");
            NumberChange.Invoke(currentNumber);
            Thread.Sleep(1000);
            
        }
    }

    public int DrawNumber()
    {
        ticketCount++;
        return ticketCount;
    }
}