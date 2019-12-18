using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("BRegHitTag " + collision.gameObject.tag);
        //Debug.Log("BRegHit " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy") Destroy(gameObject);
    }
}
