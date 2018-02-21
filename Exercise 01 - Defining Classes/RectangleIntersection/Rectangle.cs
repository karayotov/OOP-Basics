
public class Rectangle
{
    public string Id{ get; set; }
    public Coordinates TopLeftPoint { get; set; }
    public Coordinates BottomRightPoint { get; set; }

    public Rectangle()
    {

    }
    public Rectangle(string id, Coordinates topleft, Coordinates bottomRight)
    {
        Id = id;
        TopLeftPoint = topleft;
        BottomRightPoint = bottomRight;
    }
}
//Pesho 2 2 0 0
//id, width, height and the coordinates of its top left corner (horizontal and vertical)