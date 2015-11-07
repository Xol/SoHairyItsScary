// Represents a coordinate: A point in a carthesic coordinate system
public class Coord {
	public Coord(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public int x {get;set;}
	public int y {get;set;}

	public override string ToString()
	{
		return "x: " + this.x + ", y: " + this.y;
	}
}
