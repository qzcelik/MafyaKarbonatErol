using UnityEngine;
using System.Collections;

public class karakterAtes : MonoBehaviour 
{
    public GameObject mermi;
    void Start()
    {
        mermi = GameObject.Find("mermi");
    }
    void FixedUpdate()
    {
       

           Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(1, 0, 0)) * 10, Color.red);
            Ray isin = new Ray(transform.position, transform.TransformDirection(new Vector3(1,0,0)));
          RaycastHit hit;
             if (Physics.Raycast(isin, out hit, 10))
            {
                 if(hit.collider.gameObject.tag=="dusman")
                 
                Destroy(this.gameObject);
            }
          
    }
}
