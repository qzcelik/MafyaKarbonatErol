using UnityEngine;
using System.Collections;

public class hikaye : MonoBehaviour {
    public GameObject h1;
    void Start()
    {
      h1.GetComponent<Animation>().Play("hikayeAnim");
    }
   public void skip()
    {
        Application.LoadLevel(2);
    }
}
