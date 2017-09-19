using UnityEngine;
using System.Collections;

public class hareketKont : MonoBehaviour {

    public bool kont;
    public GameObject ziplaSes1;
    void Start()
    {
        ziplaSes1 = GameObject.Find("ziplaSes");
    }
    public void bas()
    {
        kont = true;
        ziplaSes1.GetComponent<AudioSource>().Play();
   }
    public void cek()
    {
        kont = false;
    }
}
