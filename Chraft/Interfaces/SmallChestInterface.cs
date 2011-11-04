﻿#region C#raft License
// This file is part of C#raft. Copyright C#raft Team 
// 
// C#raft is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chraft.World;

namespace Chraft.Interfaces
{
    public class SmallChestInterface : SingleContainerInterface
    {
        public SmallChestInterface(World.WorldManager world, UniversalCoords coords)
            : base(world, InterfaceType.Chest, coords, 27)
        {
        }

        public enum SmallChestSlots : short
        {
            ChestFirst = 0,
            ChestLast = 26,
            InventoryFirst = 27,
            InventoryLast = 53,
            QuickSlotFirst = 54,
            QuickSlotLast = 62
        }
    }
}
