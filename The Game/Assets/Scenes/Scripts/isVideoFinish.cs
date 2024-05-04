using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class isVideoFinish : MonoBehaviour
{
    [SerializeField]
    VideoPlayer myVideoPlayer;
    public int sceneID = 2;
    void Start()
    {
        myVideoPlayer.loopPointReached += TeleportWhenVideoFinished;
    }

    void TeleportWhenVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneID);
    }
}
