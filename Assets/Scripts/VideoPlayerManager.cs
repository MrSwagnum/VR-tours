using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;    //Must be using UnityEngine.Video
using UnityEngine;

public class VideoPlayerManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;     //Our video player component variable. Can be set in inspector or through code in Start()             
    public VideoClip[] clips;           //Array for video clips

   

    // Start is called before the first frame update
    void Start()
    {
       
        videoPlayer = GetComponent<VideoPlayer>();    //Stores our video player component into our videoPlayer variable
        
    }


    private void Update()
    {
        //Check to see if the current clip has ended. Once it's over, call to PlayClip()
        if ((videoPlayer.frame) > 0 && (videoPlayer.isPlaying == false))
        {
            PlayClip();
        }
    }

    public void PlayClip()
    {
        if (videoPlayer.clip == clips[0])            //Checks to see if the clip that just played was the first video
        {
            int randClip = Random.Range(1, 3);      //Randomly picks one of the remaining three videos
            videoPlayer.clip = clips[randClip];     //Sets the videoPlayer clip to the next chosen video
        }
        else if(videoPlayer.clip == clips[1] || videoPlayer.clip == clips[2] || videoPlayer.clip == clips[3]){
            videoPlayer.clip = clips[4];        // play the last clip
        }
        else
        {
            videoPlayer.clip = clips[0];            //If the last played video wasn't the first video, then go back to playing that first video
        }
        
    }

   
}



