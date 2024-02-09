using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watcher : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _enemy;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _player.position;
    }

    private void Update()
    {
        transform.position = _player.position + _offset;
        transform.LookAt(_enemy.transform);
        transform.RotateAround(_player.position, Vector3.up, _speed * Time.deltaTime);
        _offset = transform.position - _player.position;
    }
}
