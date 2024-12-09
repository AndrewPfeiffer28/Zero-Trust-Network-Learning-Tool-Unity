// 12/2/2024 Andrew Pfeiffer

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void LoadScene(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log($"Current Scene: {sceneName}");
    }
    
}