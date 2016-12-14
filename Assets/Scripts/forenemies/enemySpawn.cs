using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour 
{
	public int difficultyLevel, starter;
	public GameObject knight;
	private GameObject spawner;
	private float timer;
	private bool cont;

	//private int currentTime;
	// Use this for initialization
	void Start () 
	{
		cont = true;
		timer = starter;
		spawner = GameObject.FindGameObjectWithTag ("knightSpawner");
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine(countDown(timer, difficultyLevel));
	}
	IEnumerator countDown(float timerr, int multiplyer)
	{
		if (cont) 
		{
			while (timerr >= 0) 
			{	
				cont = false;
				timerr -= ((int)Time.deltaTime + 1);
//				Debug.Log ("Timer: " + timerr);

				yield return new WaitForSeconds (1 / multiplyer);
				if (timerr < 0) 
				{
//						Debug.Log ("I should be making a knight here");
						Instantiate (knight, spawner.transform.position, spawner.transform.rotation);
						GetComponent<Animation>().Play ("openGate");
						timer = starter;
						cont = true;
				}
			}
		}
		yield return new WaitForSeconds (1);
	}
}
