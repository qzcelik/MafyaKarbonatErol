using UnityEngine;
using System.Collections;

public class uzerineYuru : MonoBehaviour
{ 
    GameObject karakterPozisyon;
    public GameObject bicak, ayak1, ayak2,b1,b2,b3,b4;
    public int can1,can2,can3,can4,hiz,kontrol;
	bool flipKontrol;
    void Start()
    {
        karakterPozisyon = GameObject.Find("karakter");
        b1 = GameObject.FindWithTag("bicakli1");
        b2 = GameObject.FindWithTag("bicakli2");
        b3 = GameObject.FindWithTag("bicakli3");
        b4 = GameObject.FindWithTag("bicakli4");
    }


    void Update()
    {
		 
		double a,b;
        a = (transform.position.x) - (karakterPozisyon.transform.position.x);
        b = (transform.position.y) - (karakterPozisyon.transform.position.y);
		
		 
			if (a > 1 && a < 50 && b > -2 ) {

				if (!flipKontrol)
					flip ();
				bicak.GetComponent<Animation> ().Play ("bicakAnim");
				ayak1.GetComponent<Animation> ().Play ("kotuYurume");
				ayak2.GetComponent<Animation> ().Play ("kotuYurume2");
				transform.Translate (hiz * Time.deltaTime, 2 * Time.deltaTime, 0);
			}
			if (a > -50 && a < -1 && b > -2 ) {
				if (flipKontrol)
					flip ();
				bicak.GetComponent<Animation> ().Play ("bicakAnim");
				ayak1.GetComponent<Animation> ().Play ("kotuYurume");
				ayak2.GetComponent<Animation> ().Play ("kotuYurume2");
				transform.Translate (-hiz * Time.deltaTime, 2 * Time.deltaTime, 0);
			}

        if (can1 < 1)
            Destroy(b1);

        if (can2 < 1)
            Destroy(b2);

        if (can3 < 1)
            Destroy(b3);

        if (can4 < 1)
            Destroy(b4);
    }
      void flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        flipKontrol = transform.localScale.x > 0;
    }
}
