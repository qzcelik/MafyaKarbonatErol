using UnityEngine;
using System.Collections;

public class bicakAt : MonoBehaviour {

    public GameObject bomba, elAnim,ses;
    void Start()
    {
        bomba = GameObject.Find("picak");
        ses = GameObject.Find("kotuAdamSes");
    }
    void spawn()
    {
        Instantiate(bomba, transform.position, Quaternion.identity);
        Instantiate(bomba, transform.position, Quaternion.identity);
    }
    void spawn2()
    {

        ses.GetComponent<AudioSource>().Play();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //elAnim.GetComponent<Animation>().Play("bombaciEl");
            Invoke("spawn", Random.Range(0.8f, 0.9f));
            Invoke("spawn2",5f);
        }

    }
	 
}
 



