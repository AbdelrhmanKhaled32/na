using System;

class Dice
{
    private readonly int sides;

    public Dice(int sides)
    {
        this.sides = sides;
    }

    public int GetRoll()
    {
        Random rand = new Random();
        return rand.Next(1, sides + 1);
    }
}