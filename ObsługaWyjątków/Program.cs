public static double TrianglePerimeter(int a, int b, int c, int precision = 2)
{
    if (precision <= 1 || precision >= 9)
    {
        throw new ArgumentOutOfRangeException("wrong arguments");

    }
    if (a < 0 || b < 0 || c < 0)
    {
        throw new ArgumentOutOfRangeException("wrong arguments");
    }

    if (a + b < c || a + c < b || c + b < a)
    {
        throw new ArgumentException("object not exists");
    }
    double obwod = a + b + c;
    return obwod;
}