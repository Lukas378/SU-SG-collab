using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Enemy") Destroy(collision.gameObject);
    }
}
