using UnityEngine;

public static class TransformExtension
{
	static readonly float radious = 30f;

	public static void SphericalMove(this Transform transform, Vector3 moveDirection, float speed)
	{
		var center = Vector3.zero;
		var input = transform.TransformDirection(moveDirection);
		var moko = center - transform.position;
		var cross = Vector3.Cross(input, moko);
		transform.RotateAround(center, cross, Time.deltaTime * speed);
	}
}
