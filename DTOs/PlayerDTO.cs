using System;
using System.Collections.Generic;
using Ragaio2.Entities;

namespace Ragaio2.DTOs
{
    public class PlayerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public static PlayerDTO[] MakeDTOs(Dictionary<Guid, Player> players)
        {
            List<PlayerDTO> dtos = new List<PlayerDTO>();
            
            foreach ((Guid id, Player player) in players)
            {
                dtos.Add(new PlayerDTO()
                { 
                    Id = id,
                    Name = player.Name
                });
            }

            return dtos.ToArray();
        }
    }
}