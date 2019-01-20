using UnityEngine;

public class DebugInput : MonoBehaviour, IInput
{
	public Vector3 InputRightStick { get; private set; }
	public Vector3 InputLeftStick { get; private set; }
	public bool IsPressAttackButton { get; private set; }

	private void Update()
	{
		InputLeftStick = new Vector3(Input.GetAxis(Constants.HORIZONTAL), 0, Input.GetAxis(Constants.VERTICAL));
		IsPressAttackButton = Input.GetKey(KeyCode.Space);
	}
}
