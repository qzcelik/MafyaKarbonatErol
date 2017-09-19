using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class dusmanYol : MonoBehaviour {

    public int sira = 0, yeri = 1;
    public Transform []noktaSayisi;
	public IEnumerator <Transform> noktaPozisyon()
	{
	
		while (true) 
		{
			yield return noktaSayisi [sira];
			if (sira <= 0)
				yeri = 1;
			else if (sira >= noktaSayisi.Length - 1)
				yeri = -1;
			sira += yeri;
		}
	}
}
