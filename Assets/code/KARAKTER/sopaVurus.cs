using UnityEngine;
using System.Collections;

public class sopaVurus : MonoBehaviour {

    public dusmanHareket dusmanHealth;
    public ceteHareket ceteHealth;
    public uzerineYuru bDusman;
    public bombaHrkt bombaCan;
    public bakkalHareket bakkalCan;
    public haldunHareket haldunCan;
    void Start()
    {
        dusmanHealth = GameObject.Find("kotuKarakter").GetComponent<dusmanHareket>();
        bDusman = GameObject.Find("bicak").GetComponent<uzerineYuru>();
        ceteHealth = GameObject.Find("cete1").GetComponent<ceteHareket>();
        bombaCan = GameObject.Find("bombaci").GetComponent<bombaHrkt>();
        bakkalCan = GameObject.Find("bakkalRiza").GetComponent<bakkalHareket>();
        haldunCan = GameObject.Find("haldunBey").GetComponent<haldunHareket>();
    }
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.gameObject.tag == "haldun")
        {
             haldunCan.can -= 5;
        }
        if (other.gameObject.tag == "bakkal")
        {
            bakkalCan.can -= 10;
        }
        //--------------------------------siyahDusman------------------------------------------
        if (other.gameObject.tag == "siyahDusman1")
        {
          dusmanHealth.can1 -= 40;
        }
        if (other.gameObject.tag == "siyahDusman2")
        {
            dusmanHealth.can2 -= 40;
        }
        if (other.gameObject.tag == "siyahDusman3")
        {
             
            dusmanHealth.can3 -= 40;
        }
        if (other.gameObject.tag == "siyahDusman4")
        {

            
            dusmanHealth.can4 -= 40;
        }
        //---------------------------siyahDusman-----------------------------------------------------
        //-----------------------------------zenciCete-----------------------------------------------
        if (other.gameObject.tag == "cete1")
        {
             
            ceteHealth.can1 -= 40;
        }
        if (other.gameObject.tag == "cete2")
        {
             
            ceteHealth.can2 -= 40;
        }
        if (other.gameObject.tag == "cete3")
        {
          
            ceteHealth.can3 -= 40;
        }
        if (other.gameObject.tag == "cete4")
        {
           
            ceteHealth.can4 -= 40;
        }
        //-----------------------------------zenciCete-----------------------------------------------


        //-----------------------------------bicakliDusman-----------------------------------------------
        if (other.gameObject.tag == "bicakli1")
        { 
            bDusman.can1 -= 30;
        }
        if (other.gameObject.tag == "bicakli2")
        {
             
			bDusman.can2 -= 30;
        }
        if (other.gameObject.tag == "bicakli3")
        {
            
			bDusman.can3 -= 30;
        }
        if (other.gameObject.tag == "bicakli4")
        {
            
			bDusman.can4 -= 30;
        }
        //-----------------------------------bicakliDusman-----------------------------------------------



        //---------------------------------------bombaci------------------------------------------------
        if (other.gameObject.tag == "bombaci")
        { 
            bombaCan.can1 -= 40;
        }
        if (other.gameObject.tag == "bombaci1")
        {
         
			bombaCan.can1 -= 40;
        }
        if (other.gameObject.tag == "bombaci2")
        {
           
			bombaCan.can2 -= 40;
        }
        if (other.gameObject.tag == "bombaci3")
        {
          
			bombaCan.can3 -= 40;
        }
        //---------------------------------------bombaci------------------------------------------------
    }

}


