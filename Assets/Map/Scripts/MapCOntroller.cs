using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

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
    public GameObject[] pannel;
    public int indexpannel;
    public Vector2 positionPlayer;
    void Start()
    {
        SetIndexPannel();
        ActivePannel();
        _map[_mapIndex].SetActive(true);
        player.transform.position = positionPlayer;

    }
    private void FixedUpdate()
    {
        SetIndexPannel();
        ActivePannel();
        if (player != null)
        {
            positionPlayer = new Vector2(player.transform.position.x, player.transform.position.y);
        }
    }
    // Update is called once per frame
    void Update()
    {

       
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
    public void ActivePannel()
    {
        
        for(int i = 0; i < indexpannel; i++)
        {
            pannel[i].SetActive(false);
        }
    }
    public void SetIndexPannel()
    {
        switch (Mission.instance.indexMission)
        {
            case 1:
                indexpannel = 1;
                break;
            case 2:
                indexpannel = 2;
                break;
            case 3:
                indexpannel = 3;
                break;
            case 4:
                indexpannel = 4;
                break;
            case 5:
                indexpannel = 5;
                break;
            case 6:
                indexpannel = 6;
                break;
            case 7:
                indexpannel = 7;
                break;
            case 8:
                indexpannel = 8;
                break;
            case 9:
                    indexpannel = 9;
                break;
            
        }
    }

    
}
