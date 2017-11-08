using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour {
    int entier;
    public Light myLight;
    Renderer rend ;
 
    // Use this for initialization
    void Start () {
        entier = 1;
        rend.material.shader = Shader.Find("specular");
        rend.material.SetColor("_SpecColor", Color.red);
        rend = GetComponent<Renderer>();
        myLight.color = Color.cyan;
    }
	
	// Update is called once per frame
	void Update () {
        entier = entier + 1;
        if (Input.GetKey("space"))
        {
            Debug.Log("space lumiere on" + entier);
            myLight.enabled = true;
            rend.material.SetColor("_SpecColor", Color.yellow);
            myLight.color = Color.black;

        }
        else
        {
            myLight.enabled = false;
            Debug.Log("space lumiere off" + entier);
            rend.material.SetColor("_SpecColor", Color.green);
            myLight.color = Color.yellow;
        }
    }
}
