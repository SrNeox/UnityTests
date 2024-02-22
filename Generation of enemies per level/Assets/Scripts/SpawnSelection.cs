using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;


public class SpawnSelection : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _target;
    [SerializeField] private MoverPursuer _moverPursuer;

    public event UnityAction SeconsSpawner;

    private void Start()
    {
        StartCoroutine(Spawn(2));
    }

    private IEnumerator Spawn(int delay)
    {
        while(true)
        {
            if (Random.Range(0, 2) == 1)
            {
                _prefab.transform.position = transform.position;
                Instantiate(_prefab);
                _moverPursuer._target = _target;
            }
            else
            {
                SeconsSpawner?.Invoke();
            }

            yield return new WaitForSeconds(delay);
        }
    }
}
