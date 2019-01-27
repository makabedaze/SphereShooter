using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private IInput _input;
	[SerializeField]
	private float _speed = 0.5f;
	private Transform _transform;
	[SerializeField]
	float x = 0;
	[SerializeField]
	float y = 0;
	[SerializeField]
	float z = 0;

	private void Awake()
	{
		_input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		_transform = transform;
		_transform.SetSphericalPosition(new Vector3(0,30,0));
	}

	private void Update()
	{
		Move(_input.InputLeftStick);
	}

	public void Move(Vector3 inputValue)
	{
		_transform.SphericalTranslate(inputValue.normalized * _speed);
	}

	private void Turn(Vector3 inputValue)
	{

	}
}
