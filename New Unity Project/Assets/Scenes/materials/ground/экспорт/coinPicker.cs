using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coinPicker : MonoBehaviour
{
    private float coins = 0;
    public Text coinsText;
    public Text coinsText2;
    private AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coins ++;
            Destroy(collision.gameObject, 1);
            coinsText.text = coins.ToString();
            coinsText2.text = coins.ToString();
            audioSource.Play();
           
        }
    }
     private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

}
