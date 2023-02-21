namespace Exercise2;

public class Taxi
{
    private int id; 
    public Taxi(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    private void ReactToLight(string color)
    {
        string result = $"Taxi {id} ";
        switch (color)
        {
            case "GREEN":
                result += " Races across";
                break;
            case "YELLOW":
                result += " Races across yelling: TAXI GREEN!";
                break;
            case "RED":
                result += " Stops with screeching tires";
                break;
        }
        Console.WriteLine(result);
    }
}