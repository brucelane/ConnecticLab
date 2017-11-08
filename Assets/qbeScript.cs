using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qbeScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("space"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
