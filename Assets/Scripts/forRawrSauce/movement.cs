using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour 
{
	public float moveSpeed = 10f;
	public GameObject rawr;
	public int instantanious, pooOnCastle = 0;
	private bool flipped = false;
	private GameObject poopInHernd;
	public GameObject poopInHand, poop;
	private GameObject arm;
	public bool holdingPoop = false, turn = false;

	public static movement instance;
	void Start ()
	{
		instance = this;
		arm = GameObject.FindGameObjectWithTag ("arm");
	}
	void Update()
	{
		poop = GameObject.FindGameObjectWithTag ("poop");

		poopInHernd = GameObject.FindGameObjectWithTag("poopInHand");
		//pickUpPoop poop = GetComponent<pickUpPoop>;
		//GetComponent<pickUpPoop>()
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
			if(flipped)
			{
				Vector3 newScale = rawr.transform.localScale;
				newScale.x *= -1;
				rawr.transform.localScale = newScale;
				
				flipped = false;
			}
			GetComponent<Animation>().Play("walk");
		}
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
			if(!flipped)
			{
				Vector3 newScale = rawr.transform.localScale;
				newScale.x *= -1;
				rawr.transform.localScale = newScale;

				flipped = true;
			}
			GetComponent<Animation>().Play("walk");
        }
		else
			GetComponent<Animation>().Play("Idle");
		if (Input.GetKey (KeyCode.D) && holdingPoop == true) 
		{
			Debug.Log ("I am supposed to be throwin");
			holdingPoop = false;
//------> fix this	   			transform.Translate();
			Destroy(poopInHernd);
			pooOnCastle ++;
			turn = true;

		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{

		Debug.Log ("And it is: " + other.gameObject);
		if(other.gameObject.tag  == ("poop") && !holdingPoop)
		{
			Debug.Log ("finding the poop");
			Destroy(poop);
			Instantiate(poopInHand, arm.transform.position, arm.transform.rotation);
			holdingPoop = true;
			//			Debug.Log ("Why am I not being destroyed?");
		}
	}
}
