using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _vector;
    private void Update()
    {
        transform.Rotate( _vector );
    }
}
