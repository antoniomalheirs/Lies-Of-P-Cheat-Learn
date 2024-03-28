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
        public IntPtr level5ptr;
        public IntPtr level6ptr;
        public IntPtr level7ptr;
        public IntPtr level8ptr;


        public int ergoobject = 0x07203780;
        public int vitalobject = 0x07203808;
        public int healthobject = 0x07196938;

        public int[] ErgoCells = { 0x618, 0x648, 0xA0, 0xA4};
        public int[] VitalCells = { 0x180, 0x1A0, 0x0, 0x40 };
        public int[] Health = { 0x40, 0x110, 0x160, 0x40, 0xE0, 0x28, 0xC };

        private IntPtr ergocells;
        private IntPtr vitalcells;
        private IntPtr health;


        public Player()
        {
            readermen = new Swed("LOP-Win64-Shipping");
        }

        public IntPtr getErgoCells()
        {
            var funPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(funPtr, ergoobject);
            level2ptr = readermen.ReadPointer(baseptr, ErgoCells[0]);
            level3ptr = readermen.ReadPointer(level2ptr, ErgoCells[1]);
            level4ptr = readermen.ReadPointer(level3ptr, ErgoCells[2]);
            ergocells = level4ptr;
            return ergocells;
        }

        public IntPtr getVitalCells()
        {
            var funPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(funPtr, vitalobject);
            level2ptr = readermen.ReadPointer(baseptr, VitalCells[0]);
            level3ptr = readermen.ReadPointer(level2ptr, VitalCells[1]);
            level4ptr = readermen.ReadPointer(level3ptr, VitalCells[2]);
            vitalcells = level4ptr;
            return vitalcells;
        }

        public IntPtr getHealth()
        {
            var funPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(funPtr, healthobject);
            level2ptr = readermen.ReadPointer(baseptr, Health[0]);
            level3ptr = readermen.ReadPointer(level2ptr, Health[1]);
            level4ptr = readermen.ReadPointer(level3ptr, Health[2]);
            level5ptr = readermen.ReadPointer(level4ptr, Health[3]);
            level6ptr = readermen.ReadPointer(level5ptr, Health[4]);
            level7ptr = readermen.ReadPointer(level6ptr, Health[5]);
            health = level7ptr;
            return health;
        }
    }
}
