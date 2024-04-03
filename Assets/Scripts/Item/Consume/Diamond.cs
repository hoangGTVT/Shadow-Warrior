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
                string number = goldnumber.ToString();
                Inform.instance.ShowInform(number,base.GetName(0));
                break;
            case 1:
                diamondnumber= (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDiamond(diamondnumber);
                base.CreateTextPopUp(0, base.GetPos(), diamondnumber);
                string number1=diamondnumber.ToString();
                Inform.instance.ShowInform(number1,base.GetName(1));
                break;
            case 2:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
                playerLife.PlusKICurrent(playerLife.GetKITotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetHPTotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetKITotal());
                Inform.instance.ShowInform("", base.GetName(2));
                break;
            case 3:
                playerLife.PlusHPCurrent(playerLife.GetHPTotal());
                base.CreateTextPopUp(0, base.GetPos(), playerLife.GetHPTotal());
                Inform.instance.ShowInform("",base.GetName(3));
                break;
            case 4:
                int buacam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaCam(buacam);
                base.CreateTextPopUp(0, base.GetPos(), buacam);
                string buac=buacam.ToString();
                Inform.instance.ShowInform(buac,base.GetName(4));
                break;
            case 5:
                int buavang = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaVang(buavang);
                base.CreateTextPopUp(0, base.GetPos(), buavang);
                string buav=buavang.ToString();
                Inform.instance.ShowInform(buav,base.GetName(5));
                break;
            case 6:
                int buatim = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaTim(buatim);
                base.CreateTextPopUp(0, base.GetPos(), buatim);
                string buat=buatim.ToString();
                Inform.instance.ShowInform(buat,base.GetName(6));
                break;
            case 7:
                int buaxd = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhDuong(buaxd);
                base.CreateTextPopUp(0, base.GetPos(), buaxd);
                string buaxd1=buaxd.ToString();
                Inform.instance.ShowInform(buaxd1,base.GetName(7));
                break;
            case 8:
                int buado = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaDo(buado);
                base.CreateTextPopUp(0, base.GetPos(), buado);
                string buado1=buado.ToString();
                Inform.instance.ShowInform(buado1,base.GetName(8));
                break;
            case 9:
                int buaxam = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXam(buaxam);
                base.CreateTextPopUp(0, base.GetPos(), buaxam);
                string buaxam1=buaxam.ToString();
                Inform.instance.ShowInform(buaxam1,base.GetName(9));
                break;
            case 10:
                int buaxanhla = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusBuaXanhLa(buaxanhla);
                base.CreateTextPopUp(0, base.GetPos(), buaxanhla);
                string buaxanhla1=buaxanhla.ToString();
                Inform.instance.ShowInform(buaxanhla1,base.GetName(10));
                break;
            case 11:
                int daruby = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaRuby(daruby);
                base.CreateTextPopUp(0, base.GetPos(), daruby);
                string daruby1=daruby.ToString();
                Inform.instance.ShowInform(daruby1,base.GetName(11));
                break;
            case 12:
                int datitan = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaTiTan(datitan);
                base.CreateTextPopUp(0, base.GetPos(), datitan);
                string datitan1=datitan.ToString();
                Inform.instance.ShowInform(datitan1,base.GetName(12));
                break;
            case 13:
                int daThachAnh = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaThachAnh(daThachAnh);
                base.CreateTextPopUp(0, base.GetPos(), daThachAnh);
                string dathanhanh1=daThachAnh.ToString();
                Inform.instance.ShowInform(dathanhanh1,base.GetName(13));
                break;
            case 14:
                int das = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaShaphia(das);
                base.CreateTextPopUp(0, base.GetPos(), das);
                string das1=das.ToString();
                Inform.instance.ShowInform(das1,base.GetName(14));
                break;
            case 15:
                int dalucbao = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaLucBao(dalucbao);
                base.CreateTextPopUp(0, base.GetPos(), dalucbao);
                string dalucbao1 = dalucbao.ToString();
                Inform.instance.ShowInform(dalucbao1,base.GetName(15));
                break;
            case 16:
                int dangusac = (int)Random.Range(_minrandom, _maxrandom);
                controller.PlusDaNguSac(dangusac);
                base.CreateTextPopUp(0, base.GetPos(), dangusac);
                string dangusac1 = dangusac.ToString();
                Inform.instance.ShowInform(dangusac1, base.GetName(16));
                break;


        }


    }
        
}
