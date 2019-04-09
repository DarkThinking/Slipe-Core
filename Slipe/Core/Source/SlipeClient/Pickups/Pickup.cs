﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using System.Numerics;
using Slipe.Shared.Weapons;
using Slipe.Shared.Pickups;
using System.ComponentModel;

namespace Slipe.Client.Pickups
{
    /// <summary>
    /// Class for a GTA pickup
    /// </summary>
    public class Pickup : SharedPickup
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pickup(MtaElement element) : base(element) { }

        /// <summary>
        /// Creates a pickup from the base createPickup paramters
        /// </summary>
        public Pickup(Vector3 position, PickupType type, int amount, int ammo = 50) : base(position, type, amount, 0, ammo) { }

        /// <summary>
        /// Creates a weapon pickup
        /// </summary>
        public Pickup(Vector3 position, SharedWeaponModel weapon, int ammo = 50) : base(position, PickupType.Weapon, weapon.ID, 0, ammo) { }

        /// <summary>
        /// Creates a custom model pickup
        /// </summary>
        public Pickup(Vector3 position, PickupModel model) : base(position, PickupType.Custom, (int)model) { }

        /// <summary>
        /// Creates a model pickup from any model ID
        /// </summary>
        public Pickup(Vector3 position, int model) : base(position, PickupType.Custom, model) { }
    }
}