using UnityEngine;
using System.Collections;

public class mermiYokEt : MonoBehaviour 
{
	 
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
		bakkalCan =GameObject.Find("bakkalRiza").GetComponent<bakkalHareket>();
	    haldunCan = GameObject.Find("haldunBey").GetComponent<haldunHareket>();
    }
   
	 void OnTriggerEnter2D(Collider2D other)
	{
        if (other.tag == "tuzak")
            Destroy(this.gameObject);
        if(other.tag=="haldun")
        {
            Destroy(this.gameObject);
            haldunCan.can -= 10;
        }
        if(other.tag=="bakkal")
        {
            Destroy(this.gameObject);
	            bakkalCan.can -= 10;
        }
        //--------------------------------siyahDusman------------------------------------------
		 if (other.tag == "siyahDusman1") 
		{
            
            Destroy (this.gameObject);
        	dusmanHealth.can1 -= 50;
        }
        if (other.tag == "siyahDusman2")
        {

            Destroy(this.gameObject);
            dusmanHealth.can2 -= 50;
        }
        if (other.tag == "siyahDusman3")
        {

            Destroy(this.gameObject);
            dusmanHealth.can3 -= 50;
        }
        if (other.tag == "siyahDusman4")
        {

            Destroy(this.gameObject);
            dusmanHealth.can4 -= 50;
        }
        //---------------------------siyahDusman-----------------------------------------------------
        //-----------------------------------zencicete-----------------------------------------------
        if ( other.tag == "cete1")
        {
            Destroy(this.gameObject);
            ceteHealth.can1 -= 40;
        }
        if (other.tag == "cete2")
        {
            Destroy(this.gameObject);
			ceteHealth.can2 -= 40;
        }
        if (other.tag == "cete3")
        {
            Destroy(this.gameObject);
			ceteHealth.can3 -= 40;
        }
        if (other.tag == "cete4")
        {
            Destroy(this.gameObject);
			ceteHealth.can4 -= 40;
        }
        //-----------------------------------zencicete-----------------------------------------------


        //-----------------------------------bicakliDusman-----------------------------------------------
        if (other.tag=="bicakli1")
        {
            Destroy(this.gameObject);
            bDusman.can1 -= 30;
        }
        if (other.tag == "bicakli2")
        {
            Destroy(this.gameObject);
			bDusman.can2 -= 30;
        }
        if (other.tag == "bicakli3")
        {
            Destroy(this.gameObject);
			bDusman.can3 -= 30;
        }
        if (other.tag == "bicakli4")
        {
            Destroy(this.gameObject);
			bDusman.can4 -= 30;
        }
        //-----------------------------------bicakliDusman-----------------------------------------------

	

        //---------------------------------------bombaci------------------------------------------------
        //if (other.tag == "bombaci")
        //{
          //  Destroy(this.gameObject);
            //bombaCan.can1 -= 40;
        //}
        if (other.tag == "bombaci1")
        {
            Destroy(this.gameObject);
            bombaCan.can1 -= 40;
        }
        if (other.tag == "bombaci2")
        {
            Destroy(this.gameObject);
            bombaCan.can2 -= 40;
        }
        if (other.tag == "bombaci3")
        {
            Destroy(this.gameObject);
            bombaCan.can3 -= 40;
        }


        //---------------------------------------bombaci------------------------------------------------
        if (other.tag == "garbage"||other.tag=="duvar"||other.tag == "kutu") 
		{
			 Destroy (this.gameObject);
		}

	}
	 
}
