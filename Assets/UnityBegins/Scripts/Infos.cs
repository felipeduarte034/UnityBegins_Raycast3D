using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infos : MonoBehaviour {

    GameObject go;
    GameObject[] listaGO;

	// Use this for initialization
	void Start ()
    {
        listaGO = go.GetComponentsInChildren<GameObject>();

        foreach (GameObject item in listaGO)
        {
            Destroy(item);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
