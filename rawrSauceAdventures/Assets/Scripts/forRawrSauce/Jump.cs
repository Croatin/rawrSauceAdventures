using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour 
{

	public  float jump = 1.0f;
	private bool canJump = false;


	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow) && canJump)
		   {
			//Rigidbody2D.AddForce(Vector2.up * jump);
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
			canJump = false;
		   }
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Ground") 
		{
			canJump = true;
		}
	}
}
/*
		Animator = GetComponent<Animator>();
        Animator.SetLayerWeight(1, 1f);

		Animator animator = GetComponent<Animator>(); //line 17
		animator.SetLayerWeight(1, 1f);

 */
