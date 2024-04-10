using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinItem : MonoBehaviour
{
    [Header("Scripts")]
    public SkinManager skinManager;
    public PlayerSkinController skinController;
    public GameObject player;
    public float doubleClickTimeThreshold = 1f;
    protected float lastClickTime = 0f;
    public LayerMask playerLayer;
    public float detectionRadius = 5f;
    public bool playerDetected;
    public int indexSkin;
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
                skinManager.PlusSkin(indexSkin);
                Inform.instance.ShowInformClother(skinController.skinSO[indexSkin+11].GetName());

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
    public void FindPlayer()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            skinController = player.GetComponentInChildren<PlayerSkinController>();
            skinManager = player.GetComponentInChildren<SkinManager>();
        }
        else
        {
            skinManager = null;
            skinController = null;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
