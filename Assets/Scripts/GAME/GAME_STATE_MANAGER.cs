using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using static GAME_STATE_MANAGER;

public class GAME_STATE_MANAGER : MonoBehaviour
{
    public static GAME_STATE_MANAGER _instance;

    public static GAME_STATE_MANAGER Instance{
        get{
            if (_instance == null) Debug.LogError("GAME_STATE_MANAGER instance is null");
            return _instance;
        }
    }
    

    [Header("Scripts")]
    [SerializeField] Random random;

    private void Awake()
    {
        Debug.Log("Awake method called in " + gameObject.name);
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
