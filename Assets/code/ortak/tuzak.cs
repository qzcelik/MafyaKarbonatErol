using UnityEngine;
using System.Collections;

public class tuzak : MonoBehaviour {
    hareket karakterCanAzalt;
     void Start ()
    {
        karakterCanAzalt = GameObject.Find("karakter").GetComponent<hareket>();
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            karakterCanAzalt.canAzalt(1);
            karakterCanAzalt.can -= 10;
            karakterCanAzalt.ziplat();
        }
        if (other.tag == "mermi")
        {

            Destroy(this.gameObject);
        }
    }
}
