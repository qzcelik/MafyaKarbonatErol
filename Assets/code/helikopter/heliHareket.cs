using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class heliHareket : MonoBehaviour
{

    public float hiz, mesafe = 0.1f;
    public dusmanYol yol;
    mermiHiz mermiYonu;
    int sayac = 0;
    IEnumerator<Transform> yeri;
    void Start()
    {
        yeri = yol.noktaPozisyon();
        yeri.MoveNext();
        transform.position = yeri.Current.position;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, yeri.Current.position, hiz * Time.deltaTime);
        var fark = (transform.position - yeri.Current.position).sqrMagnitude;
        if (fark < mesafe * mesafe)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            yeri.MoveNext();
        }

    }

}
