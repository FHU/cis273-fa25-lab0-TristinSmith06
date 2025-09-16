namespace Vector;

public struct Vector
{
    public double X { get; set; }

    public double Y { get; set; }

    // public double Magnitude { get { return Math.Sqrt(X * X + Y * Y); } }

    public double Magnitude => Math.Sqrt(X * X + Y * Y);

    public double Direction => Math.Atan2(Y, X) * 180 / Math.PI;

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }


    // Instance methods 
    public Vector Add(Vector v)
    {
        return new Vector(X + v.X, Y + v.Y);
    }
    public Vector Subtract(Vector v)
    {
        Vector diffVector = new Vector();
        diffVector.X = X - v.X;
        diffVector.Y = Y - v.Y;

        return diffVector;
    }
    public double Dot(Vector v)
    {
        return X * v.X + Y * v.Y;

    }
    public double AngleBetween(Vector v)
    {
        double numerator = Dot(v);
        double denominator = Magnitude * v.Magnitude;
        double frac = Math.Acos(numerator / denominator);
        return frac * 180 / Math.PI;

    }

    public Vector Multiply(double scalar)
    {
        Vector result = new Vector();
        result.X *= scalar;
        result.Y *= scalar;

        return result;
    }

    public Vector Divide(double scalar)
    {
        Vector result = new Vector();
        result.X /= scalar;
        result.Y /= scalar;

        return result;
    }

    public Vector Normalize()
    {
        return Divide(Magnitude);
    }

    // Class (static) methods 
    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);

    }

    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }

    public static Vector Multiply(Vector v, double scalar)
    {
        return v.Multiply(scalar);
    }

    public static Vector Divide(Vector v, double scalar)
    {
        return v.Divide(scalar);
    }

    public static Vector Normalize(Vector v)
    {
        return Normalize(v);
    }

    // Overloaded operators 
    public static Vector operator +(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }

    public static Vector operator *(Vector v1, double scalar)
    {
        return v1.Multiply(scalar);
    }

    public static Vector operator /(Vector v1, double scalar)
    {
        return v1.Divide(scalar);
    }

    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }


}