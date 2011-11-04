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
using Chraft.Entity;
using Chraft.Interfaces;
using Chraft.Plugins.Events.Args;

namespace Chraft.World.Blocks
{
    class BlockRedstoneRepeater : BlockBase
    {
        public BlockRedstoneRepeater()
        {
            Name = "RedstoneRepeater";
            Type = BlockData.Blocks.Redstone_Repeater;
            Opacity = 0x0;
            IsSolid = true;
            LootTable.Add(new ItemStack((short)BlockData.Items.Redstone_Repeater, 1));
            BlockBoundsOffset = new BoundingBox(0, 0, 0, 1, 0.125, 1);
        }
    }
}
