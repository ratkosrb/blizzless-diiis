﻿//Blizzless Project 2022 
using DiIiS_NA.GameServer.Core.Types.TagMap;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.MessageSystem;

namespace DiIiS_NA.GameServer.GSSystem.ActorSystem.Implementations
{
    [HandledSNO(114074)]
    class Hope : InteractiveNPC
    {
        public Hope(MapSystem.World world, int snoId, TagMap tags)
            : base(world, snoId, tags)
        {
            this.Field7 = 1;
            this.Attributes[GameAttribute.TeamID] = 2;
        }

    }
}
