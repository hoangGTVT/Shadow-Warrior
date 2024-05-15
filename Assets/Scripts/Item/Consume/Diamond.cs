using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Diamond : MonoBehaviour
{
    public ItemManager itemManager;
    public ItemController controller;
    public PlayerLife playerLife;
    public GameObject player;
    public int _Itemcount;
    public int _minrandom;
    public int _maxrandom;
    public int goldnumber;
    public int diamondnumber;
    public LayerMask playerLayer;
    public float detectionRadius = 5f;
    public bool playerDetected;
    public bool cantake;
    private void Start()
    {
        FindPlayer();
        Destroy(gameObject, 5);
        
    }

    private void Update()
    {
        CheckPlayer1();
        PlayerTakeItem();
    }
    public void PlayerTakeItem()
    {
        if (playerDetected)
        {
            PlusItem();
            AudioManager.instance.Play("Item");
            Destroy(gameObject);
        }
        
    }

    public void FindPlayer()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            playerLife = player.GetComponentInChildren<PlayerLife>();
            itemManager=player.GetComponentInChildren<ItemManager>();
            controller=player.GetComponentInChildren<ItemController>();
        }
        else
        {
            playerLife=null;
            itemManager=null;
            controller=null;
        }
    }

    protected  void PlusItem()
    {
        switch (_Itemcount)
        {
            case 0:
                goldnumber = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusGold(goldnumber);
               
                string number = goldnumber.ToString();
                Inform.instance.ShowInform(number,itemManager.GetName(0));
                break;
            case 1:
                diamondnumber= (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDiamond(diamondnumber);
               
                string number1=diamondnumber.ToString();
                Inform.instance.ShowInform(number1,itemManager.GetName(1));
                break;
            case 2:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
                playerLife.PlusKICurrent(playerLife.GetKITotal());
                playerLife.PlusStaCurrent(playerLife.GetStaminaTotal());
               
                Inform.instance.ShowInform("", itemManager.GetName(2));
                break;
            case 3:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
               
                Inform.instance.ShowInform("",itemManager.GetName(3));
                break;
            case 4:
                int buacam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaCam(buacam);
               
                string buac=buacam.ToString();
                Inform.instance.ShowInform(buac,itemManager.GetName(4));
                break;
            case 5:
                int buavang = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaVang(buavang);
              
                string buav=buavang.ToString();
                Inform.instance.ShowInform(buav,itemManager.GetName(6));
                break;
            case 6:
                int buatim = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaTim(buatim);
                
                string buat=buatim.ToString();
                Inform.instance.ShowInform(buat,itemManager.GetName(7));
                break;
            case 7:
                int buaxd = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhDuong(buaxd);
               
                string buaxd1=buaxd.ToString();
                Inform.instance.ShowInform(buaxd1,itemManager.GetName(8));
                break;
            case 8:
                int buado = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaDo(buado);
               
                string buado1=buado.ToString();
                Inform.instance.ShowInform(buado1,itemManager.GetName(5));
                break;
            case 9:
                int buaxam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXam(buaxam);
                
                string buaxam1=buaxam.ToString();
                Inform.instance.ShowInform(buaxam1,itemManager.GetName(10));
                break;
            case 10:
                int buaxanhla = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhLa(buaxanhla);
               
                string buaxanhla1=buaxanhla.ToString();
                Inform.instance.ShowInform(buaxanhla1,itemManager.GetName(9));
                break;
            case 11:
                int daruby = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaRuby(daruby);
                
                string daruby1=daruby.ToString();
                Inform.instance.ShowInform(daruby1,itemManager.GetName(11));
                break;
            case 12:
                int datitan = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaTiTan(datitan);
               
                string datitan1=datitan.ToString();
                Inform.instance.ShowInform(datitan1,itemManager.GetName(12));
                break;
            case 13:
                int daThachAnh = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaThachAnh(daThachAnh);
                
                string dathanhanh1=daThachAnh.ToString();
                Inform.instance.ShowInform(dathanhanh1,itemManager.GetName(13));
                break;
            case 14:
                int das = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaShaphia(das);
                
                string das1=das.ToString();
                Inform.instance.ShowInform(das1,itemManager.GetName(14));
                break;
            case 15:
                int dalucbao = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaLucBao(dalucbao);
               
                string dalucbao1 = dalucbao.ToString();
                Inform.instance.ShowInform(dalucbao1,itemManager.GetName(15));
                break;
            case 16:
                int dangusac = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaNguSac(dangusac);
               
                string dangusac1 = dangusac.ToString();
                Inform.instance.ShowInform(dangusac1, itemManager.GetName(16));
                break;


        }


    }
    
    public bool CheckPlayer1()
    {
       
        
            playerDetected = Physics2D.OverlapCircle(transform.position, detectionRadius, playerLayer);
            return playerDetected;
       

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

}
