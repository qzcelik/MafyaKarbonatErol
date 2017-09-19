using UnityEngine;
using System.Collections;

public class bicakHiz : MonoBehaviour {

 
    public bool yon = true;
    public void Update()
    {
        if (yon)
            transform.Translate(70 * Time.deltaTime, 0, 0);
        else
            transform.Translate(-70 * Time.deltaTime, 0, 0);
    }

}
 

 
