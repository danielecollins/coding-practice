using System;

public class Platformer
{
    private int numTiles;
    private int tile;
    private List<int> tileList = new List<int>();
    private int listPos;

    public Platformer(int numberOfTiles, int position)
    {
        numTiles = numberOfTiles;
        tile = position;
        listPos = position;

        for (int i = 0; i < numberOfTiles; i++)
        {
            tileList.Add(i);
        }
    }

    public void JumpLeft()
    {
        listPos = tileList.IndexOf(tile) - 2;
        tileList.RemoveAt(tileList.IndexOf(tile));
        tile = tileList.ElementAt(listPos);
    }

    public void JumpRight()
    {
        listPos = tileList.IndexOf(tile) + 2;
        tileList.RemoveAt(tileList.IndexOf(tile));
        tile = tileList.ElementAt(listPos - 1);
    }

    public int Position()
    {
        return tile;
    }

    public static void Main(string[] args)
    {
        Platformer platformer = new Platformer(6, 3);
        Console.WriteLine(platformer.Position()); // should print 3

        platformer.JumpLeft();
        Console.WriteLine(platformer.Position()); // should print 1

        platformer.JumpRight();
        Console.WriteLine(platformer.Position()); // should print 4
    }
}