using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private IInput _input;
	[SerializeField]
	private float _speed = 0.5f;
	private Transform _transform;
	[SerializeField]
	private Transform _bodyTransform;

	private void Awake()
	{
		_input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		_transform = transform;
	}

	private void Update()
	{
		Move(_input.InputLeftStick);
		Turn(_input.InputRightStick);
	}

	public void Move(Vector3 inputValue)
	{
		_transform.SphericalMove(inputValue,_speed);
	}

	private void Turn(Vector3 inputValue)
	{
		var q = Quaternion.LookRotation(inputValue);
		_bodyTransform.localRotation = q;
	}
}
