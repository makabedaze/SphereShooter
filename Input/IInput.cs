using UnityEngine;

public interface IInput
{
	Vector3 InputRightStick { get; }
	Vector3 InputLeftStick { get; }
	bool IsPressAttackButton { get; }
}
