using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
	[SerializeField]
	private Bullet _bullet;
	[SerializeField]
	private Transform _muzzleTransform;

	public void Fire()
	{
		var bullet = Instantiate<Bullet>(_bullet, _muzzleTransform.position, _muzzleTransform.rotation);
		bullet.Shoot(_muzzleTransform.forward);
	}
}
