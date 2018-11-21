using UnityEngine;

[RequireComponent(typeof(PlayerCore))]
public class PlayerMove : MonoBehaviour
{
	[SerializeField]
	private float _speed = 0.5f;
	private Transform _transform;

	void Awake()
	{
		_transform = this.transform;

		var core = GetComponent<PlayerCore>();
		core.OnIntputLeftStick += Move;
		core.OnInputRightStick += Turn;
	}

	public void Move(Vector3 inputValue)
	{
		_transform.position += inputValue.normalized * _speed;
	}

	private void Turn(Vector3 inputValue)
	{

	}
}
