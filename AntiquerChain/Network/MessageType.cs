﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AntiquerChain.Network
{
    public enum MessageType : byte
    {
        #region Server
        
        HandShake = 0x00,
        Addr = 0x01,
        
        #endregion

        #region Surface
        
        SurfaceHandShake = 0x10,

        #endregion

        #region Transactions

        Inventory = 0x20,

        #endregion

        #region Others

        Ping = 0x30,
        Notice = 0x31,

        #endregion

    }
}
