using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMove : MonoBehaviour
{
	public float speed;//kecepatan lintasan berjalan spt sistem threadmill
	Vector2 offset;//mengulangi texture pada lintasan
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2 (0,Time.time * speed);//lintasan bergerak vertical sesuai y-axis
        GetComponent<Renderer> ().material.mainTextureOffset = offset;
    }
}
