using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class gerak : MonoBehaviour
{
    // Start is called before the first frame update

    Text infonyawa,infokoin;
    
    public int kecepatan, kekuatanlompat;
    public bool balik;
    public int pindah;

    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;

    Animator anim;

    public int nyawa;
    public int koin;
    public Text highscore;
    public Text highscoremenang;

    Rigidbody2D lompat;

    Vector2 mulai;
    public bool ulang;

    public bool tombolkiri,tombolkanan,tombollompat;

    public GameObject kalah,menang;




    void Start()
    {
        infonyawa = GameObject.Find("UInyawa").GetComponent<Text>();
        infokoin = GameObject.Find("UIkoin").GetComponent<Text>();
        lompat = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        mulai = transform.position;
        highscore.text = PlayerPrefs.GetInt("totalskor").ToString();
        highscoremenang.text = PlayerPrefs.GetInt("totalskormenang").ToString();
    }

    // Update is called once per frame
    void Update()
    {

        highscore.text = koin.ToString() + " MASKER";
        highscoremenang.text = koin.ToString() + "MASKER";
        infonyawa.text = nyawa.ToString();
        infokoin.text =  koin.ToString();

        if (ulang == true)
        {
            transform.position = mulai;
            ulang = false;

        }

        if(nyawa<= 0)
        {
            Destroy(gameObject);
            kalah.SetActive(true);

        }
        if (koin >= 10)
        {
            Destroy(gameObject);
            menang.SetActive(true);
        }


        if(tanah == true)
        {
            anim.SetBool("lompat", false);
        }
        else
        {
            anim.SetBool("lompat", true);
        }

        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);

        if (Input.GetKey(KeyCode.D) || (tombolkanan==true) )
        {
            anim.SetBool("lari", true);
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = 1;
        }   else if (Input.GetKey(KeyCode.A) || (tombolkiri==true) )
        {
            anim.SetBool("lari", true);
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
            pindah = -1;
        }
        else
        {
            anim.SetBool("lari", false);
        }

        if (tanah == true && (Input.GetKey(KeyCode.W) || (tombollompat==true) ))
        {
            lompat.AddForce(new Vector2(1,kekuatanlompat));
        }
        if (pindah > 0 && !balik)
        {
            balikbadan();
        }else if (pindah<0 && balik)
        {
            balikbadan();
        }


        void balikbadan()
        {
            balik = !balik;
            Vector3 karakter = transform.localScale;
            karakter.x *= -1;
            transform.localScale = karakter;
        }

    }
    //Game 1
    public void Tekankiri()
    {
        tombolkiri = true;
    }
    public void Lepaskiri()
    {
        tombolkiri = false;
    }


    public void tekankanan()
    {
        tombolkanan = true;
    }
    public void lepaskanan()
    {
        tombolkanan = false;
    }

    public void tekanlompat()
    {
        tombollompat = true;
    }
    public void lepaslompat()
    {
        tombollompat = false;
    }



}
