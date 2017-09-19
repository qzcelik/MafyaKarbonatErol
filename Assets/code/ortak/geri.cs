using UnityEngine;
using System.Collections;

public class geri : MonoBehaviour {
 
	 
	void Update ()
    {
        if (Input.GetKey("escape"))
            Application.LoadLevel(0);

	}
}
