using UnityEngine;
using System.Collections;

public class fuzePatla : MonoBehaviour {
   public  hareket karakterCan;
    void Start()
    {
        karakterCan = GameObject.Find("karakter").GetComponent<hareket>();
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            Destroy(this.gameObject);
            karakterCan.can -= 50;
            for (int i = 0; i < 5; i++)
            {
              karakterCan.canAzalt(1);
                karakterCan.ziplat();
            }
        }
        if (other.tag == "duvar")
            Destroy(this.gameObject);
    }
}
