using UnityEngine;
using System.Collections;

public class fuzeAt : MonoBehaviour {
    public GameObject fuze;
    void gonderFuze()
    {
        Instantiate(fuze,transform.position,Quaternion.identity);
    }
	 void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            Invoke("gonderFuze",0.1f);
        }
    }
}
