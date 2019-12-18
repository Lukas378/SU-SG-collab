using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float deltaX;
    public int hp = 100;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
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
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -100, 100), transform.position.y);
        if (hp > 50 || Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetTrigger("HalfHealth");
        }
        if (hp < 0 || Input.GetKeyDown(KeyCode.Alpha6)) Death();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") Death();
    }
    public void Death()
    {
        Debug.LogWarning("Död");
        anim.SetTrigger("Death");
        foreach(GameObject gO in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            Destroy(gO);
        }
    }
}
