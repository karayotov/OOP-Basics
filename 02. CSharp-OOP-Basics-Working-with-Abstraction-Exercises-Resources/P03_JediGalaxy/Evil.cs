public class Evil
{
    Coordinates location;
    Coordinates Location { get => location; set => location = value; }

    public Evil()
    {
        Location = location;
    }

    public Evil(Coordinates loc)
    {
        Location = loc;
    }

    public void RemoveStars(Space galaxy)
    {
        var matrix = galaxy.Matrix;
        while (Location.Row >= 0 && Location.Col >= 0)
        {
            if (Location.Row >= 0 && Location.Row < matrix.GetLength(0) && Location.Col >= 0 && Location.Col < matrix.GetLength(1))
            {
                matrix[Location.Row, Location.Col] = 0;
            }
            Location.Row--;
            Location.Col--;
        }
        
    }
}