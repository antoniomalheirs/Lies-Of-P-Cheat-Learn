using System;
using Swed64;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LiesOfPCheatLearn
{
    internal class Player
    {
        private Swed readermen;

        private IntPtr baseptr;
        private IntPtr level2ptr;
        private IntPtr level3ptr;
        private IntPtr level4ptr;
        private IntPtr level5ptr;
        private IntPtr level6ptr;
        private IntPtr level7ptr;
        private IntPtr level8ptr;


        private int ergoobject = 0x07203780;
        private int vitalobject = 0x07203808;
        private int healthobject = 0x07196938;
        private int staminaobject = 0x0735BCC8;
        private int objectlegionarm = 0x07196938;
        private int objectfabulosattack = 0x07196938;

        public int[] ErgoCells = { 0x618, 0x648, 0xA0, 0xA4};
        public int[] VitalCells = { 0x180, 0x1A0, 0x0, 0x40 };
        public int[] Health = { 0x40, 0x110, 0x160, 0x40, 0xE0, 0x28, 0xC };
        public int[] Stamina = { 0x0, 0x20, 0x848, 0xE0, 0x28, 0x3C };
        public int[] LegionArm = { 0x10, 0x240, 0x848, 0xE0, 0x28, 0xCC };
        public int[] FabulosAttack = { 0x10, 0x240, 0x848, 0xE0, 0x28, 0x6C };

        private IntPtr ergocells;
        private IntPtr vitalcells;
        private IntPtr health;
        private IntPtr stamina;
        private IntPtr legionarm;
        private IntPtr fabulosattack;


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

        public IntPtr getStamina()
        {
            var fundPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(fundPtr, staminaobject);
            level2ptr = readermen.ReadPointer(baseptr, Stamina[0]);
            level3ptr = readermen.ReadPointer(level2ptr, Stamina[1]);
            level4ptr = readermen.ReadPointer(level3ptr, Stamina[2]);
            level5ptr = readermen.ReadPointer(level4ptr, Stamina[3]);
            level6ptr = readermen.ReadPointer(level5ptr, Stamina[4]);
            stamina = level6ptr;
            return stamina;
        }

        public IntPtr getlegionArm()
        {
            var fundPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(fundPtr, objectlegionarm);
            level2ptr = readermen.ReadPointer(baseptr, LegionArm[0]);
            level3ptr = readermen.ReadPointer(level2ptr, LegionArm[1]);
            level4ptr = readermen.ReadPointer(level3ptr, LegionArm[2]);
            level5ptr = readermen.ReadPointer(level4ptr, LegionArm[3]);
            level6ptr = readermen.ReadPointer(level5ptr, LegionArm[4]);
            legionarm = level6ptr;
            return legionarm;
        }

        public IntPtr getfabulosAttack()
        {
            var fundPtr = readermen.GetModuleBase(".exe");
            baseptr = readermen.ReadPointer(fundPtr, objectfabulosattack);
            level2ptr = readermen.ReadPointer(baseptr, FabulosAttack[0]);
            level3ptr = readermen.ReadPointer(level2ptr, FabulosAttack[1]);
            level4ptr = readermen.ReadPointer(level3ptr, FabulosAttack[2]);
            level5ptr = readermen.ReadPointer(level4ptr, FabulosAttack[3]);
            level6ptr = readermen.ReadPointer(level5ptr, FabulosAttack[4]);
            fabulosattack = level6ptr;
            return fabulosattack;
        }

    }
}
