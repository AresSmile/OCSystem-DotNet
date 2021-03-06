﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyChain.Core {
    public static class BlockChainTimestamp {
        public static readonly DateTime GenesisDateTime = new DateTime(2020, 6, 1);

        public static uint ToTimestamp(DateTime dateTime) {
            TimeSpan timeSpan = dateTime - GenesisDateTime;
            return (uint)Math.Round(timeSpan.TotalSeconds);
        }

        public static DateTime ToDateTime(uint timestamp) {
            return GenesisDateTime + TimeSpan.FromSeconds(timestamp);
        }
    }
}
