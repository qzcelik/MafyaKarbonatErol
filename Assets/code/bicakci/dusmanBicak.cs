using UnityEngine;
using System.Collections;

public class dusmanBicak : MonoBehaviour {
    hareket karakterCan;
    void Start()
    {
        karakterCan = GameObject.Find("karakter").GetComponent<hareket>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            karakterCan.can -= 10;
            karakterCan.canAzalt(1);
        }
    }

}
