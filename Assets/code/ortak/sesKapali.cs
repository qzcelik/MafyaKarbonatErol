using UnityEngine;
using System.Collections;

public class sesKapali : MonoBehaviour {

	public GameObject sesKapa;
	public	void sesOlay()
	{
        //PlayerPrefs.SetInt("ses",2);
        AudioListener.volume = 0;
        this.gameObject.SetActive(false);
         sesKapa.SetActive(true);
        //if (PlayerPrefs.GetInt("ses")==1)
        //    sesKapa.SetActive(true);
        
    }
}
