using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SceneVideoSwitcher : MonoBehaviour
{
    public static VideoClip toPlay;
    [SerializeField] private string scene;
    [SerializeField] private VideoClip video;

    public void SwitchSceneAndVideo()
    {
        toPlay = video;
        SceneManager.LoadScene(scene);
    }
}
