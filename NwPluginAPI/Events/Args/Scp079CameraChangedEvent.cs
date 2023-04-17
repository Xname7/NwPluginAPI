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
using PlayerRoles.PlayableScps.Scp079.Cameras;

namespace PluginAPI.Events
{
	public class Scp079CameraChangedEvent : IEventArguments
	{
		public ServerEventType BaseType { get; } = ServerEventType.Scp079CameraChanged;
		[EventArgument]
		public Player Player { get; }
		[EventArgument]
		public Scp079Camera Camera { get; }

		public Scp079CameraChangedEvent(ReferenceHub hub, Scp079Camera camera)
		{
			Player = Player.Get(hub);
			Camera = camera;
		}

		Scp079CameraChangedEvent() { }
	}
}
