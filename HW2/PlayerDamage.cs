using System.Collections;
using UnityEngine;

namespace AsteroidGame
{
    public class PlayerDamage : Player, IDamagable
    {       
        void IDamagable.Damage()
        {
            throw new System.NotImplementedException();
        }
    }
}