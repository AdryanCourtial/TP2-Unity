using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class S_Plateform : MonoBehaviour
{

    private int score;

    [SerializeField]
    private int score_ref = 0;

    public float speed = 2;

    public GameObject player_go;


    private void Start()
    {
        if (player_go != null)
        {
        player_go = GameObject.Find("Player");
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (player_go != null )
        {
        score = player_go.GetComponent<S_Player>().getScore();
        }

        if (score >= score_ref + 5)
        {
            speed += 1;
            score_ref = score_ref + 5;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "destroyed")
        {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
    }



}
