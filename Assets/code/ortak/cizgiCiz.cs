using UnityEngine;
using System.Collections.Generic;
using System.Collections.Generic;

public class cizgiCiz : MonoBehaviour {

    public Transform  []noktaYeri;
    public IEnumerator <Transform> noktaYerAl()
    {
         int sira=0,yeri=1;
         while (true)
         {
             yield return noktaYeri[sira];
             if (sira <= 0)
             {
                 yeri = 1;
             }
             else if (sira >= noktaYeri.Length-1)
                 yeri = -1;
             sira += yeri;
         }
    }
}
