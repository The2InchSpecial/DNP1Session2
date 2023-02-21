using Exercise2;

TrafficLight tl = new();
new Car(tl, 1);
new Taxi(tl, 2);
new Pedestrian(tl, 3);
tl.RunTrafficLight();