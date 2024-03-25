using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KameScript : MonoBehaviour
{
    protected virtual GameObject FindObject(string name)
    {
        return GameObject.Find(name);
        
    }

}
