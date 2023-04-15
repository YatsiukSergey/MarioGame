using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    private int _heal = 20;
    private string _collisiomDamageTag="Player";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _collisiomDamageTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.SetHit(_heal);
            Destroy(gameObject);
        }
    }
}
