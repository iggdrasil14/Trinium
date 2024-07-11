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
    void Update () 
	{
		horizontalMove = InputManager.Instance.MoveInput.x * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if(Input.GetKey(KeyCode.LeftShift))
		{
			runSpeed = 80f;
		}
		else
		{
			runSpeed = 40f;
		}
		
        if (InputManager.Instance.JumpInput == true)
		{
			jump = true;
		}

		if(InputManager.Instance.DashInput == true)
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
