using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicRaycast : MonoBehaviour
{
    public LayerMask mask;

	// Use this for initialization
	void Start () {
		Debug.Log(mask.value + ": " + Convert.ToString(mask.value, 2));
	}
	
	// Update is called once per frame
	void Update ()
	{
	    RaycastHit hit;
	    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, float.MaxValue, LayerMask.GetMask("First", "Second")))
	    {
	        Debug.DrawRay(hit.point, hit.normal, Color.red);
        }
	    else if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
	    {
	        Debug.DrawRay(hit.point, hit.normal, Color.green);
	    }
	}
}
