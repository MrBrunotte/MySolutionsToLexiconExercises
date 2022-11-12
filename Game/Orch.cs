using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Orch : Creature
{
    public Orch(Cell cell, int maxHealth)
        : base(cell, "O ", 50)
    {
        Damage = 25;
        Color = ConsoleColor.Green;
    }
}
