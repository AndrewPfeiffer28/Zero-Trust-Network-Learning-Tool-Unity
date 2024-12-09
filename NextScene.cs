

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    public Button Next;
    private VideoPlayer videoPlayer;
    public int sceneName;

    void Start()
    {
        if (Next != null)
        {
            Next.onClick.AddListener(() => LoadScene(sceneName));
        }
        
        
    }
    
    
    void LoadScene(int sceneName)
    {
        if (videoPlayer != null && videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }

        else
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log($"Current Scene: {sceneName}");
        }
        
    }
}
