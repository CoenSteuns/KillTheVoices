using UnityEngine;

public class AutoDestruct : MonoBehaviour
{
	[SerializeField] private float _destructTime;
	
	private void Start () {
		Invoke("Destruct", _destructTime);
	}
	
	private void Destruct () {
		Destroy(gameObject);
	}
}
