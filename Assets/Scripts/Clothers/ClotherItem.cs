using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClotherItem : MonoBehaviour
{
    public ClothersController clothersController;
    public ClotherManager clotherManager;
    public GameObject player;
    public float doubleClickTimeThreshold = 1f;
    protected float lastClickTime = 0f;
    public LayerMask playerLayer; 
    public float detectionRadius = 5f;
    public bool playerDetected;
    [Header("Clother")]
    public string typeclother;
    public int indexAo;
    public int indexQuan;
    public int indexGang;
    public int indexGiay;
    public int indexRada;
    void Start()
    {
        FindPlayer();
    }

    // Update is called once per frame
    void Update()
    {

        CheckPlayer();


    }
    public void OnMouseDown()
    {

        if (Time.time - lastClickTime < doubleClickTimeThreshold)
        {
            if (playerDetected)
            {
                CheckType();
                Destroy(gameObject, 0.1f);
            }
            

        }


        lastClickTime = Time.time;
    }
    
    public bool CheckPlayer()
    {
         playerDetected = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
        return playerDetected;
    }
    public void CheckType()
    {
        PickUpAo();
        PickUpQuan();
        PickUpGang();
        PickUpGiay();
        PickUpRada();
    }
    public void PickUpQuan()
    {
        if (typeclother == "Quan")
        {
            clotherManager.PlusQuan(indexQuan);
            Inform.instance.ShowInformClother(clothersController.pan[indexQuan].GetName());
            
        }
    }
    public void PickUpAo()
    {
        if (typeclother == "Ao")
        {
            clotherManager.PlusAo(indexAo);
            Inform.instance.ShowInformClother(clothersController.clothesSOs[indexAo].GetName());
                   
            
        }
    }
    public void PickUpGang()
    {
        if (typeclother == "Gang")
        {
            clotherManager.PlusGang(indexGang);
            Inform.instance.ShowInformClother(clothersController.gang[indexGang].GetName());
           
        }
    }
    public void PickUpGiay()
    {
        if (typeclother == "Giay")
        {
            clotherManager.PlusGiay(indexGiay);
            Inform.instance.ShowInformClother(clothersController.giay[indexGiay].GetName());
            
        }
    }
    public void PickUpRada()
    {
        if (typeclother == "Rada")
        {
            clotherManager.PlusRada(indexRada);
            Inform.instance.ShowInformClother(clothersController.rada[indexRada].GetName());
            
        }
    }

    public void FindPlayer()
    {
        player = GameObject.Find("Player");
        if (player != null )
        {
            clothersController=player.GetComponentInChildren<ClothersController>();
            clotherManager=player.GetComponentInChildren<ClotherManager>();
        }
        else
        {
            clothersController=null;
            clotherManager = null;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
