using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{ public Transform spawnPosition;
        public Rigidbody2D attack;
        public float force = 5F;

        public int hp;

        protected void LaunchAttack()
        {
          Rigidbody2D attackClone =
              Instantiate<Rigidbody2D>(
                    attack, spawnPosition.position, spawnPosition.rotation);

            attackClone.AddForce(transform.forward * force);
        }

        public void ApplyDamage(int damageValue)
        {
            hp -= damageValue;

            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }}