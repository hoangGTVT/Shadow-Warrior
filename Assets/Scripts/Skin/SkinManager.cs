using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    [Header("script")]
   
    public int[] skin;
    

   public int GetSkin(int index)
   {
        return skin[index];
   }

   public void PlusSkin(int index)
    {
        skin[index]++;
    }

    public void MinusSkin(int index)
    {
        skin[index]--;
    }

    
   
}
