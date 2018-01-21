using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	[SerializeField] private ShootingBehaviour _gun;
	
	private void Update()
	{
		if(Input.GetMouseButtonDown(0)) _gun.Shoot();
	}
}
