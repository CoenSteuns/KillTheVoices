using UnityEngine;

public class Spawn : MonoBehaviour
{
	//Instantiate the given entity at the given location
	public void SpawnObject (GameObject entity, Transform startPoint)
	{
		var gObject = Instantiate(entity, startPoint.position, Quaternion.identity);
	}
}
