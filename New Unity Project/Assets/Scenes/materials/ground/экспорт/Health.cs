using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    public void TakeHit(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Timer");
        }
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if(health> maxHealth)
        {
            health = maxHealth;
        }
    }

    private  void FixedUpdate() {

    if (health > numOfHearts)
    { health = numOfHearts; }
    for (int i =0;i< hearts.Length;i++)
        {
            if(i<Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i<numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

        }
       
    }
        
    
        
        
}
