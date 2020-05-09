using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{	
	public float carSpeed;//kecepatan perpindahan mobil scr horizontal
	Vector3 position;//posisi mobil dengan vektor axis horizontal
	public float maxPos = 2.2f;//batasan maksimum mobil bergerak secara horizontal dari titik mula
    public uiManager ui;


    // Start is called before the first frame update
    void Start()
    {
    	//ui = getComponent<uiManager>();
        position = transform.position;//posisi mula mobil
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;//input keyboard sebagai penggerak mobil scr horizontal
    	position.x	= Mathf.Clamp (position.x,-2.2f,2.2f);//maksimal mobil bergerak dari titik pusat adl 2.2f/-2.2f
    	transform.position = position;//posisi terakhir stelah frame update
    	
    }

    void OnCollisionEnter2D(Collision2D col){
    	if(col.gameObject.tag == "enemy car"){//jika pemain menemukan objek dengan tag enemy car maka akan hilang
    		Destroy(gameObject);
    		ui.gameOverActivated();
    	}
    }
}
