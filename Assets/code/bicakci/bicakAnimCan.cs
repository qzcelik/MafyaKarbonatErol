using UnityEngine;
using System.Collections;

public class bicakAnimCan : MonoBehaviour {
    public GameObject bicak;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            bicak.GetComponent<Animation>().Play("bicak");
        }
    }
}
