using UnityEngine;
using System.Collections;

public class tacoPickerUper : MonoBehaviour 
{
	public GameObject dragon;
	private bool onScreen;
	private int tacosPossessed, dragonTimer;
	private GameObject leftEnd;
	// Use this for initialization
	void Start () 
	{
		onScreen = false;
		dragonTimer = Random.Range (1, 5);
		//taco = GameObject.FindGameObjectWithTag ("taco");
		leftEnd = GameObject.FindGameObjectWithTag ("dragonSpawner");
		//dragon = GameObject.FindGameObjectWithTag ("dragon");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GameObject.FindGameObjectWithTag ("dragon") != null) 
		{
			onScreen = false;
			tacosPossessed = 0;
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
//		Debug.Log ("Taco's in hand = " + tacosPossessed);
		if (other.gameObject.tag == "taco") 
		{
			tacosPossessed ++;
			Destroy(other.gameObject);
			//Debug.Log ("Tacos Possessed: " + tacosPossessed);
		}
		if (tacosPossessed >= 5 && !onScreen) 
		{
			Instantiate(dragon, leftEnd.transform.position, leftEnd.transform.rotation);
			onScreen = true;
		}
	}
}