using UnityEngine;
using System.Collections;

public class bombaKan : MonoBehaviour {
   public ParticleSystem kan;
    hareket canAzalt;
    void Start()
    {
        canAzalt = GameObject.Find("karakter").GetComponent<hareket>();
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="mermi"||other.tag.Equals("sopa"))
        {
            kan.Play();
        }
    }
}
