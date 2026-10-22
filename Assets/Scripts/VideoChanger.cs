using UnityEngine;
using UnityEngine.Video;

public class VideoChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VideoPlayer vidPlayer = GetComponent<VideoPlayer>();
        if (SceneVideoSwitcher.toPlay != null)
        {
            vidPlayer.clip = SceneVideoSwitcher.toPlay;
            vidPlayer.Play();
        }
    }
}
