using UnityEngine;
using System.Collections;

public class bombaHrkt : MonoBehaviour {

    GameObject karakterPozisyon;
    public GameObject  ayak;
    bombaHiz bombaYon;
	public GameObject a1, a2, a3;//a4;
    public int can1,can2,can3,yurume;
    bool flipKontrol;
    void Start()
    {
        bombaYon = GameObject.Find("bomba").GetComponent<bombaHiz>();
        karakterPozisyon = GameObject.Find("karakter");
        a1 = GameObject.FindWithTag("bombaci1");
        a2 = GameObject.FindWithTag("bombaci2");
        a3 = GameObject.FindWithTag("bombaci3");
        //a4 = GameObject.FindWithTag("bombaci4");
    }
     void Update()
    {
        if (yurume == 1)
        {
            double a;
            a = (transform.position.x) - (karakterPozisyon.transform.position.x);
            if (a > 1 && a < 50)
            {
                if (!flipKontrol)
                    flip();
                ayak.GetComponent<Animation>().Play("bombaAyak");
                bombaYon.yon = false;
                transform.Translate(10 * Time.deltaTime, 2 * Time.deltaTime, 0);
            }
            if (a > -50 && a < -1)
            {
                if (flipKontrol)
                    flip();
                bombaYon.yon = true;

                ayak.GetComponent<Animation>().Play("bombaAyak");
                transform.Translate(-10 * Time.deltaTime, 2 * Time.deltaTime, 0);
            }

            if (can1 < 1)
                Destroy(a1);
            if (can2 < 2)
                Destroy(a2);
            if (can3 < 3)
                Destroy(a3);
			//if (can4 < 4)
			//	Destroy (a4);
	
        }
        if(yurume==0)
        {
            double a;
            a = (transform.position.x) - (karakterPozisyon.transform.position.x);
            if (a > 1 && a < 50)
            {
                if (!flipKontrol)
                {
                    flip();
                    bombaYon.yon = false;
                }
            }
            if (a > -50 && a < -1)
            {
                if (flipKontrol)
                { 
                flip();
                bombaYon.yon = true;
              }
            }

            if (can1 < 1)
                Destroy(a1);
            if (can2 < 2)
                Destroy(a2);
            if (can3 < 3)
                Destroy(a3);
			//if (can4 < 4)
			//	Destroy (a4);

        }
    }
    void flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        flipKontrol = transform.localScale.x > 0;
    }
}
