using UnityEngine;

public class Bullet : MonoBehaviour
{
	private IAttacker _attacker;

	[SerializeField]
	private float _speed = 1f;
	[SerializeField]
	private float _lifeTime = 1f;
	private Vector3 _direction;

	public void Shoot(IAttacker attacker, Vector3 direction )
	{
		_attacker = attacker;
		_direction = direction;
		transform.forward = direction;
		
		Destroy(this.gameObject, _lifeTime);
	}
	
	private void Update()
	{
		transform.SphericalMove(Vector3.forward,_speed);
	}

	private void OnTriggerEnter(Collider hitTarget)
	{
		var hitTargetAttacker = hitTarget.GetComponent<IAttacker>();
		if (hitTargetAttacker != null && _attacker.AttackerId == hitTargetAttacker.AttackerId)
		{
			return;
		}

		var hitTargetDamageable = hitTarget.GetComponent<IDamageable<int>>();
		if (hitTargetDamageable != null)
		{
			hitTargetDamageable.TakeDamage(100);
			Destroy(this.gameObject, 0f);
		}
	}
}
    