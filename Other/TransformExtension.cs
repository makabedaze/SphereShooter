using UnityEngine;

public static class TransformExtension
{
	//仰角をz、方位角をx、半径をyとする
	public static void SetSphericalPosition(this Transform transform,Vector3 targetPos)
	{
		var radius = targetPos.y;//半径
		var azimuth = targetPos.x;//方位角
		var elevation = targetPos.z;//仰角
		transform.position = ConvertSphericalCoordinatesToCartesianCoordinates(radius, azimuth, elevation);
	}

	public static Vector3 GetSphericalPosition(this Transform transform)
	{
		var radius = transform.position.magnitude;
		var azimuth = Mathf.Atan2(transform.position.z, transform.position.x);
		var elevation = Mathf.Asin(transform.position.y / radius);
		return new Vector3(azimuth, radius, elevation);
	}

	public static void SphericalTranslate(this Transform transform, Vector3 targetPos)
	{
		var radius = targetPos.x;//半径
		var azimuth = targetPos.y;//方位角
		var elevation = targetPos.z;//仰角
		transform.SetSphericalPosition(transform.GetSphericalPosition() + new Vector3(radius, azimuth, elevation));
		transform.LookAt(Vector3.zero);
	}

	public static Vector3 ConvertSphericalCoordinatesToCartesianCoordinates(float radius,float azimuth,float elevation) 
	{
		float t = radius * Mathf.Cos(elevation);
		return new Vector3(t * Mathf.Cos(azimuth), radius * Mathf.Sin(elevation), t * Mathf.Sin(azimuth));
	}
}
