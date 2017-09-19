using UnityEngine;
using System.Collections;

public class bombaHiz : MonoBehaviour {



    public bool yon = true;
	public void Update ()
    {
        if(yon)
        transform.Translate(35*Time.deltaTime,0,0);
        else
        transform.Translate(-35 * Time.deltaTime, 0, 0);
    }
}
