using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField]
    public Transform prefab;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Wave1());
    }
    IEnumerator Wave1()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, transform.position.x * new Vector3(i * 2.0f, 5.0f, 0f), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
