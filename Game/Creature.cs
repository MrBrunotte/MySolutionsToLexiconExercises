﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Creature : IDrawable
{
    public ConsoleColor Color { get; set; } = ConsoleColor.Green;
    public string Symbol { get; }
    public Cell Cell { get; set; }

    public Creature(Cell cell, string symbol)
    {
        Cell = cell;
        Symbol = symbol;
    }


}
