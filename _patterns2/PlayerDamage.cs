using System.Collections;
using UnityEngine;

namespace AsteroidGame
{
    public class PlayerDamage : Player, IDamagable
    {
        float curDamage = 5f;
        float curHealth = 100f;
        
        public void Damage()
        {
            curHealth -= curDamage;
            {
                if (curHealth<=0)
                {
                    Time.timeScale = 0;
                }
            }
        }
    }
}