using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class platformHareket : MonoBehaviour {

    public float hiz = 5f,dur=0.1f;
    public cizgiCiz duvarKonum;//cizgiciz cinsinden bir değişken oluşturduk daha sonra bu scripti içeren bir gameobject i içeriye sürkleyip eriştik
    GameObject cizgii;
    IEnumerator<Transform> yer;
    void Start()
    {
        //duvarKonum = GameObject.Find("cizgi").GetComponent<cizgiCiz>();
        yer = duvarKonum.noktaYerAl();//en baştaki konumunu aldık
        yer.MoveNext();//bir sonraki konuma geçirmek için gerekli kod
        transform.position = yer.Current.position;//bu platformu bilgileri alınan pozisyona taşı
       
        
    }
   public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,yer.Current.position,Time.deltaTime*hiz);
        var fark = (transform.position - yer.Current.position).sqrMagnitude;
        if (fark < dur * dur)
            yer.MoveNext();
    }
}
