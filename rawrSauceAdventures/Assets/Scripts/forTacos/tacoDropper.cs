using UnityEngine;
using System.Collections;

public class tacoDropper : MonoBehaviour 
{
	public GameObject taco;
	private float numberChosen;
	private bool cont, dragonExists;
	// Use this for initialization
	void Start () 
	{
		numberChosen = Random.Range (1, 12);
		cont = true;
		dragonExists = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log ("Does the dragon exist: " + dragonExists);

		if (GameObject.FindWithTag ("dragon")) 
		{
						//Debug.Log("The Dragon was found");
			dragonExists = true;
		}
		else 
		{
			dragonExists = false;
		}
		StartCoroutine(countDown(numberChosen));
		if (numberChosen <= 0) 
		{
			numberChosen = Random.Range (1, 12);
			//Debug.Log ("Resetting NumberChosen");
		}
	}

	IEnumerator countDown(float tacoTimer)
	{
		//Debug.Log ("I happen");
		if(cont && !dragonExists)
		{	
			while(tacoTimer >= 0)
			{
				cont = false;
				tacoTimer -= ((int)Time.deltaTime + 1);
				
				//Debug.Log("Taco timer: " + tacoTimer);
				
				yield return new WaitForSeconds(1);
				//Debug.Log ("dragonExists: " + dragonExists);
				if(tacoTimer <= 0 && !dragonExists)
				{
//					Debug.Log ("I should be dropping a taco here");
					Instantiate(taco,transform.position,transform.rotation);
					cont = true;
					numberChosen = Random.Range (1, 12);
					tacoTimer = numberChosen;
				}
			}
		}
		yield return new WaitForSeconds (1);
	}
}
