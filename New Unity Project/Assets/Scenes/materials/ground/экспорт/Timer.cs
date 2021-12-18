using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timerStart = 5;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timerStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timerStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timerStart).ToString();

         if (timerStart<1) {
            SceneManager.LoadScene("Timer");
        }
    }
}
