using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mulai : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awal()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Awal2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Awal3()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void Level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void Kembali()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
