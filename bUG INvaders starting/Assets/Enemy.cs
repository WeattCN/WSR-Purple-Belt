using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    public float speed;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if(transform.position.x > 8f)
        {
            direction = Vector2.left;
        }

        if (transform.position.x < -8f)
        {
            direction = Vector2.right;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hhhdg");
        animator.SetTrigger("death");
        Destroy(gameObject, 1f);
        Destroy(collision.gameObject);
    }

    private void MoveDown()            //2 blokc has dot
    {      //                  1 blokc 2 blokc 3 blokc 4 blokc 5 blokc 3 has dots = FindObjectType (1 blokc)
        foreach (Enemy enemy in FindObjectOfType)
    }
}
