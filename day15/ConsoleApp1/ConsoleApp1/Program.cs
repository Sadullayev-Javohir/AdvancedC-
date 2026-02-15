//Point p;
//p.X = 10;
//p.Y = 20;
//Console.WriteLine(p.X + p.Y);
//Console.ReadLine();
//struct Point
//{
//    public int X;
//    public int Y;
//}
//class Car
//{
//    public Point Location;
//}

//Direction d = Direction.Down;
//Console.WriteLine((int)d);
//Console.ReadLine();

//enum Direction
//{
//    Left,Right,Up,Down
//}

Point a = new Point { X = 5, Y = 6 };
Point b = a;
b.X = 100;
Console.WriteLine(a.X);
Console.WriteLine(b.X);

struct Point
{
    public int X;
    public int Y;
}

