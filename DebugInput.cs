using System;
using UnityEngine;

public class DebugInput : MonoBehaviour, IInput
{
	public Action<Vector3> OnInputRightStick { get; set; }
	public Action<Vector3> OnInputLeftStick { get; set; }
	public Action OnInputAttackButton { get; set; }

	void Update()
	{
		Vector3 inputLeftStickValue = new Vector3(Input.GetAxis(Constants.HORIZONTAL), 0, Input.GetAxis(Constants.VERTICAL));
		OnInputLeftStick.NullSafe(inputLeftStickValue);

		if (Input.GetKey(KeyCode.Space))
		{
			OnInputAttackButton.NullSafe();
		}
	}
}
