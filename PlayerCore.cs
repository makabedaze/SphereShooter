using System;
using UnityEngine;

public class PlayerCore : MonoBehaviour, IDamageable<int>, IDieable
{
	public Action<Vector3> OnInputRightStick { get; set; }
	public Action<Vector3> OnIntputLeftStick { get; set; }
	public Action OnInputAttackButton { get; set; }
	public Action<int> OnTakeDamage { get; set; }
	public Action OnDead { get; set; }

	 private void Start()
	{
		var input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		input.OnInputRightStick += OnInputRightStick;
		input.OnInputLeftStick += OnIntputLeftStick;
		input.OnInputAttackButton += OnInputAttackButton;
	}

	public void TakeDamage(int value)
	{
		OnTakeDamage.NullSafe(value);
	}

	public void Die()
	{
		OnDead.NullSafe();
	}
}
