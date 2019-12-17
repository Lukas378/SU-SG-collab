using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float deltaX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.mousePosition.x > Screen.width / 2)
        {
            transform.position = new Vector2(transform.position.x - deltaX, transform.position.y);
        }
        else if(Input.mousePosition.x < Screen.width / 2)
        {
            transform.position = new Vector2(transform.position.x + deltaX, transform.position.y);
        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -Screen.width/2, Screen.width/2), transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") Death();
    }

    public void Death()
    {

    }
}
