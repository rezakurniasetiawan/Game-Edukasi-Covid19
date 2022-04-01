using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaksin : MonoBehaviour
{
    // Start is called before the first frame update

    gerak KomponenGerak;
    public GameObject bubble;
    public GameObject covidasli;

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
            covidasli.SetActive(false);
            bubble.SetActive(true);
            Destroy(gameObject);
        }
    }
}
