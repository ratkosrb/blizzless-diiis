﻿//Blizzless Project 2022 
using DiIiS_NA.GameServer.GSSystem.ActorSystem.Movement;
//Blizzless Project 2022 
using System;

namespace DiIiS_NA.GameServer.GSSystem.QuestSystem.QuestEvents.Implementations
{
	class LeahTransformation_Line11 : QuestEvent
	{
		public bool raised = false;

		public LeahTransformation_Line11()
			: base(0)
		{
		}

		public override void Execute(MapSystem.World world)
		{
			StartConversation(world, 195767);
			var Leah = world.GetActorBySNO(195376);
			Leah.PlayActionAnimation(201990);
		}

		private bool StartConversation(MapSystem.World world, Int32 conversationId)
		{
			foreach (var player in world.Players)
			{
				player.Value.Conversations.StartConversation(conversationId);
			}
			return true;
		}

	}
}
