using UnityEngine;
using System.Collections;

public class otoHareket : MonoBehaviour {


    public GameObject ayak1, ayak2;
	void Update ()
    {
        ayak1.GetComponent<Animation>().Play("ayak1");
        ayak2.GetComponent<Animation>().Play("ayak2");
        transform.Translate(30*Time.deltaTime,0,0);
	}
  

}
