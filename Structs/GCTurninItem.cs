﻿using System.Runtime.InteropServices;

namespace LlamaLibrary.Structs
{
    [StructLayout(LayoutKind.Explicit, Size = 0xA8)]
    public struct GCTurninItem
    {
        [FieldOffset(0)]
        public uint ItemID;

        [FieldOffset(4)]
        public uint XP;

        [FieldOffset(8)]
        public uint Seals;

        [FieldOffset(0x1a)]
        public byte ReqCount;
        
        [FieldOffset(0x1b)]
        public byte leftToHandIn;
        
        [FieldOffset(0x18)]
        private byte starred;

        public bool Starred => starred == 1;
        
        public bool CanHandin => leftToHandIn > 0;
    }
}