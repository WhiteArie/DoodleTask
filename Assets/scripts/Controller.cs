using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float moveInput;
    [SerializeField] private float speed;
    private float _horizontal;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        
        
            if (Application.platform == RuntimePlatform.Android)
            {
                _horizontal = Input.acceleration.x;
            }

            rb2d.velocity = new Vector2(Input.acceleration.x * 11f, rb2d.velocity.y);
        

        /*moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);*/

        if (transform.position.x < -3.15f)
        {

            transform.position = new Vector2(transform.position.x * (-1), transform.position.y);

        }
        else if (transform.position.x > 3.15f)
        {

            transform.position = new Vector2(transform.position.x * (-1), transform.position.y);

        }
    }
}
