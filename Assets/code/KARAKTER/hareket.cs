using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hareket : MonoBehaviour 
{
    public GameObject hareketKont,ayak1,ayak2,ziplaKont,solKont,olum,panelPolis,panelOlum,panelSivil,oluKarakter,butonlar,kucukMenu,ziplaSes1,olumSes;
    Vector3 a;
    public GameObject olumAni;
    public GameObject fillArea;
	public Slider canGoster;
	mermiHiz mermiYon;
	ates1 mermiYonu;
    Collider2D yereBasmaKontrol;
    Rigidbody2D karakterRigid;
    bool yon;
    public int hiz,can,oluDon;
	public double canArttirSayac;
     void Start()
    {
        olumSes = GameObject.Find("olumSes");
        ziplaSes1 = GameObject.Find("ziplaSes");
		kucukMenu = GameObject.Find ("kucukMenu");
		kucukMenu.SetActive (false);
        canGoster.enabled = false;
        karakterRigid = GetComponent<Rigidbody2D>();
        oluKarakter.SetActive(false);
        olumAni.SetActive(false);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
		canGoster.maxValue = 100;
        yereBasmaKontrol = GameObject.FindWithTag("duvar").GetComponent<Collider2D>();
        hareketKont = GameObject.Find("HareketKont");
        ziplaKont = GameObject.Find("ziplaKont");
        solKont = GameObject.Find("solKont");
		mermiYon = GameObject.Find ("mermi").GetComponent<mermiHiz>();
		mermiYonu = GameObject.Find ("tabancaKarakter").GetComponent<ates1>();
		yon = transform.localScale.x > 0;//karakterin pozisyonunu sağa doğru çevirir ilk etapda eğer sağ tarafsa true değerini aldı
        panelPolis.SetActive(false);
        panelOlum.SetActive(false);
        panelSivil.SetActive(false);
	
    }
    public void yokEt()
    {
        Destroy(gameObject);
    }
    void canSure()
	{
	 	can += 10;
		canGoster.value = can;
		return;
	}
    void olumBekle()
    {
        olumSes.GetComponent<AudioSource>().Play();
        panelOlum.SetActive(true);
    }
	public void FixedUpdate () 
    {    
		canArttirSayac +=Time.deltaTime;
      
		if (can < 100 && canArttirSayac >= 10 && canArttirSayac <= 12)
			
		{
			Invoke ("canSure", Random.Range (5f, 5.1f));
	 	}
		if (canArttirSayac >= 10)
			canArttirSayac = 0;
		if (can == 100)
			can = 100;
        if (can < 40)
            olumAni.SetActive(true);
        else
            olumAni.SetActive(false);
 		if (can < 1)
        {
            
			butonlar.SetActive (false);
            var sonPozisyon=transform.position;
            oluKarakter.SetActive(true);
            if(oluDon==0)
            oluKarakter.transform.localScale = new Vector3(-oluKarakter.transform.localScale.x, oluKarakter.transform.localScale.y, oluKarakter.transform.localScale.z);
            if(oluDon==1)
            oluKarakter.transform.localScale = new Vector3(oluKarakter.transform.localScale.x, oluKarakter.transform.localScale.y, oluKarakter.transform.localScale.z);
            Instantiate(oluKarakter,sonPozisyon,Quaternion.identity);
            Invoke("olumBekle",3f);
            gameObject.SetActive(false);
            fillArea.SetActive(false);
           }
			if (hareketKont.GetComponent<hareketKont>().kont == true ||Input.GetKey(KeyCode.RightArrow))
        {
            oluDon = 1;
            if (!yon)
             Flip();
             transform.Translate(hiz * Time.deltaTime, 0, 0);
             ayak1.GetComponent<Animation>().Play("ayak1");
             ayak2.GetComponent<Animation>().Play("ayak2");
			 mermiYon.mermiyon = 1;
			 mermiYonu.yon = true;
            

        }
      if (solKont.GetComponent<hareketKont>().kont == true||Input.GetKey(KeyCode.LeftArrow))
      {
            oluDon = 0;
            if (yon)
          Flip();
          transform.Translate(-hiz * Time.deltaTime, 0, 0);
          ayak1.GetComponent<Animation>().Play("ayak1");
          ayak2.GetComponent<Animation>().Play("ayak2");
			mermiYon.mermiyon = 0;
			 mermiYonu.yon = false;
         
	  }

       
         if (ziplaKont.GetComponent<hareketKont>().kont == true || Input.GetKey(KeyCode.Space))
            transform.Translate(0,40 * Time.deltaTime, 0);

        if (Input.GetKey("escape"))
        {
			Time.timeScale = 0;
            butonlar.SetActive(false);
			kucukMenu.SetActive (true);
        }
        }
        private void Flip()
        {
		  
          transform.localScale = new Vector3(-transform.localScale.x,transform.localScale.y,transform.localScale.z);
          yon = transform.localScale.x > 0;
		 
        }
     public void canAzalt(int kontrol)
	{
		 if (kontrol == 1)
		 	canGoster.value -= 10;
    }
	public void ziplat()
	{
		transform.Translate (0,150*Time.deltaTime,0);
	}
	public void devamEt()
	{
		Time.timeScale = 1;
	}
	public void anaMenu()
	{
		Application.LoadLevel (0);
	}

	public void cikis()
	{
		Application.Quit ();
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="mermiArt")
        {
            mermiYonu.sarjor += 5;
            Destroy(other.gameObject);
        }
    }
    
}
