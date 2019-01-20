using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private IInput _input;
	[SerializeField]
	private float _speed = 0.5f;
	private Transform _transform;

	private void Awake()
	{
		_input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		_transform = transform;
	}

	private void Update()
	{
		Move(_input.InputLeftStick);
	}

	public void Move(Vector3 inputValue)
	{
		_transform.position += inputValue.normalized * _speed * Time.deltaTime;
	}

	private void Turn(Vector3 inputValue)
	{

	}
}
