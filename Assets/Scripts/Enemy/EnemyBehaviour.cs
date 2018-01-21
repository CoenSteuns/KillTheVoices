using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
	[SerializeField] private float _shootDelay = 2;
	[SerializeField] private GameObject _bullet;
	[SerializeField] private string _tag;
	private Spawn _gunShoot;
	private float _shootTime;

	private void Start()
	{
		_gunShoot = GameObject.FindGameObjectWithTag(_tag).GetComponent<Spawn>();
	}
	
	private void Update()
	{
		Shoot();
	}

	//Only shoot when a certain amount of time has passed
	private void Shoot()
	{
		if (_shootTime > Time.fixedTime) return;
		_gunShoot.SpawnObject(_bullet, transform);
		_shootTime = Time.fixedTime + _shootDelay;
	}
}
