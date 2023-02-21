namespace Exercise2;

public class Pedestrian
{
    private int id; 
    public Pedestrian(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    private void ReactToLight(string color)
    {
        string result = $"Pedestrian {id} ";
        switch (color)
        {
            case "GREEN":
                result += " Waiting to cross";
                break;
            case "YELLOW":
                result += " gets ready";
                break;
            case "RED":
                result += " RUN LIKE THE WIND";
                break;
        }
        Console.WriteLine(result);
    }
}