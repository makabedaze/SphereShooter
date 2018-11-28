using System;
using UnityEngine;

public class DebugInput : MonoBehaviour, IInput
{
	public Vector3 OnInputRightStick { get; private set; }
	public Vector3 OnInputLeftStick { get; private set; }
	public bool OnPressAttackButton { get; private set; }

	void Update()
	{
		OnInputLeftStick = new Vector3(Input.GetAxis(Constants.HORIZONTAL), 0, Input.GetAxis(Constants.VERTICAL));
		OnPressAttackButton = Input.GetKey(KeyCode.Space);
	}
}
