using UnityEngine;

public class Shoot : MonoBehaviour
{
	[SerializeField] private GameObject _bullet;
	
	public void SpawnBullet (Transform startPoint)
	{
		Instantiate(_bullet, startPoint.position, Quaternion.identity);
	}
	
}
