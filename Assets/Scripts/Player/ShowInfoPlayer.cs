using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfoPlayer : MonoBehaviour
{
    [Header("Text")]
    public Image sprite;
    public TextMeshProUGUI[] tex1;
    public TextMeshProUGUI[] tex2;
    public PlayerManager playerManager;
    public PlayerLife playerLife;
    
    void Start()
    {
        UIBarPlayer.Instance.SetMaxHP(playerLife.GetHPTotal());
        
        UIBarPlayer.Instance.SetMaxKI(playerLife.GetKITotal());
        
        
    }

    // Update is called once per frame
    void Update()
    {
     
        UIBarPlayer.Instance.SetHP(playerLife.GetHPCurrent());
        UIBarPlayer.Instance.SetKI(playerLife.GetKICurrent());
        ShowInfoPlayer1();
        ShowInfoPlayer2();
    }

    public void ChangeIcon(Sprite sp) { sprite.sprite = sp; }

    public void ShowInfoPlayer1()
    {
        tex1[0].text = playerLife.GetName();
        tex1[1].text = playerLife.GetSM().ToString("#,#");
        tex1[2].text = playerLife.GetHPCurrent().ToString("#,#");
        tex1[3].text = playerLife.GetKICurrent().ToString("#,#");
    }

    public void ShowInfoPlayer2()
    {
        tex2[0].text=playerLife.GetName();
        tex2[1].text = playerLife.GetSM().ToString("#,#");
        tex2[2].text = playerLife.GetLevel().ToString();
        tex2[3].text = playerLife.GetStaminaCurrent().ToString("#,#");
        tex2[4].text = playerLife.GetHPCurrent().ToString("#,#");
        tex2[5].text = "/"+playerLife.GetHPTotal().ToString("#,#");
        tex2[6].text = playerLife.GetKICurrent().ToString("#,#");
        tex2[7].text = "/"+playerLife.GetKITotal().ToString("#,#");
        tex2[8].text = playerLife.GetExpCurrent().ToString("#,#");
        tex2[9].text = "/" + playerLife.GetExpLevel().ToString("#,#");
        tex2[10].text = playerLife.GetATKTotal().ToString();
        tex2[11].text = playerLife.GetDEFTotal().ToString();
        tex2[12].text = playerLife.GetCritTotal().ToString()+"%";
        tex2[13].text = playerLife.GetCritDMGTotal().ToString()+"%";
        
    }
}
