using System;
using UnityEngine;

public interface IInput
{
	Vector3 OnInputRightStick { get; }
	Vector3 OnInputLeftStick { get; }
	bool OnPressAttackButton { get; }
}
