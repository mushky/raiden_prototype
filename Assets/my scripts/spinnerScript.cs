using UnityEngine;
using System.Collections;

public class spinnerScript : MonoBehaviour 
{
	public Vector3 eulerAngleVelocity = new Vector3(0, 100, 0); // declare public variable

	void FixedUpdate() // rigidbody rotation 
	{
		Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
		rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
	}
}