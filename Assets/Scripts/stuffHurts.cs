using UnityEngine;
using System.Collections;

public class stuffHurts : MonoBehaviour 
{
	public int baseHP;
	private int currentHP;
	private float fireTotal = 0;
	public int swordDamage = 15;
	public int fireDamage = 25;
	public GameObject greenBar;
	public int joomp = 10;
	public int back = 10;
	public int rawrHP = 100;
	private int knightsPast = 0;
	// Use this for initialization
	void Start () 
	{
		currentHP = baseHP;
		if (this.tag == "Player")
				fireDamage = 0;
		else if (this.tag == "Enemy")
				swordDamage = 0;
		greenBar = GameObject.FindGameObjectWithTag ("healthBar");
	}

	//get a small radius of colliders, return the closest one as a new game object to destroy it. f

	// Update is called once per frame
	void Update () 
	{
		if (currentHP <= 0) 
		{
//			Debug.Log("This happens");
			Destroy(this.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Sword") 
		{

//			Debug.Log ("RawrSauce HP: " + baseHP);
			rawrHP -= swordDamage;
			this.GetComponent<Rigidbody2D>().AddForce((Vector2.up * joomp));
			this.GetComponent<Rigidbody2D>().AddForce((-Vector2.right * back));
			//greenBar.transform.localScale = new Vector3 (baseHP, 0, 0);
		} 
		else if (other.tag == "FireBall") 
		{
			currentHP -= fireDamage;
			fireTotal ++;
//			Debug.Log ("fireTotal: " + fireTotal);
			float scaled = currentHP * .01f;
			float tranz = (Mathf.Round((baseHP + (fireDamage * fireTotal))) * .01f);
			if(tranz > 1)
				tranz = 1;
			GetComponent<AudioSource>().Play();
//			Debug.Log ("tranz: " + tranz);
//			Debug.Log ("scaled: " + scaled);
			greenBar.transform.localScale = new Vector3 (scaled, 1, 1);
			greenBar.transform.localPosition = new Vector3(-tranz,0,0);
		}
		/*
		if(other.tag == "knightDestroyer" && this.tag == "Enemy")
		{
			Debug.Log ("I feel the knight.");
			Debug.Log ("This: " + this);
			Destroy (this);
		}
		*/
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "knightDestroyer" && this.tag == "Enemy")
		{
			Destroy (this.gameObject);
			knightsPast ++;
		}
	}
}
/*

if (other.gameObject.tag == "Sword") 
		{
			baseHP -= swordDamage;
			Debug.Log("baseHP: " + baseHP);
		}
		else if (other.gameObject.tag == "FireBall") 
		{
			baseHP -= fireDamage;
			Debug.Log("baseHP: " + baseHP);
		}

 */