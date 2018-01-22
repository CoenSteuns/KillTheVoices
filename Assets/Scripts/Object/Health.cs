using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
	[SerializeField] private int _health = 1;
	[SerializeField] private int _maxHealth = 1;
	[SerializeField] private bool _allowRegen = false;
	[SerializeField] private string _playerTag;

	private void Start()
	{
		if(!_allowRegen) return;
		Invoke("HealthRegen", 30);
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		_health -= 1;
		CheckLives();
		Destroy(other.gameObject);
	}

	private void HealthRegen()
	{
		Invoke("HealthRegen", 30);
		if (_health < _maxHealth) _health++;
	}

	private void CheckLives()
	{
		if (gameObject.CompareTag(_playerTag))
		{
			if (_health >= 0) return;
			SceneManager.LoadScene(0);
		}
		else
		{
			GameObject.FindGameObjectWithTag("stats").GetComponent<DeathManager>().EnemyDeath();
			Destroy(gameObject);
		}
	}
}
