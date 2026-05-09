using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Beadandó_SnusszWebShop
{
    public class Snussz : ICloneable
    {
        public string Marka { get; set; }
        public string Iz { get; set; }
        public int NikotinMg { get; set; }
        public int SnusszMaradt { get; set; }

        public Snussz(string marka, string iz,  int nikotinMg)
        {
            Marka = marka;
            Iz = iz;
            NikotinMg = nikotinMg;
            SnusszMaradt = 20;
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void SnusszElvesz()
        {
            if (SnusszMaradt > 0)
            {
                SnusszMaradt --;
            }
        }

        public override string ToString()
        {
            return $"{Marka} {Iz} ({NikotinMg}mg/g) - Tasak mennyisége : {SnusszMaradt}/20 mg";

        }
    }
}