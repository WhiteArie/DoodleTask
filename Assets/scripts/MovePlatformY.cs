using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformY : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    [SerializeField] private int delay;

    private float wait = 0;

    private Vector2 targetUp;
    private Vector2 targetDown;

    private void Start()
    {

        targetUp = new Vector2(transform.position.x, transform.position.y + range);
        targetDown = new Vector2(transform.position.x, transform.position.y);

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        wait += Time.deltaTime;
        if((int)wait >= 1f * delay && (int)wait < 3f * delay)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetUp, speed * Time.deltaTime);
        }
        if((int)wait >= 3f * delay && (int)wait < 4f * delay)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetDown, speed * Time.deltaTime);
        }
        if ((int)wait >= 4f * delay) wait = 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 410f);

        }

    }
}
