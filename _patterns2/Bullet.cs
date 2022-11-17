using System.Collections;
using UnityEngine;

namespace AsteroidGame
{
    public class BulletMove : Shooting
    {
        float speed = 10f;
        

        private void Update()
        {
            transform.Translate(Vector2.up* Time.deltaTime*speed);
        }
    }
}