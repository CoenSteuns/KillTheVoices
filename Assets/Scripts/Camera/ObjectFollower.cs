using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour {

    [SerializeField] private GameObject _object;

    private void LateUpdate()
    {
        this.transform.position = _object.transform.position;
    }
}
