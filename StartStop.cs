using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Button button;
    public Sprite playSprite;
    public Sprite pauseSprite;
    
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        
    }

    public void ChangeStartStop()
    {
        if (videoPlayer.isPlaying == false)
        {
            videoPlayer.Play();
            button.image.sprite = pauseSprite;
            
        }
        else
        {
            {
                videoPlayer.Pause();
                button.image.sprite = playSprite;
            }
        }
    }
}