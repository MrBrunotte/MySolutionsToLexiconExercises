using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Creature : IDrawable
{
    private int health;
    public int Health
    {
        get { return health <= 0 ? 0 : health; }     // if healthe is less or equal to 0 return 0 otherwise return health
        set
        {
            if(value >= MaxHealth)
            {
                health = MaxHealth;
            }
            else
            {
                health = value;
            }
        }
    }
    public ConsoleColor Color { get; set; } = ConsoleColor.Green;
    public string Symbol { get; }
    public Cell Cell { get; set; }
    public int MaxHealth { get; private set; }
    public int Damage { get; set; } = 10;
    public bool IsDead => Health <= 0;


    public Creature(Cell cell, string symbol, int maxHealth)
    {
        Cell = cell;
        Symbol = symbol;
        MaxHealth = maxHealth;
    }


}
