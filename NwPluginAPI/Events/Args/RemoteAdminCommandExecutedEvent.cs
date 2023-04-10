using LiteNetLib;
using UnityEngine;

using AdminToys;
using PlayerRoles;
using Footprinting;
using CustomPlayerEffects;
using MapGeneration.Distributors;

using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;

using CommandSystem;
using PlayerStatsSystem;

using InventorySystem.Items;
using InventorySystem.Items.Radio;
using InventorySystem.Items.Pickups;
using InventorySystem.Items.Usables;
using InventorySystem.Items.Firearms;
using InventorySystem.Items.ThrowableProjectiles;

using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Core.Attributes;

using static BanHandler;
using static MapGeneration.Distributors.Scp079Generator;

namespace PluginAPI.Events
{
	public class RemoteAdminCommandExecutedEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.RemoteAdminCommandExecuted;
		[EventArgument]
		public ICommandSender Sender { get; }
		[EventArgument]
		public string Command { get; }
		[EventArgument]
		public string[] Arguments { get; }
		[EventArgument]
		public bool Result { get; }
		[EventArgument]
		public string Response { get; set; }

		public RemoteAdminCommandExecutedEvent(ICommandSender sender, string command, string[] arguments, bool result, string response)
		{
			Sender = sender;
			Command = command;
			Arguments = arguments;
			Result = result;
			Response = response;
		}
	}
}
