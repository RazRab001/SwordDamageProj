using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageProj
{
    internal class SwordDamage : WeaponDamage
    {
        public SwordDamage() : base(3, 3, 2, 1.75f) { }
        public override void Calculate() 
        {
            double magicKoef = 1;
            if(IsMagic) { magicKoef = magic_damage; }
            Damage = (int)(Roll * magicKoef) + (int)base_damage;
            if(IsFlame ) { Damage += (int)flame_damage;}
        }
    }
}
