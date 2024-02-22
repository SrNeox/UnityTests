using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;

    private int _correntPoint = 0;

    private void Update()
    {
        if(transform.position == _points[_correntPoint].position)
        {
            _correntPoint = (_correntPoint + 1) % _points.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _points[_correntPoint].position, _speed * Time.deltaTime);
    }
}
