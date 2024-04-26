using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [Header("Map")]
    public GameObject[] _map;
    public int _mapIndex;
    public int _mapIndex2;
    public GameObject player;
    public GameObject[] pos;
    public GameObject[] posBoss;
    public GameObject loading;
    public int distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distance = Mathf.Abs((int)(player.transform.position.x - transform.position.x));
    }

    public int GetMapIndex() { return _mapIndex; }
    public void SetMapIndex(int index) { _mapIndex = index; }
    public void SetMapIndex2(int index) { _mapIndex2 = index; }
    public void SetMapGoHome()
    {
        loading.SetActive(true);
        _map[_mapIndex].SetActive(false);
        SetMapIndex(0);
        SetMapIndex2(0);
        _map[_mapIndex].SetActive(true);
        player.transform.position = pos[0].transform.position;
    }
    public void ActiveMap(int index)
    {
        if (player != null)
        {
            loading.SetActive(true);

            _mapIndex = index;
            _map[_mapIndex].SetActive(true);
            if (_mapIndex2 < _mapIndex)
            {
                player.transform.position = pos[index + _mapIndex2].transform.position;
            }
            else if (_mapIndex2 > _mapIndex)
            {
                player.transform.position = pos[index + _mapIndex2 - 1].transform.position;
            }
            player.SetActive(false);
            _map[_mapIndex2].SetActive(false);
            _mapIndex2 = _mapIndex;

        }

    }

    public void ActiveMapBoss(int mapboss)
    {
        if (player != null )
        {
            loading.SetActive(true);
            _mapIndex = mapboss;
            _map[_mapIndex].SetActive(true);
            _map[_mapIndex2].SetActive(false);
            _mapIndex2 =mapboss;
            if (mapboss > 10)
            {
                player.transform.position = pos[mapboss+9].transform.position;
            }else
                switch (mapboss)
                {
                    case 3:
                        
                         player.transform.position = posBoss[0].transform.position;
                         break;
                        
                    case 5:
                        player.transform.position = posBoss[1].transform.position;
                        break;
                    case 7:
                        player.transform.position = posBoss[2].transform.position;
                        break;
                    case 10:
                        player.transform.position = posBoss[3].transform.position;
                        break;

                }
           
        }
    }

    
}
