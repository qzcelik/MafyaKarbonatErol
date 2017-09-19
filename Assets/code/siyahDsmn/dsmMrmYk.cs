using UnityEngine;
using System.Collections;

public class dsmMrmYk : MonoBehaviour {
	hareket playerCan;
	void Start()
	{
		playerCan = GameObject.Find ("karakter").GetComponent<hareket> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "duvar"|| other.tag=="kutu")
		{
			Destroy (this.gameObject);
		}
			if (other.tag == "Player") {
			Destroy (this.gameObject);
            playerCan.can -= 20;
			playerCan.canAzalt(1);
            playerCan.canAzalt(1);
        }
		}
}
