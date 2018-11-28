using UnityEngine;

[RequireComponent(typeof(PlayerCore))]
public class PlayerMove : MonoBehaviour
{
	private IInput input;
	[SerializeField]
	private float _speed = 0.5f;
	private Transform _transform;

	void Awake()
	{
		input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		
		_transform = transform;
	}

	void Update()
	{
		Move(input.OnInputLeftStick);
	}

	public void Move(Vector3 inputValue)
	{
		_transform.position += inputValue.normalized * _speed;
	}

	private void Turn(Vector3 inputValue)
	{

	}
}
