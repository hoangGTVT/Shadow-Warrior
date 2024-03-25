using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Diamond : ItemManager
{
    public float doubleClickTimeThreshold = 1f;
    protected float lastClickTime = 0f;
    public int _Itemcount;
    public int _minrandom;
    public int _maxrandom;
    public int goldnumber;
    public int diamondnumber;
    private void Start()
    {
        
        //base.DestroyItem(7);
    }

    protected void OnMouseDown()
    {

        if (Time.time - lastClickTime < doubleClickTimeThreshold)
        {

            base.CheckPlayer();
            base.DestroyItem(0.1f);
        }


        lastClickTime = Time.time;
    }

    protected override void PlusItem()
    {
        switch (_Itemcount)
        {
            case 0:
                goldnumber = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusGold(goldnumber);
                base.CreateTextPopUp(0, base.GetPos(), goldnumber);
                
                Inform.instance.ShowInform(base.GetName(0));
                break;
            case 1:
                diamondnumber= (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDiamond(diamondnumber);
                base.CreateTextPopUp(0, base.GetPos(), diamondnumber);
                Inform.instance.ShowInform(base.GetName(1));
                break;
            case 2:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
                playerLife.PlusKICurrent(playerLife.GetKITotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetHPTotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetKITotal());
                Inform.instance.ShowInform(base.GetName(2));
                break;
            case 3:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetHPTotal());
                Inform.instance.ShowInform(base.GetName(3));
                break;
            case 4:
                int buacam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaCam(buacam);
                base.CreateTextPopUp(0, base.GetPos(), buacam);
                Inform.instance.ShowInform(base.GetName(4));
                break;
            case 5:
                int buavang = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaVang(buavang);
                base.CreateTextPopUp(0, base.GetPos(), buavang);
                Inform.instance.ShowInform(base.GetName(5));
                break;
            case 6:
                int buatim = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaTim(buatim);
                base.CreateTextPopUp(0, base.GetPos(), buatim);
                Inform.instance.ShowInform(base.GetName(6));
                break;
            case 7:
                int buaxd = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhDuong(buaxd);
                base.CreateTextPopUp(0, base.GetPos(), buaxd);
                Inform.instance.ShowInform(base.GetName(7));
                break;
            case 8:
                int buado = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaDo(buado);
                base.CreateTextPopUp(0, base.GetPos(), buado);
                Inform.instance.ShowInform(base.GetName(8));
                break;
            case 9:
                int buaxam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXam(buaxam);
                base.CreateTextPopUp(0, base.GetPos(), buaxam);
                Inform.instance.ShowInform(base.GetName(9));
                break;
            case 10:
                int buaxanhla = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhLa(buaxanhla);
                base.CreateTextPopUp(0, base.GetPos(), buaxanhla);
                Inform.instance.ShowInform(base.GetName(10));
                break;
            case 11:
                int daruby = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaRuby(daruby);
                base.CreateTextPopUp(0, base.GetPos(), daruby);
                Inform.instance.ShowInform(base.GetName(11));
                break;
            case 12:
                int datitan = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaTiTan(datitan);
                base.CreateTextPopUp(0, base.GetPos(), datitan);
                Inform.instance.ShowInform(base.GetName(12));
                break;
            case 13:
                int daThachAnh = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaThachAnh(daThachAnh);
                base.CreateTextPopUp(0, base.GetPos(), daThachAnh);
                Inform.instance.ShowInform(base.GetName(13));
                break;
            case 14:
                int das = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaShaphia(das);
                base.CreateTextPopUp(0, base.GetPos(), das);
                Inform.instance.ShowInform(base.GetName(14));
                break;
            case 15:
                int dalucbao = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaLucBao(dalucbao);
                base.CreateTextPopUp(0, base.GetPos(), dalucbao);
                Inform.instance.ShowInform(base.GetName(15));
                break;


        }


    }
        
}
