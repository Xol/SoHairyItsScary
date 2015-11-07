// Represents a coordinate: A point in a carthesic coordinate system
public class Coord {
	public Coord(int x, int z) {
		this.x = x;
		this.z = z;
	}

	public int x {get;set;}
	public int z {get;set;}

	public override string ToString()
	{
		return "x: " + this.x + ", y: " + this.z;
	}
}
