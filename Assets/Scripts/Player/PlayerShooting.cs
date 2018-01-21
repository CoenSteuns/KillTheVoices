using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	[SerializeField] private ShootingBehaviour _gun;
	
	private  void OnMouseDown()
	{
		_gun.Shoot();
	}
}
