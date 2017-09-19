using UnityEngine;
using System.Collections;

public class bakkalHareket : MonoBehaviour {

	 
    public GameObject karakterPozisyon,el,bolumGec,ses;
    public int can=100;
    bool flipKontrol;
    void Start()
    {
        bolumGec.SetActive(false);
        karakterPozisyon = GameObject.Find("karakter");
        ses = GameObject.Find("rizaGulme");
    }
    void spawn()
    {
        ses.GetComponent<AudioSource>().Play();
    }
    void Update()
    {
       
            double a,b;
            a = (transform.position.x) - (karakterPozisyon.transform.position.x);
            b = Mathf.Abs((transform.position.y) - (karakterPozisyon.transform.position.y));
        if (a > 1 && a < 50 && b <10) 
            {
                Invoke("spawn",2f);
                el.GetComponent<Animation>().Play("bakkaleEl");
                if (!flipKontrol)
                    flip();
                transform.Translate(-20 * Time.deltaTime, 10 * Time.deltaTime, 0);
            }
        if (a > -50 && a < -1 && b < 10) 
            {
            Invoke("spawn", 2f);
            el.GetComponent<Animation>().Play("bakkaleEl");
            if (flipKontrol)
                    flip();
                 transform.Translate(20 * Time.deltaTime, 10 * Time.deltaTime, 0);
            }
        if (can < 1)
        {
            bolumGec.SetActive(true);
            Destroy(this.gameObject);
        }
        }
    void flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        flipKontrol = transform.localScale.x > 0;
    }
}
 