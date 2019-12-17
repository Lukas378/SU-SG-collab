using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    GameObject enemyPrefab;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Wave1());
    }
    IEnumerator Wave1()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(enemyPrefab, transform)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
