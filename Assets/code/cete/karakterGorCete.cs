using UnityEngine;
using System.Collections;

public class karakterGorCete : MonoBehaviour
{
    public GameObject triggerCismi, mermi, tabanca;
    void a()
    {
        Instantiate(mermi, tabanca.transform.position, Quaternion.identity);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
             
            Invoke("a", Random.Range(0.1f, 0.2f));
            Invoke("a", Random.Range(0.1f, 0.2f));
            Invoke("a", Random.Range(0.1f, 0.2f));
            Invoke("a", Random.Range(0.1f, 0.2f));
            Invoke("a", Random.Range(0.1f, 0.2f));
            Invoke("a", Random.Range(0.1f, 0.2f));

        }

    }

}
