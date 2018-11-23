using System;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	public Action OnInputAttackButton { get; set; }

	void Awake()
	{
		var core = GetComponent<PlayerCore>();
		core.OnInputAttackButton += OnInputAttackButton;
		core.OnInputAttackButton += () => Debug.Log("Bang!");
	}
}
