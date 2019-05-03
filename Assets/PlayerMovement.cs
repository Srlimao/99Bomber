using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
	public float velocity;
	public Vector2 rigVel;
	Rigidbody2D myRigidBody;
	Animator myAnim;
	// Start is called before the first frame update
	void Start()
    {
		myRigidBody = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
		Run();
    }

	void Run(){
			float controlH = CrossPlatformInputManager.GetAxis("Horizontal");
			float controlV = CrossPlatformInputManager.GetAxis("Vertical");
		if (controlV > 0)
		{
			myAnim.SetBool("WalkUp", true);
			myAnim.SetBool("Walk", false);
		}
		else
		{
			myAnim.SetBool("WalkUp", false);
			myAnim.SetBool("Walk", true);
		}
		Vector2 playerVelocity = new Vector2(controlH * velocity, controlV * velocity);
			rigVel =myRigidBody.velocity = playerVelocity ;
	}
}
