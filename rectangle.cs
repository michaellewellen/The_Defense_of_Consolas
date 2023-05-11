





public class rectangle
{
 
    public rectangle(int x, int y, string z)
    {
        width = x;
        length = y;
        name = z;
        area = width * length;
        perimeter = 2 * width + 2 * length;
    }
    public double width;
    public double length;
    public string name;

    public double area;
    public double perimeter;
    public void DisplayArea()
    {
        Console.WriteLine($"The area of the {name} = {area}");
    }
    public void DisplayPerimeter()
    {
        Console.WriteLine($"The perimeter of the {name} = {perimeter}");
    }
    public void DefineRectangle()
    {
        Console.WriteLine($"The {name} is {width} x {length}");
    }


}