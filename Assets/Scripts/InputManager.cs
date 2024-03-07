using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public float _moveHorizontal;
    public float _moveVertical;
    string input = "";
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        
    }
    
    public float SetHorizontal()
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        return _moveHorizontal;
    }
    public float SetVertica()
    {
        _moveVertical = Input.GetAxis("Vertical");
        return _moveVertical;
    }
    public object CheckInput()
    {
        

        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(keyCode))
                {
                    if (keyCode >= KeyCode.Alpha0 && keyCode <= KeyCode.Alpha9)
                    {
                        
                        input = ((int)keyCode - (int)KeyCode.Alpha0).ToString();
                        return int.Parse(input);
                    }
                    else if (keyCode >= KeyCode.A && keyCode <= KeyCode.Z)
                    {
                        
                        input = keyCode.ToString();
                        return input;
                    }
                }
            }
        }
        return null; 
    }

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
}
