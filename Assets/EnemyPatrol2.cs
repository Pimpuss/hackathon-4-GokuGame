using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol2 : MonoBehaviour
{
  

    public int damageOnCollision = 20;
    public SpriteRenderer graphics;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            // GokuScript2 gokuScript2 = collision.transform.GetComponent<GokuScript2>();
            // gokuScript2.Hurt();
            PlayerHealth2 playerHealth2 = collision.transform.GetComponent<PlayerHealth2>();
            playerHealth2.TakeDamage(damageOnCollision);
        }
    }
}
