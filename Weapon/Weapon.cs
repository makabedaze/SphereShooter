using UnityEngine;

public class Weapon : MonoBehaviour {
	private IAttacker _attacker;

	[SerializeField]
	private Bullet _bullet;
	[SerializeField]
	private GameObject _muzzle;
	[SerializeField]
	private float _fireInterval = 0.3f;
	private float _intervalTimer = 0f;

	public void Initialize(IAttacker attacker)
	{
		_attacker = attacker;
	}

	public void Fire()
	{
		if (CanFire() == false) 
		{
			return;
		}

		var muzzleTransform = _muzzle.transform;
		var bullet = Instantiate<Bullet>(_bullet, muzzleTransform.position, muzzleTransform.rotation);
		bullet.Shoot(_attacker, muzzleTransform.forward);
		_intervalTimer = 0f;
	}

	private bool CanFire() 
	{
		return _intervalTimer > _fireInterval;
	}

	private void Update()
	{
		_intervalTimer += Time.deltaTime;
	}
}
