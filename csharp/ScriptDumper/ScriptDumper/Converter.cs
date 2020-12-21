using System;
using System.Diagnostics;

namespace ScriptDumper
{
    public static class Converter
    {
        public static Byte BmToBp(Byte bp)
        {
            Debug.Assert(bp == 0x01 || bp == 0x02 || bp == 0x04 || bp == 0x08 ||
                         bp == 0x10 || bp == 0x20 || bp == 0x40 || bp == 0x80);
            return bp switch
            {
                0x01 => 0,
                0x02 => 1,
                0x04 => 2,
                0x08 => 3,
                0x10 => 4,
                0x20 => 5,
                0x40 => 6,
                0x80 => 7,
                _ => 0xff
            };
        }
    }
}