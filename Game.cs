using System;
using System.Collections.Generic;
using Ragaio2.Entities;

namespace Ragaio2
{
    public static class Game
    {
        public static Dictionary<Guid, Player> Players { get; }

        static Game()
        {
            Players = new Dictionary<Guid, Player>();
        }
    }
}