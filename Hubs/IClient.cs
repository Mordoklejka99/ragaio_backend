using System.Collections.Generic;
using System.Threading.Tasks;
using Ragaio2.DTOs;
using Ragaio2.Entities;

namespace Ragaio2.Hubs
{
    public interface IClient
    {
        Task receivePlayers(PlayerDTO[] players);
    }
}