using UnityEngine;
using System.Collections;

public class controlsButton : MonoBehaviour {

	public GameObject controls;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() 
	{
		Instantiate(controls, transform.position, transform.rotation);
	}
}
