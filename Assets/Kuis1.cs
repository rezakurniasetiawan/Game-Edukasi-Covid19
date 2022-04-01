using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kuis1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Lanjutkan, Ulangi, infoLanjutkan, infoUlangi;
    void Start()
    {

    }
    public void jawaban(bool jawab)
    {
        
        if (jawab)
        {
            int skor = PlayerPrefs.GetInt("skor") + 50;
            PlayerPrefs.SetInt("skor", skor);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild (gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        int skor = PlayerPrefs.GetInt("skor") + 50;
        if (skor == 100)
        {
            Lanjutkan.SetActive(true);
            Ulangi.SetActive(false);
            infoLanjutkan.SetActive(true);
            infoUlangi.SetActive(false);

        }
        else if(skor ==50 )
        {
            Ulangi.SetActive(true);
            infoUlangi.SetActive(true);
            Lanjutkan.SetActive(false);
            infoLanjutkan.SetActive(false);
        }
        else if(skor <= 0){
            Ulangi.SetActive(true);
            infoUlangi.SetActive(true);
            Lanjutkan.SetActive(false);
            infoLanjutkan.SetActive(false);
        }
    }
}
