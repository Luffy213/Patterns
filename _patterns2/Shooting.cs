using System.Collections;
using UnityEngine;


namespace AsteroidGame
{
    public class Shooting : Player
    {
        Transform _spawnPos;
        GameObject bullet;

        private void Update()
        {
            GameObject Shooting = Instantiate(bullet, _spawnPos.position, Quaternion.identity);
        }

    }
}