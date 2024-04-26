using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkillBuu : BossSkill
{
    public GameObject pointSkillSpecial1;
    public GameObject bulletBossBuu;
    public BossAnimator animator;
    public bool isHenshin;
    public float scaleDuration = 200f;
    public Vector3 targetScale = new Vector3(1.5f, 1.5f, 1.5f);
    public GameObject buu;
    private Vector3 initialScale;
    private float timer;
    void Start()
    {

    }
    private void OnEnable()
    {
        isHenshin = false;
        buu.transform.localScale = new Vector3(1, 1, 1);
    }
    private void Awake()
    {
        isHenshin = false;
        initialScale = transform.localScale;
    }
    // Update is called once per frame
    void Update()
    {
        if (bossLife.hpBossCurrent <= bossLife.hpBoss / 2&& isHenshin==false)
        {
            bossController.canSkill4 = true;
            
            animator.SetAnimationBoss("Block");
            StartCoroutine(ScaleOverTime());
        }
    }

    public override void SkillSpecial()
    {
        GameObject bullet = Instantiate(bulletBossBuu, pointSkillSpecial1.transform.position, Quaternion.identity);
        SkillBossBuu skillBossBuu=bullet.GetComponent<SkillBossBuu>();
        skillBossBuu.boss = buu;
    }
    public override void Skill4()
    {
        bossManager.SetHPBoss(bossLife.hpBoss / 2);
        bossManager.BossHealHP(bossLife.hpBoss);
        bossLife.PlusAtkCurrent(bossLife.GetatkBossCurrent());
        bossLife.setUIHP();
        bossController.canSkill4 = false;
        isHenshin = true;
    }
    IEnumerator ScaleOverTime()
    {
        while (timer < scaleDuration)
        {
            timer += Time.deltaTime;
            float progress = timer / scaleDuration;
            buu.transform.localScale = Vector3.Lerp(initialScale, targetScale, progress);
            yield return null;
        }
        buu.transform.localScale = targetScale; 
    }
}
