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


		// マウス位置座標をスクリーン座標からワールド座標に変換する
		//var mousePosition = Input.mousePosition;
		//mousePosition.z = 10f;
		//InputRightStick = Camera.main.ScreenToWorldPoint(mousePosition);
		var pos = Input.mousePosition - Camera.main.WorldToScreenPoint(Vector3.zero);
		var inputRightStick = new Vector3(pos.x, 0, pos.y);
		InputRightStick = inputRightStick.normalized;
		Debug.Log(InputRightStick.normalized);
		Debug.Log(InputRightStick);
	}
}
