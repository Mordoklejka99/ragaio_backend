using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Ragaio2.DTOs;
using Ragaio2.Entities;

namespace Ragaio2.Hubs
{
    public class ClientHub : Hub<IClient>
    {
        public IActionResult AddPlayer(string name)
        {
            Game.Players.Add(Guid.NewGuid(), new Player(name));

            // for (int i = 0; i < Game.Players.Count; i++)
            //     Console.WriteLine($"{i}: {Game.Players[i].Name}");

            return new OkResult();
        }

        public Task GetPlayers()
        {
            return Clients.Caller.receivePlayers(PlayerDTO.MakeDTOs(Game.Players));
        }
    }
}