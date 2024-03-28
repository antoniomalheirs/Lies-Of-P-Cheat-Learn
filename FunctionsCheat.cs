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




    }
}
