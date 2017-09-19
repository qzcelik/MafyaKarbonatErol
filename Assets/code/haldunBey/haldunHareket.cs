using UnityEngine;
using System.Collections;

public class haldunHareket : MonoBehaviour
{
    GameObject karakterPozisyon;
    public GameObject ayak, bolumGec;
    bicakAt bicakYon;
    public GameObject a1;
    public int can;
    bool flipKontrol;
    void Start()
    {
        bolumGec.SetActive(false);
        // bicakYon = GameObject.Find("picak").GetComponent<bicakHiz>();
        karakterPozisyon = GameObject.Find("karakter");
       
    }
    void Update()
    {

        
            double a;
            a = (transform.position.x) - (karakterPozisyon.transform.position.x);
            if (a > 1 && a < 50)
            {
                if (!flipKontrol)
                    flip();
                ayak.GetComponent<Animation>().Play("haldunAyak");
               // bombaYon.yon = false;
                transform.Translate(-10 * Time.deltaTime, 2 * Time.deltaTime, 0);
            }
            if (a > -50 && a < -1)
            {
                if (flipKontrol)
                    flip();
            // bombaYon.yon = true;

             ayak.GetComponent<Animation>().Play("haldunAyak");
            transform.Translate(10 * Time.deltaTime, 2 * Time.deltaTime, 0);
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
 
