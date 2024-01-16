using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class S_Player : MonoBehaviour
{
    public float height;
    public Rigidbody2D rb;
    [SerializeField]
    private int score;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector2.up * height, ForceMode2D.Impulse);
            Debug.Log("Saut");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Debug.Log("Perdu");
            Destroy(gameObject);
        }
        if (collision.transform.tag == "score")
        {
            Debug.Log("+1");
            score += 1;
        }
        if (collision.transform.tag == "coin")
        {
            Debug.Log("+1");
            score += 1;
            Destroy(collision.gameObject);
        }

        
    }

    public int getScore()
    {
        return score;
    }
}
