using UnityEngine;
using System.Collections;

public class yumruk : MonoBehaviour {

 
 
    hareket playerCan;
    void Start()
    {
        playerCan = GameObject.Find("karakter").GetComponent<hareket>();
    }
    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.tag == "Player")
        { 
            playerCan.can -= 35;
            playerCan.canAzalt(1);
        }
    }
}

 
