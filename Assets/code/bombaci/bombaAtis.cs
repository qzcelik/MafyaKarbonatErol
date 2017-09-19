using UnityEngine;
using System.Collections;

public class bombaAtis : MonoBehaviour {
   public GameObject bomba,elAnim;
    void Start()
    {
        bomba = GameObject.Find("bomba");
    }
    void spawn()
    {
        Instantiate(bomba, transform.position, Quaternion.identity);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            elAnim.GetComponent<Animation>().Play("bombaciEl");
            Invoke("spawn",Random.Range(0.8f,0.9f));
        }
       
    }
     
}
