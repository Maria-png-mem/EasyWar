using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinS : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CooinT.Coin += 1;
            Destroy(gameObject);
        }
    }
}
