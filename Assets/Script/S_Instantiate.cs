using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class S_Instantiate : MonoBehaviour
{
    public GameObject prefab;
    public GameObject coins;
    public float delai;

    private float prochainTemps;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Time.time >= prochainTemps) {
            float rdmNumber = Random.Range(-3.5f, 3.5f);
            Vector3 vector = new Vector3(15, rdmNumber, 0);
            Vector3 coin = new Vector3(15, Random.Range(rdmNumber - 1.20f, rdmNumber + 1.20f), 0);

            Instantiate(prefab, vector, transform.rotation);
            Instantiate(coins, coin, transform.rotation);

            prochainTemps = Time.time + delai;
        }
    }
}
