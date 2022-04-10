using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformX : MonoBehaviour
{
    public float speed;
    public float maxX, minX;
    public bool right;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (right && transform.position.x < maxX)
        { 
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
        else if(right)
        {

            right = false;

        }
        else if(!right && transform.position.x > minX)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if(!right)
        {

            right = true;

        }    

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 410f);

        }

    }

}
