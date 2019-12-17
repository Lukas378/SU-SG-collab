using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePointPrefab;

    public float bulletForce = 20f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePointPrefab.position);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePointPrefab.up * bulletForce, ForceMode2D.Impulse);


    }
}
