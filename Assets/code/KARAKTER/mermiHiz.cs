using UnityEngine;
using System.Collections;

public class mermiHiz : MonoBehaviour {

	 
	public  int mermiyon=1;
    float zaman;
	void Update () 
	{
      
         if (mermiyon == 1) 
		{
            	transform.Translate (40 * Time.deltaTime, 0, 0);
		}
		if (mermiyon == 0)
        {
             transform.Translate (-40 * Time.deltaTime, 0, 0);
		}
         
   }
	 
}
