﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        for (int i = 0; i < 20; i++)
        {
            var randomNumberX = Random.Range(-8, 8);
            Instantiate(prefab, transform.position + (transform.right * randomNumberX) + (transform.up * 3), transform.rotation);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
