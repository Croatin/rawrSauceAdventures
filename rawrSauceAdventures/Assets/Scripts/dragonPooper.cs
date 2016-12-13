using UnityEngine;
using System.Collections;

public class dragonPooper : MonoBehaviour {

	public int dragSpeed = 100;
	private int directionTracker = 1;
	private int wallsHit = 0, dragonTimer, whenToPoop;
	public int pooper = 5;
	public GameObject poop, dragon;
	private bool cont, flipped =  false;

	// Use this for initialization
	void Start () 
	{
		dragonTimer = Random.Range (15, 50);
		whenToPoop = Random.Range (0, dragonTimer);
		cont = true;
//		GameObject camera = GameObject.FindGameObjectWithTag ("camera");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.right * dragSpeed * Time.deltaTime * directionTracker);
		//Vector3 cameraY = camera.transform.position.y;
		Destroy (gameObject, dragonTimer);
		StartCoroutine(countDown(whenToPoop));

	}
/*
	if(!flipped)
	{
		Vector3 newScale = dragon.transform.localScale;
		newScale.x *= -1;
		dragon.transform.localScale = newScale;
		
		flipped = true;
	}
*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "endOfGameR" && !flipped) 
		{
			Debug.Log ("In theory, I work");
			directionTracker =  -1;
			//wallsHit ++;
			flipped = true;
			Debug.Log ("Flipped: " + flipped);

			Vector3 newScale = dragon.transform.localScale;
			newScale.x *= -1;
			this.transform.localScale = newScale;
			//dragon.transform.localScale = newScale;
		}
		if (other.gameObject.tag == "endOfGameL" && flipped) 
		{
			Debug.Log ("In theory, I work, too.");
			directionTracker =  1;
			//wallsHit ++;
			flipped = false;
			Debug.Log ("Flipped: " + flipped);

			Vector3 newScale = dragon.transform.localScale;
			newScale.x *= -1;
			this.transform.localScale = newScale;
		}

	}

	IEnumerator countDown(float Poop)
	{
		if (cont) 
		{
			while (Poop >= 0) 
			{
				cont = false;
				Poop -= ((int)Time.deltaTime + 1);
//				Debug.Log ("Poop timer: " + Poop);
				yield return new WaitForSeconds (1);
				if (Poop == 0) 
				{
						Instantiate (poop, transform.position, transform.rotation);
						cont = true;
				}
			}
		}
		yield return new WaitForSeconds (1);
	}
		
}






