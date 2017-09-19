using UnityEngine;
using System.Collections;

public class kanCik : MonoBehaviour {

    public ParticleSystem kan;
    hareket canAzalt;
    void Start()
    {
        canAzalt = GameObject.Find("karakter").GetComponent<hareket>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "mermi")
            kan.Play();
    }
}
