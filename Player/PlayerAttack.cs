using UnityEngine;

/// <summary>
/// Weaponにプレイヤーの入力を伝える
/// </summary>
public class PlayerAttack : MonoBehaviour, IAttacker
{
	public Id AttackerId { get; } = Id.Player;
	[SerializeField]
	private Weapon _weapon;

	public void Initialize()
	{
		_weapon.Initialize(this);
	}

	/// <summary>
	/// 入力をもとに移動、旋回をする
	/// </summary>
	/// <param name="leftStick"></param>
	/// <param name="rightStick"></param>
	public void PlayerInput(bool isPressAttackButton)
	{
		if (isPressAttackButton)
		{
			_weapon.Fire();
		}
	}
}
