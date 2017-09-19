using UnityEngine;
using System.Collections;

public class bolumGec : MonoBehaviour
{
   public GameObject butonlar, kucukMenu;
    public GameObject ses, reklam;
    
    void Start()
    {
         //kucukMenu = GameObject.Find("kucukMenu");
        // butonlar = GameObject.Find("kontrolButonlari");
        ses = GameObject.Find("ses");
        reklam = GameObject.Find("reklam");
     }
    void OnTriggerEnter2D(Collider2D other)
    {
        int gelenDeger=1;
        gelenDeger = PlayerPrefs.GetInt("bolumSay");
        if(other.tag=="Player")
        {
            reklam.GetComponent<ReklamScript>().calistir();
            if (gelenDeger < int.Parse(gameObject.name)) 
            {
                PlayerPrefs.SetInt("bolumSay",gelenDeger+1); 
            }
            Application.LoadLevel(int.Parse(gameObject.name)+1);
       }
   }


     public void KaldigiYer()
    {
        ses.GetComponent<AudioSource>().Play();
       // reklam.GetComponent<ReklamScript>().calistir();
        Time.timeScale = 1;
        Application.LoadLevel(int.Parse(gameObject.name));
    }
    public void anaMenu()
    {
        reklam.GetComponent<ReklamScript>().calistir();
        ses.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        Application.LoadLevel(0);
        
    }
    public void devamEt()
    {
        //reklam.GetComponent<ReklamScript>().calistir();
        ses.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        butonlar.SetActive(true);
        kucukMenu.SetActive(false);
    }
     public void cikis()
    {
        ses.GetComponent<AudioSource>().Play();
        Application.Quit();
    }

}
