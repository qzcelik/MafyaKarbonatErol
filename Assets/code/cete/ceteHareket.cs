using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ceteHareket : MonoBehaviour
{
    public float hiz, mesafe = 0.1f, can1,can2,can3,can4;
    public dusmanYol yol;
    mermiHiz mermiYonu;
    int sayac = 0,sayac2;
    public GameObject karakterMermi,c1,c2,c3,c4,karakter;
    IEnumerator<Transform> yeri;
    void Start()
    {
        yeri = yol.noktaPozisyon();
        yol = GameObject.Find("dusmanGuzergah").GetComponent<dusmanYol>();
        yeri.MoveNext();
        karakter = GameObject.Find("karakter");
        transform.position = yeri.Current.position;
        mermiYonu = GameObject.Find("dusmanMermi").GetComponent<mermiHiz>();
        karakterMermi = GameObject.Find("mermiArt");
        c1 = GameObject.FindWithTag("cete1");
        c2 = GameObject.FindWithTag("cete2");
        c3 = GameObject.FindWithTag("cete3");
        c4 = GameObject.FindWithTag("cete4");
    }
    void Update()
    {
        sayac++;
        if (can1 < 1)
        {
            Destroy(c1);
            can1 = 10;
            if (sayac % 2 == 0)
                Instantiate(karakterMermi,c1.transform.position, Quaternion.identity);
            return;
        }
        if (can2 < 1)
        {
            Destroy(c2);
            can2 = 10;
            if (sayac % 2 == 0)
             Instantiate(karakterMermi, c2.transform.position, Quaternion.identity);
            return;
        }
        if (can3 < 1)
        {
            Destroy(c3);
            can3 = 10;
            if (sayac % 2 == 0)
                Instantiate(karakterMermi,c3.transform.position, Quaternion.identity);
            return;
        }
        if (can4 < 1)
        {
            Destroy(c4);
            can4 = 10;
            if (sayac % 2 == 0)
              Instantiate(karakterMermi, c4.transform.position, Quaternion.identity);
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, yeri.Current.position, hiz * Time.deltaTime);
        var fark = (transform.position - yeri.Current.position).sqrMagnitude;
        if (fark < mesafe * mesafe)
        { 
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            yeri.MoveNext();

         }
        if (yol.sira == 1)
            mermiYonu.mermiyon = 1;
        if (yol.sira > 1 || yol.sira < 1)
            mermiYonu.mermiyon = 0;
    }

}
