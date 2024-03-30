using Swed64;
using System;
using System.Numerics;

namespace LiesOfPCheatLearn
{
    internal class Injetor
    {
        private Swed readermen;

        private readonly Player player = new Player();

        public Injetor()
        {
            readermen = new Swed("LOP-Win64-Shipping");
        }

        public void frezErgoCells(IntPtr pointer , int offset ,int ergos)
        {
            readermen.WriteInt(pointer+offset, ergos);
        }

        public void frezVitalCells(IntPtr pointer, int offset, int vital)
        {
            readermen.WriteInt(pointer+offset, vital);
        }

        public void frezHealth(IntPtr pointer, int offset, int health)
        {
            readermen.WriteInt(pointer+offset, health);
        }

        public void frezStamina(IntPtr pointer, int offset, int stamina)
        {
            readermen.WriteInt(pointer+offset, stamina);
        }

        public void frezlegionArm(IntPtr pointer, int offset, int armcount)
        {
            readermen.WriteInt(pointer + offset, armcount);
        }
        public void frezfabulosAttack(IntPtr pointer, int offset, int fabuloscount)
        {
            readermen.WriteInt(pointer + offset, fabuloscount);
        }

        public int getErgoCells(IntPtr pointer, int offset)
        {
            return readermen.ReadInt(pointer + offset);
        }

        public int getVitalCells(IntPtr pointer, int offset)
        {
            return readermen.ReadInt(pointer + offset);
        }

        public int getHealth(IntPtr pointer, int offset)
        {
            return readermen.ReadInt(pointer + offset);
        }

        public int getStamina(IntPtr pointer, int offset)
        {
            return  readermen.ReadInt(pointer + offset);
        }

        public int getLegionArm(IntPtr pointer, int offset)
        {
            return readermen.ReadInt(pointer + offset);
        }

        public int getFabulosAttack(IntPtr pointer, int offset)
        {
            return readermen.ReadInt(pointer + offset);
        }
    }
}
