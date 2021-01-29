using UnityEngine;

/// <summary>
/// プレイヤーの入力を各Playerコンポーネントに伝える
/// Playerコンポーネント間の連携もここでする
/// </summary>
[RequireComponent(typeof(PlayerAttack))]
[RequireComponent(typeof(PlayerMove))]
[RequireComponent(typeof(PlayerHealth))]
public class PlayerCore : MonoBehaviour
{
    private IInput _input;
    private PlayerAttack _playerAttack;
    private PlayerMove _playerMove;
    private PlayerHealth _playerHealth;

    private void Start()
    {
        _input = GameObject.FindWithTag(Constants.INPUT).GetComponent<IInput>();
        _playerAttack = GetComponent<PlayerAttack>();
        _playerAttack.Initialize();
        _playerMove = GetComponent<PlayerMove>();
        _playerMove.Initialize();
        _playerHealth = GetComponent<PlayerHealth>();
        _playerHealth.Initialize();
    }

    private void Update()
    {
        _playerAttack.PlayerInput(_input.IsPressAttackButton);
        _playerMove.PlayerInput(_input.InputLeftStick, _input.InputRightStick);
    }
}
