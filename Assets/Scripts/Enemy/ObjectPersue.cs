﻿using UnityEngine;

public class ObjectPersue : MonoBehaviour
{
	[SerializeField] private float _maxSpeed = 3;
	[SerializeField] private float _keptDistance;
	[SerializeField] private string _targetTag;
	private Transform _target;
    private Vector2 _currentSpeed;
    private Vector2 _objectPosition;
   
	private void Start() 
	{
		_target = GameObject.FindGameObjectWithTag(_targetTag).transform;
        _currentSpeed = new Vector2(0, 0);
        _objectPosition = transform.position;
    }
  
	private void Update() 
	{
        Persue();
    }

	private void Persue() 
	{   
		//check distance from target
        var distance = (Vector2)_target.position - _objectPosition;
		if(distance.magnitude < _keptDistance) return;
		
		//calculate direction to target
        var direction = distance.normalized;
        var wantedSpeed = direction * _maxSpeed;
 
		//calculate speed
        var movementForce = wantedSpeed - _currentSpeed;
        _currentSpeed += movementForce;
		
		//move object
        _objectPosition += _currentSpeed * Time.deltaTime;
        transform.position = _objectPosition;
		
		//rotate object
		var angle = Mathf.Atan2(_currentSpeed.y, _currentSpeed.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}