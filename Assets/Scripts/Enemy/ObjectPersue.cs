﻿using UnityEngine;

public class ObjectPersue : MonoBehaviour
{
	[SerializeField] private float _maxSpeed = 3;
	[SerializeField] private Transform _target;
    private Vector2 _currentSpeed;
    private Vector2 _objectPosition;
   
	private void Start() 
	{
        _currentSpeed = new Vector2(0, 0);
        _objectPosition = transform.position;
    }
  
	private void Update() 
	{
        Persue();
    }

	private void Persue() 
	{    
        var direction = (Vector2)_target.position - _objectPosition;
        direction.Normalize();
        var wantedSpeed = direction * _maxSpeed;
 
        var movementForce = wantedSpeed - _currentSpeed;
        _currentSpeed += movementForce;

        _objectPosition += _currentSpeed * Time.deltaTime;
        transform.position = _objectPosition;
		
		var angle = Mathf.Atan2(_currentSpeed.y, _currentSpeed.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}