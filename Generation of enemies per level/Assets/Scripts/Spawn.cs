using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawn : MonoBehaviour
{
    [SerializeField] private SpawnSelection _spawnSelection;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _target;
    [SerializeField] private MoverPursuer _moverPursuer;

    private void OnEnable()
    {
        _spawnSelection.SeconsSpawner += Create;
    }

    private void OnDisable()
    {
        _spawnSelection.SeconsSpawner -= Create;
    }

    private void Create()
    {
        _prefab.transform.position = transform.position;
        Instantiate(_prefab);
        _moverPursuer._target = _target;

    }
}
