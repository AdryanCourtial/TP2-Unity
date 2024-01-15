using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class S_Plateform : MonoBehaviour
{

    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
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
