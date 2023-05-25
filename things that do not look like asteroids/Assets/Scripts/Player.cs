using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //make appear                     //Vector3   rotation
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {                                  //does not matter how fast the computer speed is at
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
    }
}
