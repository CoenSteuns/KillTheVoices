using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
	//[SerializeField] private Transform _target;
	[SerializeField] private Shoot _gunShoot;
	[SerializeField] private float _shootDelay = 2;
	private float _shootTime;
	

	private void Update()
	{
		Shoot();
	}

	private void Shoot()
	{
		print(_shootTime + " " + Time.fixedTime);
		if (_shootTime > Time.fixedTime) return;
		_gunShoot.SpawnBullet(transform);
		_shootTime = Time.fixedTime + _shootDelay;
	}
}
