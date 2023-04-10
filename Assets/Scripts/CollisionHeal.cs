using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{
    private int _heal = 20;
    private string CollisiomDamageTag="Player";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == CollisiomDamageTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.SetHit(_heal);
            Destroy(gameObject);
        }
    }
}
