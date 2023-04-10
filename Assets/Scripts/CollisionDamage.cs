using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    private int _damage = 20;
    private string _collisiomDamageTag="Player";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _collisiomDamageTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeHit(_damage);

        }
    }
}
