using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPackManager : MonoBehaviour
{
    public int[] backPack;

    public int GetBackPack(int index)
    {
        return backPack[index];
    }

    public void PlusBackPack(int index)
    {
        backPack[index]++;
    }

    public void MinusBackPack(int index)
    {
        backPack[index]--;
    }
}
