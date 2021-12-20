using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayF()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayS()
    {
        SceneManager.LoadScene(1);

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
