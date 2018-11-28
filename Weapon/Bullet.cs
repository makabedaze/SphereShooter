using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IShootable
{
	[SerializeField]
	private float _speed = 1f;
	private Vector3 _direction;

	public void Shoot(Vector3 direction)
	{
		transform.forward = direction;
		_direction = direction;
	}
	
	private void Update()
	{
		transform.position += _direction * _speed;
	}
}
    