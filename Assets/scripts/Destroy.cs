using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject bouncePrefab;
    [SerializeField] private GameObject trickyPrefab;
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject Xplatform;
    [SerializeField] private GameObject Yplatform;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 11) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(bouncePrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);

            }
            else if (Random.Range(1, 18) == 2)
            {
                Destroy(collision.gameObject);
                Instantiate(trickyPrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
            else if (Random.Range(1, 15) == 3)
            {
                Destroy(collision.gameObject);
                Instantiate(Xplatform, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
            else if (Random.Range(1, 15) == 4)
            {
                Destroy(collision.gameObject);
                Instantiate(Yplatform, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f)));
            }

        }
        else if (collision.gameObject.name.StartsWith("Bounce"))
        {

            if (Random.Range(1, 10) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }

        }
        else if (collision.gameObject.name.StartsWith("Tricky"))
        {

            if (Random.Range(1, 10) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }

        }
        else if (collision.gameObject.name.StartsWith("MoveX"))
        {
            if (Random.Range(1, 10) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f)));
            }

            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
        }
        else if (collision.gameObject.name.StartsWith("MoveY"))
        {
            if (Random.Range(1, 10) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f)));
            }

            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-2.5f, 2.5f), player.transform.position.y + (5 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
        }
    }
}





