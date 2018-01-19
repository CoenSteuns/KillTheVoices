using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float _speed = 5;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction, bool UseDeltatime = false, float speedMultiplier = 1)
    {
        var velocity = direction * _speed * speedMultiplier;

        if (UseDeltatime)
            velocity *= Time.deltaTime;

        _rb.position += velocity;
    }
}
