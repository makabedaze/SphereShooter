using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private IInput _input;
	[SerializeField]
	private GameObject _playerPrefab;
	//透明のGameObjectをスタート地点にする
	[SerializeField]
	private Transform _startPosition;

	void Start()
	{
		var player = Instantiate(_playerPrefab, _startPosition.position, Quaternion.identity);
	}
}
