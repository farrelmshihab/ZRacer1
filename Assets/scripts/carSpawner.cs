using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{	//open video part7
	public GameObject[] cars;
	int carNo;
	public float maxPos=2.2f;
	public float delayTimer =1f;//interval waktu
	float timer;
    // Start is called before the first frame update
    void Start()
    {
    	timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {	timer-=Time.deltaTime;//interval waktu
    	//memunculkan mobil lawan tiap interval waktu
        if (timer<=0){
        	Vector3 carPos = new Vector3(Random.Range(-2.2f,2.2f),transform.position.y,transform.position.z);//posisi awal mobil lawan secara random
        	carNo = Random.Range(0,5);
        	Instantiate (cars[carNo], carPos, transform.rotation);//awal mobil lawan muncul 	
        	timer = delayTimer;
        }
    }
}
