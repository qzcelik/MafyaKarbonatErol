using UnityEngine;
using System.Collections;

public class sesAcik : MonoBehaviour {
	public GameObject sesAc;
	public	void sesOlay()
	{
        AudioListener.volume = 1;
        //PlayerPrefs.SetInt("ses",1);
       //if (PlayerPrefs.GetInt("ses") != 0)
            this.gameObject.SetActive(false);
            sesAc.SetActive(true);
       
    }
}
