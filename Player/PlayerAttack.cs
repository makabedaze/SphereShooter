using System;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	private IInput input;
	[SerializeField]
	private Weapon weapon;

	void Awake()
	{
		input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
	}

	void Update()
	{
		if (input.OnPressAttackButton) 
		{
			weapon.Fire();
		}
	}
}
