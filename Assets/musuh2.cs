using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh2 : MonoBehaviour
{
    gerak KomponenGerak;
    public GameObject bubble;
    public GameObject covidasli;
    public GameObject covidsedang;
    // Start is called before the first frame update
    void Start()
    {
        KomponenGerak = GameObject.Find("player").GetComponent<gerak>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "player")
        {
            if(bubble == true)
            {
                Destroy(gameObject);
                bubble.SetActive(false);
                covidsedang.SetActive(false);
                covidasli.SetActive(true);
            }
            
        }
    }
}
