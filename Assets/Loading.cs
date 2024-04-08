using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public float loading;
    public TextMeshProUGUI textMeshPro;
    public GameObject loadingoff;
    public GameObject player;
    void Start()
    {
        loading = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        loading += 70*Time.deltaTime;
        int loading2 = (int)(loading);
        textMeshPro.text=loading2.ToString()+"%";
        if (loading2 >= 100)
        {
            loading = 0;
            player.SetActive(true);
            loadingoff.SetActive(false);
            
        }
    }
}
