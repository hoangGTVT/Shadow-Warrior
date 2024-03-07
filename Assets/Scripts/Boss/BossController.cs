using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] private BossSO bossSO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bossSO.GetATK());
    }
}
