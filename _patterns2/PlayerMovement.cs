using System.Collections;
using UnityEngine;

namespace AsteroidGame
{
    public class PlayerMovement : Player
    {
        private new Rigidbody2D rigidbody;
        private float speed = 5f;

        private void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }


         void Update()
        {

            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.AddForce(new Vector2(0f, 3f) * (speed * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rigidbody.AddForce(new Vector2(-3f, 0f) * (speed * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(new Vector2(3f, 0f) * (speed * Time.deltaTime));
            }
            else if
                (Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(new Vector2(0f, -3f) * (speed * Time.deltaTime));
            }
        }

       
    }
}