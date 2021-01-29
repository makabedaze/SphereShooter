using UnityEngine;

/// <summary>
/// 移動、旋回を行う
/// </summary>
public class PlayerMove : MonoBehaviour
{
	[SerializeField]
	private float _speed = 5f;
	private Transform _transform;
	// Playerの見た目
	[SerializeField]
	private Transform _bodyTransform;

	public void Initialize()
	{
		_transform = transform;
	}

	/// <summary>
    /// 入力をもとに移動、旋回をする
    /// </summary>
    /// <param name="leftStick"></param>
    /// <param name="rightStick"></param>
	public void PlayerInput(Vector3 leftStick, Vector3 rightStick)
	{
		Move(leftStick);
		Turn(leftStick);
	}

	/// <summary>
    /// 移動
    /// </summary>
    /// <param name="inputValue"></param>
	private void Move(Vector3 inputValue)
	{
		_transform.SphericalMove(inputValue,_speed);
	}

	/// <summary>
    /// 旋回
    /// </summary>
    /// <param name="inputValue"></param>
	private void Turn(Vector3 inputValue)
	{
		// inputが無い時に正面を向いてしまうため
		if (inputValue == Vector3.zero)
		{
			return;
		}

		_bodyTransform.localRotation = Quaternion.LookRotation(inputValue);
	}
}
