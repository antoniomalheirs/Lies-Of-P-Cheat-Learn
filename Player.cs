using System;
using Swed64;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiesOfPCheatLearn
{
    internal class Player
    {
        private Swed readermen;

        public IntPtr baseptr;
        public IntPtr level2ptr;
        public IntPtr level3ptr;
        public IntPtr level4ptr;

        public int playerobject = 0x07203780;
        public int[] ErgoCells = { 0x618, 0x648, 0xA0, 0xA4};

        private int ergocells;

        public Player()
        {
            readermen = new Swed("LOP-Win64-Shipping");
            var funPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(funPtr, playerobject);
        }

        public int getErgoCells()
        {
            level2ptr = readermen.ReadPointer(baseptr, ErgoCells[0]);
            level3ptr = readermen.ReadPointer(level2ptr, ErgoCells[1]);
            level4ptr = readermen.ReadPointer(level3ptr, ErgoCells[2]);
            ergocells = readermen.ReadInt(level4ptr, ErgoCells[3]);
            return ergocells;
        }

    }
}
