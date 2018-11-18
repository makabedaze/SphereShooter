using System;
using UnityEngine;

public class DebugInput : MonoBehaviour, IInput
{
	public Action<Vector3> OnInputRightStick { get; set; } = (Vector3) => { };
	public Action<Vector3> OnInputLeftStick { get; set; } = (Vector3) => { };

	void Update()
	{
		Vector3 inputLeftStickValue = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		OnInputLeftStick?.Invoke(inputLeftStickValue);
	}
}
