using UnityEngine;

[RequireComponent(typeof(PlayerCore))]
public class PlayerMove : MonoBehaviour
{
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
		_transform.position += inputValue;
	}

	private void Turn(Vector3 inputValue)
	{

	}
}
