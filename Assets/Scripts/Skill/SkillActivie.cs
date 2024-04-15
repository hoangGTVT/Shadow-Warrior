using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillActivie : MonoBehaviour
{
    public GameObject player;
    public PlayerLife playerLife;
    public SkillController skillController;
    public PlayerSelect playerSelect;
    public EnemyManager enemyManager;
    public PlayerManager playerManager;
    public int atk;
    public int index;
    public GameObject impack;
    void Start()
    {
        FindPlayer();

    }

    protected virtual void FindPlayer()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            playerLife = player.GetComponentInChildren<PlayerLife>();
            skillController = player.GetComponentInChildren<SkillController>();
            playerSelect = player.GetComponent<PlayerSelect>();
            playerManager=player.GetComponent<PlayerManager>();
            int damecurrent = skillController.GetCurrentDMG(index) ;
            int damePercent= 100 + skillController.GetPercentDMG(index);
            atk = (int)(((playerLife.GetATKTotal()+damecurrent)*damePercent)/100);
        }
    }

   
    // Update is called once per frame
    public void CreateImpack(GameObject game1)
    {
        GameObject impac = Instantiate(impack, game1.transform.position, Quaternion.identity);
        Destroy(impac,0.3f );
    }

}
