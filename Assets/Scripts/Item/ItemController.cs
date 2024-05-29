using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int _gold;
    public int _diamond;
    public int _duiga;
    public int _cachua;
    public int _buacam;
    public int _buavang;
    public int _buatim;
    public int _buaxanhduong;
    public int _buado;
    public int _buaxam;
    public int _buaxanhla;
    public int _daruby;
    public int _datitan;
    public int _dathachanh;
    public int _dashaphia;
    public int _dalucbao;
    public int _danngusac;


    //GetItem

    public int GetGold() { return _gold; }
    public int GetDiamond() { return _diamond;}
    public int GetDuiga() { return _duiga;} 
    public int GetCaChua() { return _cachua; }
    public int GetBuaCam() { return _buacam;}
    public int GetBuaVang() { return _buavang;}
    public int GetBuaTim() { return _buatim; }
    public int GetBuaxanhla() {  return _buaxanhla;}
    public int GetBuaXanhDuong() { return _buaxanhduong; }
    public int GetBuaXam() { return _buaxam;}
    public int GetBuaDo() { return _buado; }
    public int GetDaRuby() { return _daruby; }
    public int GetDaTiTan() { return _datitan; }
    public int GetDaThachAnh() { return _dathachanh; }
    public int GetDaShaphia() { return _dashaphia; }
    public int GetDaLucBao() { return _dalucbao; }  
    public int GetDaNguSac() { return _danngusac; }
    //SetItem

    public void SetGold(int index) { _gold=index;}  
    public void SetDiamond(int index) { _diamond=index;}
    public void SetDuiGa(int index) { _duiga=index;}
    public void SetCaChua(int index) { _cachua=index;}
    public void SetBuaCam(int index) { _buacam = index; }
    public void SetBuaVang(int index) { _buavang = index; }
    public void SetBuaTim(int index) { _buatim = index; }
    public void SetBuaXanhLa(int index) { _buaxanhla = index; }
    public void SetBuaDo(int index) { _buado = index; }
    public void SetBuaXanhDuong(int index) { _buaxanhduong = index; }
    public void SetBuaXam(int index) { _buaxam = index; }
    public void SetDaRuby(int indez) { _daruby = indez;}
    public void SetDaTiTan(int index) { _datitan = index;}
    public void SetDaThachAnh(int index) { _dathachanh = index;}
    public void SetDaShaphia(int index) { _dashaphia = index;}
    public void SetDaLucBao(int index) { _dalucbao = index;}
    public void SetDaNguSac(int index) { _danngusac = index;}

    //plusItem
    public void PlusGold(int index) { _gold += index; }
    public void PlusDiamond(int index) { _diamond += index;}
    public void PlusDuiGa(int index) { _duiga += index;}
    public void PlusCaChua(int index) { _cachua += index;}
    public void PlusBuaCam(int index) { _buacam += index;}
    public void PlusBuaVang(int index) { _buavang += index; }
    public void PlusBuaTim(int index) { _buatim += index; }
    public void PlusBuaXanhLa(int index) { _buaxanhla += index; }
    public void PlusBuaDo(int index) { _buado += index; }
    public void PlusBuaXanhDuong(int index) { _buaxanhduong += index; }
    public void PlusBuaXam(int index) { _buaxam += index; }
    public void PlusDaRuby(int index) { _daruby += index; }
    public void PlusDaTiTan(int index) { _datitan += index; }
    public void PlusDaThachAnh(int index) { _dathachanh += index; }
    public void PlusDaShaphia(int index) { _dashaphia += index; }
    public void PlusDaLucBao(int index) { _dalucbao += index; }
    public void PlusDaNguSac(int index) { _danngusac += index; }


    //MinusItem
    public void MinusGold(int index) { 
        if (!(_gold >= index)) return;
        _gold -= index;
    }
    public void MinusDiamond(int index)
    {
        if (!(_diamond >= index)) return;
        _diamond -= index;
    }
    public void MinusDuiGa()
    {
        if (!(_duiga >0)) return;
        _duiga -= 1;
    }
    public void MinusCaChua()
    {
        if (!(_cachua > 0)) return;
        _cachua -= 1;
    }
    public void MinusBuacam(int index)
    {
        if (!(_buacam >= index)) return;
        _buacam -= index;
    }
    public void MinusBuaVang(int index)
    {
        if (!(_buavang >= index)) return;
        _buavang -= index;
    }
    public void MinusBuaTim(int index)
    {
        if (!(_buatim >= index)) return;
        _buatim -= index;
    }
    public void MinusXanhLa(int index)
    {
        if (!(_buaxanhla >= index)) return;
        _buaxanhla -= index;
    }
    public void MinusBuaDo(int index)
    {
        if (!(_buado >= index)) return;
        _buado -= index;
    }
    public void MinusXanhDuong(int index)
    {
        if (!(_buaxanhduong >= index)) return;
        _buaxanhduong -= index;
    }
    public void MinusBuaxam(int index)
    {
        if (!(_buaxam >= index)) return;
        _buaxam -= index;
    }
    public void MinusDaRuby(int index)
    {
        if (!(_daruby >= index)) return;
        _daruby -= index;
    }
    public void MinusDaTiTan(int index)
    {
        if (!(_datitan >= index)) return;
        _datitan -= index;
    }
    public void MinusThachAnh(int index)
    {
        if (!(_dathachanh >= index)) return;
        _dathachanh -= index;
    }
    public void MinusDaShaphia(int index)
    {
        if (!(_dashaphia >= index)) return;
        _dashaphia -= index;
    }
    public void MinusDaLucBao(int index)
    {
        if (!(_dalucbao >= index)) return;
        _dalucbao -= index;
    }
    public void MinusDaNguSac(int index)
    {
        if (!(_danngusac >= index)) return;
        _danngusac -= index;
    }

    public void PlusItem()
    {
        if (PlayerPrefs.GetInt("PlusItem") <1)
        {
            PlusGold(5000000);
            PlusDiamond(50000);
            PlusBuaCam(2000);
            PlusBuaDo(2000);
            PlusBuaTim(2000);
            PlusBuaVang(2000);
            PlusBuaXam(2000);
            PlusBuaXanhDuong(2000);
            PlusBuaXanhLa(2000);
            PlusDaLucBao(3000);
            PlusDaNguSac(3000);
            PlusDaRuby(3000);
            PlusDaShaphia(3000);
            PlusDaThachAnh(3000);
            PlusDaTiTan(2000);
            PlayerPrefs.SetInt("PlusItem", 1);
        }
    }
}
