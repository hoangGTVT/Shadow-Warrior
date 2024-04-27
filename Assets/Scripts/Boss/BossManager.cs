using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    [Header("Script")]
    public BossLife bossLife;
    public BossAnimator bossAnimator;
    [Header("Player")]
    public GameObject player;
    public PlayerSelect playerSelect;
    public PlayerManager playerManager;
    [Header("Text")]
    public GameObject[] textpopup;
    public GameObject textPoint;
    public int timeMinus;
    public GameObject blast;
    public float timeSkill = 0;
    public bool isTakeDamage;
    [Header("DropItem")]
    public GameObject gold;
    public GameObject Diamond;
    public GameObject[] clother;
    public GameObject[] skin;
    public int clotherRate;
    public int skinRate;
    public GameObject[] pointItem;
    public GameObject info;
    
    private void OnEnable()
    {
        isTakeDamage=false;
        player = GameObject.Find("Player");
        if (player != null)
        {
            playerSelect = player.GetComponent<PlayerSelect>();
            playerManager = player.GetComponent<PlayerManager>();
        }
    }
    private void Awake()
    {
        isTakeDamage = false;
        info=GameObject.Find("InfoEnemy");
        
    }
    public void BlastActive()
    {
        blast.SetActive(true);
    }
    public void OnMouseDown()
    {
        if (playerSelect != null)
        {
            playerSelect.SetBoss(gameObject);
            playerSelect.isBoss = true;
        }
    }
    private void Start()
    {
        
    }
    void Update()
    {
  
        
    }
    //Getdata
    public string GetName() { return bossLife.GetNameBoss(); }
    public int GetHPBoss() { return bossLife.hpBoss; }
    public int GetHPBossCurrent() { return bossLife.GetHPBossCurrent(); }
    public bool IsCrit()
    {
        if (playerManager.GetCritRateAttack() <= playerManager.GetCritRatePlayer()) { return true; } else { return false; }
    }
    public int GetCritDMGPlayer() { return playerManager.GetCritDMGPlayer(); }
    public void BossTakeDamge(int dame)
    {
        isTakeDamage = true;
        if (IsCrit() == true)
        {
            int dame2 = dame * bossLife.GetdefBossCurrent() / 100;
            int dame3 = (dame - dame2) * (GetCritDMGPlayer() + 100) / 100;
            bossLife.MinusHpCurrent(dame3);
            CreateTextPopUp1(dame3);
        }
        else
        {
            int dame2 = dame * bossLife.GetdefBossCurrent() / 100;
            bossLife.MinusHpCurrent(dame - dame2);
            CreateTextPopUp(dame - dame2);
        }
        if (bossLife.hpBossCurrent <= 0)
        {
            BossDie();
        }
        
    }
    public void BossHealHP(int index)
    {
        bossLife.PlusHpCurrent(index);
        CreateTextPopUpHeal(index);
    }
    public void SetHPBoss(int hp)
    {
        bossLife.hpBoss +=hp;
    }
    public void CreateTextPopUpHeal(int number)
    {

        GameObject pos = Instantiate(textpopup[0], textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "- " + number;
        Destroy(pos, 0.7f);

    }
    public void CreateTextPopUp(int number)
    {

        GameObject pos = Instantiate(textpopup[0], textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "- " + number;
        Destroy(pos, 0.7f);

    }
    public void CreateTextPopUp1(int number)
    {

        GameObject pos = Instantiate(textpopup[1], textPoint.transform.position, Quaternion.identity);
        pos.GetComponentInChildren<TextMeshProUGUI>().text = "Chí Mạng " + "- " + number;
        Destroy(pos, 0.7f);

    }

    public void PlayerCauseDame()
    {
        if (player != null)
        {
            playerManager.PlayerTakeDamage(bossLife.GetatkBossCurrent());
        }
    }
    public void KillBoss()
    {
        if (bossLife.GetHPBossCurrent() <( bossLife.hpBoss / 10))
        {
            BossDie();
        }
    }

    public void MinusHP5S()
    {
        timeMinus = 5;
        StartCoroutine(MinusHP());
    }

    public IEnumerator MinusHP()
    {
        while (timeMinus > 0)
        {
            if (IsCrit() == true)
            {

                int dame2 = (bossLife.GetHPBoss() / 20) * bossLife.GetdefBossCurrent() / 100;
                int dame3 = (bossLife.GetHPBoss() / 20) - dame2;
                int dame4 = dame3*(GetCritDMGPlayer()+100)/100;
                bossLife.MinusHpCurrent(dame4);

                CreateTextPopUp1(dame4);
                timeMinus--;


                yield return new WaitForSeconds(1f);
            }
            else
            {
                int dame2 = (bossLife.GetHPBoss() / 20) * bossLife.GetdefBossCurrent() / 100;
                int dame3 = (bossLife.GetHPBoss() / 20) - dame2;
                bossLife.MinusHpCurrent(dame3);

                CreateTextPopUp(dame3);
                timeMinus--;


                yield return new WaitForSeconds(1f);
            }
            
        }

    }

    public void BossDie()
    {
        if (info != null)
        {
            info.SetActive(false);
        }
        
        gameObject.SetActive(false);
        Instantiate(gold, pointItem[0].transform.position, Quaternion.identity);
        Instantiate(Diamond, pointItem[1].transform.position, Quaternion.identity);
        int clother1 = Random.Range(0, 101);
        int indexclother = Random.Range(0, 5);
        int skin1 = Random.Range(0, 101);
        int indexSkin = Random.Range(0, 5);
        if (clother1 <= clotherRate)
        {
            Instantiate(clother[indexclother], pointItem[2].transform.position, Quaternion.identity);
        }
        if(skin1 <= skinRate)
        {
            Instantiate(skin[indexSkin], pointItem[3].transform.position, Quaternion.identity);
        }
        Invoke("CreateNewBoss", 15);
    }

    public void CreateNewBoss()
    {
        gameObject.SetActive(true);
    }
}
