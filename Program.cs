double widthYard = 5;
double lengthYard = 5;
double widthTablet = 11;
double lengthTablet = 7;

Console.WriteLine($"The yard is {widthYard} x {lengthYard}");
Console.WriteLine($"The area of the yard = {widthYard * lengthYard}");
Console.WriteLine($"The perimeter of the yard = {2*widthYard + 2*lengthYard}");

Console.WriteLine($"The tablet is {widthTablet} x {lengthTablet}");
Console.WriteLine($"The area of the tablet = {widthTablet * lengthTablet}");
Console.WriteLine($"The perimeter of the tablet = {2*widthTablet + 2*lengthTablet}");



rectangle yard = new rectangle(5,5,"yard");
rectangle tablet = new rectangle(11,7,"tablet");

yard.DefineRectangle();
yard.DisplayArea();
yard.DisplayPerimeter();
tablet.DefineRectangle();
tablet.DisplayArea();
tablet.DisplayPerimeter();
