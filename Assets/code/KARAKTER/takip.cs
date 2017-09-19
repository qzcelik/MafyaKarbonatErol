using UnityEngine;
using System.Collections;

public class takip : MonoBehaviour {


    public GameObject hedef,butonlar,kucukMenu;
    public float x,z;
    void Start()
    {
        hedef = GameObject.Find("karakter");
        butonlar = GameObject.Find("kontrolButonlari");
        kucukMenu = GameObject.Find("kucukMenu");
    }
    void LateUpdate ()
    {
        transform.position = new Vector3(hedef.transform.position.x+x,transform.position.y,z);
        
	}
	public void devamEt()
	{
        butonlar.SetActive(true);
		Time.timeScale = 1;

        kucukMenu.SetActive(false);
    }
	public void anaMenu()
	{
        Time.timeScale = 1;
        Application.LoadLevel (0);
	}
	public void cikis()
	{
		Application.Quit ();
	}

}
