using Exercise5;

Bird b1 = new Bird();
BirdWatcher bw = new BirdWatcher();
BlindWatcher blw = new BlindWatcher();
DeafWatcher dw = new DeafWatcher();
Random r = new Random();

b1.doesThings += bw.WatchesBird;
b1.doesThings += blw.WatchesBird;
b1.doesThings += dw.WatchesBird;

while (true)
{
    int rand = (int)r.Next(1, 4);
    switch (rand)
    {
        case 1: b1.DoesSomething("Flaps wings");
            break;
        case 2: b1.DoesSomething("Whistles");
            break;
        default: b1.DoesSomething("Performs a mating dance");
            break;
    }
    Thread.Sleep(2000);
}
