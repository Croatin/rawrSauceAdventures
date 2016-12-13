using UnityEngine;
using System.Collections;

public class castle : MonoBehaviour {

	public Sprite pooLevel1, pooLevel2, pooLevel3, pooLevel4;
	private SpriteRenderer spriteRenderer;
	private GameObject wholeCastle;
	public GameObject explosion;
	// Use this for initialization
	void Start () 
	{
		wholeCastle = GameObject.FindGameObjectWithTag ("wholeCastle");
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("Poo on the Castle = " + movement.instance.GetComponent<movement>().pooOnCastle);
		if(movement.instance.GetComponent<movement>().pooOnCastle == 1 && movement.instance.GetComponent<movement>().turn == true)
		{
			Debug.Log ("I'm getting hit with shit");
			spriteRenderer.sprite = pooLevel1;
			movement.instance.GetComponent<movement>().turn = false;
		}
		else if(movement.instance.GetComponent<movement>().pooOnCastle == 2 && movement.instance.GetComponent<movement>().turn == true)
		{
			spriteRenderer.sprite = pooLevel2;
			movement.instance.GetComponent<movement>().turn = false;
		}
		else if(movement.instance.GetComponent<movement>().pooOnCastle == 3 && movement.instance.GetComponent<movement>().turn == true)
		{
			spriteRenderer.sprite = pooLevel3;
			movement.instance.GetComponent<movement>().turn = false;
		}
		else if(movement.instance.GetComponent<movement>().pooOnCastle == 4 && movement.instance.GetComponent<movement>().turn == true)
		{
			spriteRenderer.sprite = pooLevel4;
			movement.instance.GetComponent<movement>().turn = false;
		}
		else if (movement.instance.GetComponent<movement>().pooOnCastle > 4 && movement.instance.GetComponent<movement>().turn == true)
		{
			Vector3 scootch = new Vector3(5,0,0);
			Vector3 pos = wholeCastle.transform.position + scootch;
			movement.instance.GetComponent<movement>().turn = false;
			Instantiate(explosion, pos, wholeCastle.transform.rotation);
//			explosion.animation.Play("explosion");
			Destroy (wholeCastle);

		}
	}
}
