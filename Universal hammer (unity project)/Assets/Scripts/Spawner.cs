using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objectPrefabs;

    private GameObject _activeObject;

    private void Awake()
    {
        Actions.Instance.OnHitEnd += SpawnObject;
        Actions.Instance.OnHitMiddle += DestroyObject;
    }

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        var randomObjectIndex = UnityEngine.Random.Range(0, _objectPrefabs.Count);
        _activeObject = Instantiate(_objectPrefabs[randomObjectIndex], transform);
        _activeObject.name = _activeObject.name.Split('(')[0];
    }

    private void DestroyObject()
    {
        if (_activeObject != null)
            Destroy(_activeObject);
    }
}
