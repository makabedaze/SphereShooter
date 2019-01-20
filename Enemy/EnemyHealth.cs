using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable<int>
{
	private DamageEffect _damageEffect;

	private void Start()
	{
		_damageEffect = GetComponent<DamageEffect>();
	}

	public void TakeDamage(int damageValue)
	{
		StartCoroutine(_damageEffect.Play());
		Debug.Log(damageValue + "ダメージ。めっちゃ痛い");
	}
}
