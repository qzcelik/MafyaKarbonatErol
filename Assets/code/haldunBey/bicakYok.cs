using UnityEngine;
using System.Collections;

public class bicakYok : MonoBehaviour
{
 
     hareket karakter;
    void Start()
    {
        karakter = GameObject.Find("karakter").GetComponent<hareket>();
    }
    void fonk()
    {

        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "duvar")
        {
             
             
            Invoke("fonk", Random.Range(2f, 2.1f));

        }
        if (other.tag == "Player")
        {
            for (int i = 0; i <= 2; i++)
            {
                karakter.canAzalt(1);
            }
            karakter.can -= 30;
            karakter.ziplat();
            Invoke("fonk", Random.Range(2f, 2.1f));
        }

    }
}