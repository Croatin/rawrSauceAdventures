using UnityEngine;
using System.Collections;

public class foShowButton2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() 
	{
//		Debug.Log ("I'm CLICKING");
		Application.LoadLevel("level3");
	}
}
