using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IputPlayer : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        float horizonatal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(horizonatal, 0, vertical);
    }
}
