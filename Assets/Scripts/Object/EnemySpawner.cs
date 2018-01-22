using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private float _spawnDelay = 5;
	[SerializeField] private int _maxEnemies = 10;
	[SerializeField] private Transform[] _spawnArea;
	[SerializeField] private GameObject _enemy;
	[SerializeField] private string _tag;
	private Spawn _spawner;
	private GameObject[] _enemiesAlive;
	private float _spawnTime = 0;
	private bool _allowSpawning = true;

	private void Start()
	{
		_spawner = GameObject.FindGameObjectWithTag(_tag).GetComponent<Spawn>();
	}

	private void Update()
	{
		if(!_allowSpawning) return;
		_enemiesAlive = GameObject.FindGameObjectsWithTag("Enemy");
		if(_enemiesAlive.Length > _maxEnemies) return;
		if (_spawnTime > Time.fixedTime) return;
		for (var i = _enemiesAlive.Length; i < _maxEnemies; i++)
		{
			var randomInt = Random.Range(0, 3);
			_spawner.SpawnObject(_enemy, _spawnArea[randomInt]);
			_spawnTime = Time.fixedTime + _spawnDelay;
		}
	}

	public void DenySpawning()
	{
		_allowSpawning = false;
	}
}
