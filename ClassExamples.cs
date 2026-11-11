class Car
{
    public string color;
    public int model;
    public string name;

    public Car(int carModel, string carName, string carColor="White")
    {
        name = carName;
        color = carColor;
        model = carModel;
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Your {name} car info: ");
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Model: " + model);
    }
}