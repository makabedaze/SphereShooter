using System;
using UnityEngine;

public interface IInput
{
	Action<Vector3> OnInputRightStick { get; set; }
	Action<Vector3> OnInputLeftStick { get; set; }
}
