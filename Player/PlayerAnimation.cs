using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	private IInput _input;
	private Transform _playerTransform;
	[SerializeField]
	private float _rotationSpeed = 200f;
	[SerializeField]
	private float _maxRotateAngle = 50f;

	private void Start()
    {
		_input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		_playerTransform = transform;
	}

	private void Update()
	{
		Lean();
	}

	//入力に応じて傾ける
	private void Lean()
	{
		//正面に対して入力方向が右側か左側か
		var axis = Vector3.Cross(_playerTransform.forward, _input.InputLeftStick).y < 0 ? 1 : -1;
		//正面と入力方向のなす角
		var angle = Vector3.Angle(_playerTransform.forward, _input.InputLeftStick);
		var step = _rotationSpeed * Time.deltaTime;
		var targetRotation = Quaternion.Euler(0, 0, _maxRotateAngle * GetClosenessToRightAngle(angle) * axis);

		if (angle < 30) 
		{
			targetRotation = Quaternion.Euler(0, 0, 0);	
		}

		//stepに応じてtargetRotationに向けて傾ける
		_playerTransform.localRotation = Quaternion.RotateTowards(_playerTransform.localRotation, targetRotation, step);
	}

	//どれだけ直角に近いか割合を返す
 	private float GetClosenessToRightAngle(float angle) 
	{
		const float RIGHT_ANGLE = 90f;
		if (RIGHT_ANGLE < angle)
		{
			return (RIGHT_ANGLE*2 - angle) / RIGHT_ANGLE;
		}
		else
		{
			return (angle) / RIGHT_ANGLE;
		}
	}
}
