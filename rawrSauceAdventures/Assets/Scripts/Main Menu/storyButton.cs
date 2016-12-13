using UnityEngine;
using System.Collections;

public class storyButton : MonoBehaviour {

	public GameObject story;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() 
	{
		Instantiate(story, transform.position, transform.rotation);
	}
}
