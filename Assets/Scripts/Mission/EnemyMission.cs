using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMission : MonoBehaviour
{
    public int numberEnemyMission;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        switch (numberEnemyMission)
        {
            case 0:
                Mission.instance.numberMocNhan += 1;
                break;
            case 1:
                Mission.instance.numberBulon += 1;
                break;
            case 2:
                Mission.instance.numberUkulele += 1;
                break;
            case 3:
                Mission.instance.numberQuyMap += 1;
                break;
   
            case 4:
                Mission.instance.numberKhiDotDotTruong += 1;
                break;
            case 5:
                Mission.instance.numberKhiDotLongDo += 1;
                break;
            case 6:
                Mission.instance.numberKhiDotLongVang += 1;
                break;
            case 7:
                Mission.instance.numberBoss1 += 1;
                break;
            case 8:
                Mission.instance.numberBoss2 += 1;
                break;
            case 9:
                Mission.instance.numberBoss3 += 1;
                break;
            case 10:
                Mission.instance.numberBoss4 += 1;
                break;
            case 11:
                Mission.instance.numberCaiTrangZabon += 1;
                break;
            
        }
    }
    
}
