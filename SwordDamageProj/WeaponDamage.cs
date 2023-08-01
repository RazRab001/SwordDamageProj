using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageProj
{
    public class WeaponDamage
    {
        Random Random = new Random();

        public int Damage { get; protected set; }
        protected bool isFlame;
        protected bool isMagic;
        protected int Roll;
        private int roll_count;

        public float base_damage { get; init; }
        public float flame_damage { get; init; }
        public float magic_damage { get; init; }

        public WeaponDamage(int roll, float base_, float flame_, float magic_)
        {
            roll_count = roll;
            base_damage = base_;
            flame_damage = flame_;
            magic_damage = magic_;
            isFlame = false;
            isMagic = false;
        }
  
        public void Rolling()
        {
            Roll = 0;
            for(byte i = 0; i < roll_count; i++)
            {
                Roll += Random.Next(1, 7);
            }
            Calculate();
        }
        public bool IsFlame
        {
            get { return isFlame; }
            set { isFlame = value; Calculate(); }
        }
        public bool IsMagic
        {
            get { return isMagic; }
            set { isMagic = value; Calculate(); }
        }
        public virtual void Calculate() { }
    }
}
