namespace Exercise4;

public class Car
{
    public string colour { get; set; }
    public double engineSize{ get; set; }
    public double fuelEconomy{ get; set; }
    public bool isManualShift{ get; set; }

    public Car(string colour, double engineSize, double fuelEconomy, bool isManualShift)
    {
        this.colour = colour;
        this.engineSize = engineSize;
        this.fuelEconomy = fuelEconomy;
        this.isManualShift = this.isManualShift;
    }

    public override string ToString()
    {
        string retStr = "Colour: " + colour + "\nengineSize: " + engineSize + "\nfuelEconomy:" + fuelEconomy +
                        "liter/100km";

        if (isManualShift)
        {
            retStr += "\nManual shift";
        }
        else
        {
            retStr += "\nAutomatic shift";
        }

        return retStr;
    }
    
    
}