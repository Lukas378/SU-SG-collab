using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.mousePosition.x > Screen.width / 2)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }
    }
}
