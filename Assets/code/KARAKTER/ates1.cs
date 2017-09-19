using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ates1 : MonoBehaviour 
{
    public GameObject mermi,kovan,bicak,bicak2,mermi2,atesSes,sopaSes;
	public Text sarjorGoster;
    public	int sarjor=10;
	public bool yon=true;
	void Start()
	{
        atesSes = GameObject.Find("ates");
        bicak2.SetActive (false);
		bicak.SetActive  (false);
		mermi2.SetActive (true);
        sopaSes = GameObject.Find("sopaSes");
	}
	void Update()
    {
		sarjorGoster.text = "" + sarjor;
	    if(sarjor==0)
		{
			sarjorGoster.gameObject.SetActive (false);
			mermi2.SetActive (false);
			bicak2.SetActive (true);  
			gameObject.SetActive(false);
			bicak.SetActive(true);     
		}

     }
	public void atesEt()
    {
        

        if (sarjor == 0)
        {
            sopaSes.GetComponent<AudioSource>().Play();
            bicak.GetComponent<Animation>().Play("sopAnim");
            bicak.GetComponent<Animation>().Play("sopAnim2");
            bicak.GetComponent<Animation>().Play("sopAnim3");
            bicak.GetComponent<Animation>().Play("sopAnim4");
        }

        sarjor--;
		if (sarjor >= 0) 
		{
            atesSes.GetComponent<AudioSource>().Play();
			sarjorGoster.gameObject.SetActive (true);
			bicak2.SetActive (false);
			mermi2.SetActive (true);
			gameObject.SetActive (true); 
			bicak.SetActive(false);
			if (yon == true) {
				mermi.transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
				Instantiate (mermi, transform.position, Quaternion.identity);
				Instantiate (kovan, transform.position, Quaternion.identity);
			} else {
				mermi.transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
				Instantiate (mermi, transform.position, Quaternion.identity);
				Instantiate (kovan, transform.position, Quaternion.identity);
			}
			}
        else
			sarjor = 0;

        

    }
  
	 
}
