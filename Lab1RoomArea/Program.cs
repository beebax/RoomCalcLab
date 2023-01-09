Console.WriteLine("Welcome to the Room Info Tool. All measurements are in feet.");
Console.WriteLine("");
Console.WriteLine("Please enter room length.");
double RoomLength = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter room width.");
double RoomWidth = double.Parse(Console.ReadLine());

double Area = RoomLength * RoomWidth;
double Perimeter = (RoomLength * 2) + (RoomWidth * 2);

Console.WriteLine("Area: " + Area);
Console.WriteLine("Perimeter: " + Perimeter);

if (Area < 251) { Console.WriteLine("This room is small."); }
else if (Area < 651) { Console.WriteLine("This room is medium."); }
else { Console.WriteLine("This room is large."); }

Console.WriteLine("Would you like to find the volume and surface area of the room? Press y to continue, any other key to exit.");
string WannaRestart = Console.ReadLine();

if (WannaRestart == "y")
{
    Console.WriteLine("Please enter room height.");
    double RoomHeight = double.Parse(Console.ReadLine());
    double Volume = RoomLength * RoomWidth * RoomHeight;
    Console.WriteLine("The volume of the room is " + Volume);

    double SurfaceArea = 2*(RoomWidth * RoomLength + RoomHeight * RoomLength + RoomHeight * RoomWidth);
    Console.WriteLine("The surface area of the room is " + SurfaceArea);
    Console.WriteLine("Thank you, goodbye.");
}
else { Console.WriteLine("Thank you, goodbye."); }
;

