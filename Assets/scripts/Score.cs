using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Rigidbody2D rb2d;
    protected float topScore = 0.0f;
    [SerializeField] private Text scoreText;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(rb2d.velocity.y > 0 && transform.position.y > topScore)
        {

            topScore = transform.position.y;

        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

    }


}
