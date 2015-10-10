﻿using FSO.Common.DataService.Framework;
using FSO.Common.DataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Common.DataService.Providers.Server
{
    public class ServerLotProvider : LazyDataServiceProvider<uint, Lot>
    {
        protected override Lot LazyLoad(uint key)
        {
            var y = key >> 16;
            var x = key & 0x00FF;

            var lot = new Lot {
                Lot_Name = "My Lot",
                Lot_IsOnline = false,
                Lot_Location = new Location { Location_X = (ushort)x, Location_Y = (ushort)y },
                Lot_Price = 0,
                Lot_OwnerVec = new List<uint>() { },
                Lot_RoommateVec = new List<uint>() { },
                Lot_NumOccupants = 0
            };
            return lot;
        }
    }
}
