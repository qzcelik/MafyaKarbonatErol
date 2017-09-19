using UnityEngine;
using System.Collections;

    public class sonBolum : MonoBehaviour {
    public GameObject p1,heli,resim,anaPanel;
	hareket karakter;
    void Start()
    {
		karakter = GameObject.Find ("karakter").GetComponent<hareket> ();
        p1.SetActive(false);
        resim.SetActive(false);
    }
    void spawn()
    {
        resim.SetActive(true);
        Destroy(this.gameObject);
    }
	 void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
			karakter.hiz = 0;
		
            heli.GetComponent<Animation>().Play("heliAnim");
            p1.SetActive(true);
            Invoke("spawn", 3f);
            anaPanel.SetActive(false);
           
            
        }
    }
}
