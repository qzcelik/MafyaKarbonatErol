using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class dusmanHareket : MonoBehaviour {
	public float hiz,mesafe = 0.1f,can1,can2,can3,can4;
	public dusmanYol yol;
    mermiHiz mermiYonu;
    int sayac = 0,sayac2,deger=0;
    double baslangic;
    public  GameObject karakterMermi,ayak1,ayak2,d1,d2,d3,d4,karakter;
	IEnumerator<Transform> yeri;
	void Start()
	{
        baslangic = transform.position.x;
		yeri = yol.noktaPozisyon ();
        yol = GameObject.Find("dusmanGuzergah").GetComponent<dusmanYol>();
		yeri.MoveNext ();
        karakter = GameObject.Find("karakter");
		transform.position = yeri.Current.position;
		mermiYonu = GameObject.Find ("dusmanMermi").GetComponent<mermiHiz> ();
        karakterMermi = GameObject.Find("mermiArt");
        d1 = GameObject.FindWithTag("siyahDusman1");
        d2 = GameObject.FindWithTag("siyahDusman2");
        d3 = GameObject.FindWithTag("siyahDusman3");
        d4 = GameObject.FindWithTag("siyahDusman4");
    }
	void Update()
	{
        ayak1.GetComponent<Animation>().Play("kotuYurume");
        ayak2.GetComponent<Animation>().Play("kotuYurume2");
        sayac++;

	 	if (can1 < 1)
         {
			Destroy (d1);
            can1 = 10;
            if(sayac%2==0)
            Instantiate(karakterMermi,d1.transform.position,Quaternion.identity);
			return;
		 }
        if (can2 < 1)
        {
            Destroy(d2);
            can2 = 10;
            if (sayac % 2 == 0)
                Instantiate(karakterMermi, d2.transform.position, Quaternion.identity);
            return;
        }
        if (can3 < 1)
        {
            can3 = 10;
            Destroy(d3);
            if (sayac % 2 == 0)
                Instantiate(karakterMermi, d3.transform.position, Quaternion.identity);
            return;
        }
        if (can4 < 1)
        {
            Destroy(d4);
            can4 = 10;
            if (sayac % 2 == 0)
            Instantiate(karakterMermi, d4.transform.position, Quaternion.identity);
            return;
        }

       

        transform.position = Vector3.MoveTowards (transform.position, yeri.Current.position, hiz * Time.deltaTime);
        var fark = (transform.position - yeri.Current.position).sqrMagnitude;
		if (fark < mesafe * mesafe) 
		{
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            yeri.MoveNext();
        }
        if((baslangic-transform.position.x)<baslangic)
        {
            mermiYonu.mermiyon = 1;
        }
        if ((baslangic - transform.position.x) > baslangic)
        {
            mermiYonu.mermiyon = 0;
        }
        //double a;
        //a = (transform.position.x) - (karakter.transform.position.x);
        //if (a > 1 && a < 50)
        //{
        //    mermiYonu.mermiyon = 1;
        //}
        //if (a > -50 && a < -1)
        //{
        //    mermiYonu.mermiyon = 0;
        //}
        //if (transform.localScale.x > 0)
        //if (yol.sira == 1)
        //    mermiYonu.mermiyon = 1;
        //if (yol.sira > 1 || yol.sira < 1)
        //    mermiYonu.mermiyon = 0;

    }

}
