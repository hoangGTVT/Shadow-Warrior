using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    public static Mission instance;
    
    [Header("Mission")]
    public int indexMission;
    //nv1
    public int numberMocNhan;
    //nv3
    public int numberBulon;
    public int numberUkulele;
    public int numberQuyMap;
    public int smPlayer;
    //nv8
    public int numberBoss1;
    //nv10;
    public int numberKhiDotDotTruong;
    public int numberKhiDotLongVang;
   public int numberKhiDotLongDo;
    //nv11;
    public int numberBoss2;
    //nv12
    public int numberCaiTrangZabon;
    
    //nv14;
    public int numberBoss3;
    public int numberBoss4;



    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
           
        }
    }

    

}
