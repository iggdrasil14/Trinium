using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour 
{
	public CharacterController2D controller;
	public GeometryForm currentFrom;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool dash = false;

	//bool dashAxis = false;
	public UnityEvent OnDash;
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetKeyDown(KeyCode.Space))
		{
			jump = true;
		}

		if (Input.GetMouseButtonDown(0))
		{
			dash = true;
			OnDash.Invoke();
		}


		if(currentFrom != null)
        {
			if (currentFrom is GeometryFormSquare
					&& currentFrom.IsGrounded == false
						&& Input.GetMouseButtonDown(0))
						//&& Input.GetAxisRaw("Vertical") < 0)
			{
				var form = (GeometryFormSquare)currentFrom;
				form.isCanDestroyBox = true;
				//dash = true;
			}
		}

		

		/*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
		{
			if (dashAxis == false)
			{
				dashAxis = true;
				dash = true;
			}
		}
		else
		{
			dashAxis = false;
		}
		*/

	}

	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		jump = false;
		dash = false;
	}
}
