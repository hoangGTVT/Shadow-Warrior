using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blast : MonoBehaviour
{
    public float duration = 2f;
    private Image panelImage; 
    private Color startColor = new Color(1f, 1f, 1f, 0f); 
    private Color endColor = new Color(1f, 1f, 1f, 1f); 

    void Start()
    {
        panelImage = GetComponent<Image>(); 
        panelImage.color = startColor; 
        
    }
    
    private void OnEnable()
    {
        panelImage = GetComponent<Image>();
        panelImage.color = startColor;
        StartCoroutine(FadeInPanel());
        Invoke("TurnOff", 1.1f);
    }

    public void TurnOff()
    {
        gameObject.SetActive(false);
    }
    IEnumerator FadeInPanel()
    {
        float elapsedTime = 0f; 
        while (elapsedTime < duration)
        {
            
            panelImage.color = Color.Lerp(startColor, endColor, elapsedTime / duration);
            elapsedTime += Time.deltaTime; 
            yield return null;
        }
        panelImage.color = endColor; 
    }
}
