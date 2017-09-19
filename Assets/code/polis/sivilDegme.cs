using UnityEngine;
using System.Collections;

public class sivilDegme : MonoBehaviour {

   public GameObject panel;
    void sivilDegmek()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
	 void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="mermi")
        {
            Invoke("sivilDegmek",1f);
            
        }
    }
}
