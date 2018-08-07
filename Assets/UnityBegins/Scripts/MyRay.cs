using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRay : MonoBehaviour {

    public float maxDistancia = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistancia))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.cyan);

            print(hit.transform.name);
            print(hit.collider.tag);
        }
            
    }
}
