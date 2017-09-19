using UnityEngine;
using System.Collections;

public class bombaYok : MonoBehaviour {
	public ParticleSystem patlama;
    public GameObject bomba,ses;  
	hareket karakter;
	void Start()
	{
		karakter = GameObject.Find ("karakter").GetComponent<hareket> ();
        ses = GameObject.Find("bombaSes");
	}
	void fonk()
	{
          Destroy (this.gameObject);
   }
    void OnTriggerEnter2D(Collider2D other)
	{
 
		if (other.tag == "duvar") 
		{
            patlama.Play ();
            ses.GetComponent<AudioSource>().Play();
            bomba.SetActive(false);
		    Invoke ("fonk", Random.Range (2f, 2.1f));
           
 	     }
		if (other.tag == "Player")
        {
            for (int i = 0;i <=2; i++)
            {
                karakter.canAzalt(1);
            }
            karakter.can -= 30;
            karakter.ziplat();
            patlama.Play();
            ses.GetComponent<AudioSource>().Play();
            bomba.SetActive(false);
            Invoke("fonk", Random.Range(2f, 2.1f));
       }
		 
		}
}
