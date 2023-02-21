namespace Exercise3;

public class Patient
{
    private int numberInQueue;
    private WaitingRoom wr;

    public Patient(WaitingRoom wr)
    {
        this.wr = wr;
        wr.NumberChange += ReactToNumber;
        numberInQueue = wr.DrawNumber();
    }

    private void ReactToNumber(int ticketNumber)
    {
        Console.WriteLine($"patient "+ numberInQueue + " looks up to check their number");
        if (numberInQueue == ticketNumber)
        {
            Console.WriteLine("patient " + numberInQueue +" goes to doctor");
            wr.NumberChange -= ReactToNumber;
        }
        else
        {
            Console.WriteLine("Patient "+numberInQueue+" goes back to his phone");
        }
    }
}