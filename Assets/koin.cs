using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koin : MonoBehaviour
{
    gerak KomponenGerak;
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
            KomponenGerak.koin++;
            Destroy(gameObject);
        }
    }
}
