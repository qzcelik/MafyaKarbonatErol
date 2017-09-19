using UnityEngine;
using System.Collections;

public class alYan : MonoBehaviour {
 
 
    public GameObject player,panelOlum,butonlar;
    void Start()
    {
		//butonlar = GameObject.Find ("kontrolButonlari");
		player = GameObject.Find("karakter");
     }
  void oyala()
    {
        panelOlum.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			butonlar.SetActive (false);
			 Invoke("oyala",1f);
             Destroy(player);
        }
        }
 

}
