using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ulangi : MonoBehaviour
{
 
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Awali()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level1");
    }
}
