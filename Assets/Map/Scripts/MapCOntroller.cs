using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCOntroller : MonoBehaviour
{
    [Header("Map")]
    public GameObject[] _map;
    public int _mapIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MapIndex();
        for (int i = 0; i < _map.Length; i++)
        {
            if (_map[i].activeSelf)
            {
                _mapIndex = i;
            }

        }
        
    }

    public void NextMap()
    {
        _map[_mapIndex].SetActive(false);
        _mapIndex++;
        _map[_mapIndex].SetActive(true);
  
    }

    public void PreMap()
    {
        _map[_mapIndex].SetActive(false);
        _mapIndex--;
        _map[_mapIndex].SetActive(true);
    }

    public int MapIndex()
    {
        return _mapIndex;
    }
}
