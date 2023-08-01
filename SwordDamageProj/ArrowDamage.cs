using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageProj
{
    internal class ArrowDamage : WeaponDamage
    {
        public ArrowDamage() : base(1, 0.35f, 1.25f, 2.5f) { }
        public override void Calculate()
        {
            float magicKoef = 1;
            float flameKoef = 0;
            if(isMagic) { magicKoef = magic_damage; }
            if(isFlame) { flameKoef = flame_damage; }
            Damage = (int)(Roll*base_damage*magicKoef + flameKoef);
        }
    }
}
