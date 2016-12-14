using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public GameObject portal;
	// Use this for initialization
	void Start () {
		StartCoroutine(countDown());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator countDown()
	{
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
		Instantiate(portal, transform.position, transform.rotation);
	}

}
