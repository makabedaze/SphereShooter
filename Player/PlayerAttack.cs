using UnityEngine;

public class PlayerAttack : MonoBehaviour,IAttacker {
	private IInput _input;
	public Id AttackerId { get; } = Id.Player;
	[SerializeField]
	private Weapon _weapon;

	private void Awake()
	{
		_input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
		_weapon.Initialize(this);
	}

	private void Update()
	{
		if (_input.IsPressAttackButton) 
		{
			_weapon.Fire();
		}
	}
}
