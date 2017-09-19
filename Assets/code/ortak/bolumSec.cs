using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class bolumSec : MonoBehaviour
{
    public GameObject ses,reklam;
     void Start()
    {
        reklam = GameObject.Find("reklam");
        //PlayerPrefs.DeleteAll();
        ses = GameObject.Find("ses");
         Screen.orientation=ScreenOrientation.LandscapeLeft;
         if (gameObject.name == "1")
        {
           //reklam.GetComponent<ReklamScript>().calistir();
            GetComponent<Button>().interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("bolumSay") >= int.Parse(gameObject.name))
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
           GetComponent<Button>().interactable = false;
        }
   }
    public void bolumGit()
    {
        ses.GetComponent<AudioSource>().Play();
        if (gameObject.name == "1")
        {
            reklam.GetComponent<ReklamScript>().calistir();
            Application.LoadLevel(12);
        }
          
        else
        {
            reklam.GetComponent<ReklamScript>().calistir();
            Application.LoadLevel(gameObject.name);

        }    
        }
    public void bolumSecMenu()
    {
        ses.GetComponent<AudioSource>().Play();
        Application.LoadLevel(1);
    }
	

}
