using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class plsHrkt2 : MonoBehaviour
{
    public float hiz, mesafe = 0.1f, can;
    public dusmanYol yol;
    mermiHiz mermiYonu;
    int sayac = 0;
    public GameObject karakterMermi, ayak1, ayak2;
    IEnumerator<Transform> yeri;
    void Start()
    {
        yeri = yol.noktaPozisyon();
        yeri.MoveNext();
        transform.position = yeri.Current.position;
        mermiYonu = GameObject.Find("dusmanMermi").GetComponent<mermiHiz>();
        karakterMermi = GameObject.Find("mermiArt");

    }
    void Update()
    {
        ayak1.GetComponent<Animation>().Play("polisAyak1");
        ayak2.GetComponent<Animation>().Play("polisAyak2");
        sayac++;
        if (can < 1)
        {
            Destroy(this.gameObject);
            if (sayac % 2 == 0)
                Instantiate(karakterMermi, transform.position, Quaternion.identity);
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, yeri.Current.position, hiz * Time.deltaTime);
        var fark = (transform.position - yeri.Current.position).sqrMagnitude;
        if (fark < mesafe * mesafe)
        {
            if (transform.localScale.x < 0)
            {
                mermiYonu.mermiyon = 0;
            }
            else
            {
                mermiYonu.mermiyon = 1;
            }

            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            yeri.MoveNext();
        }

    }

}
