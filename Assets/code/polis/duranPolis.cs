using UnityEngine;
using System.Collections;

public class duranPolis : MonoBehaviour {
   public GameObject panel, karakterPozisyon,poliseYakalananKarakter,butonlar,ses;
    hareket ulas;
    int sayac=0;
   void Start()
    {
        ses = GameObject.Find("olumSes");
        karakterPozisyon = GameObject.Find("karakter");
        ulas = GameObject.Find("karakter").GetComponent<hareket>();
        poliseYakalananKarakter.SetActive(false); 
		//butonlar = GameObject.Find ("kontrolButonlari");

    }

      void polisYakalan()
       {
        panel.SetActive(true);
        ses.GetComponent<AudioSource>().Play();
       }
    void OnTriggerEnter2D(Collider2D other)
        {
       
        if (other.tag=="Player"||other.tag=="mermi")
        {
            butonlar.SetActive (false);
            var karakterPozisyonu = karakterPozisyon.transform.position;
            poliseYakalananKarakter.SetActive(true);
            if (sayac==0)
            Instantiate(poliseYakalananKarakter, karakterPozisyonu, Quaternion.identity);
            sayac = 1;
            Invoke("polisYakalan",2f);
            ulas.yokEt();
        }
        }
}
