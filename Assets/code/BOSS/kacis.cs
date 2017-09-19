using UnityEngine;
using System.Collections;

public class kacis : MonoBehaviour {
    public GameObject boss;
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
			boss.GetComponent<Animation> ().Play ("bossAnim");
        }
    }
     
}
