using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Tombol , kuis1, kuis2;

    public void closed()
    {
        Tombol.SetActive(false);
    }
    public void Kuis1()
    {
        kuis1.SetActive(true);
    }
    public void Kuis2()
    {
        kuis2.SetActive(true);
    }
}
