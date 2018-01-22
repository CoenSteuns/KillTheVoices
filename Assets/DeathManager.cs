using UnityEngine;

public class DeathManager : MonoBehaviour
{
	[SerializeField] private AudioSource _voices;
	[SerializeField] private float _maxAlive = 15;
	private float _alive;

	private void Start()
	{
		_alive = _maxAlive;
	}
	
	private void Update()
	{
		var oneP = _maxAlive / 100;
		var percentage = oneP * _alive;
		print(percentage);
		_voices.volume = percentage;
	}

	public void EnemyDeath()
	{
		print("test");
		_alive -= 1;
	}
}
