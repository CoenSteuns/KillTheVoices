using UnityEngine;

public class Spawn : MonoBehaviour
{
	//Instantiate the given entity at the given location
	public void SpawnObject (GameObject entity, Transform startPoint)
	{
		Instantiate(entity, startPoint.position, Quaternion.identity);
	}
}
