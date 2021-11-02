using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Score score;
    
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if(collisionInfo.collider.tag == "Obstacle")
        {
            collisionInfo.gameObject.GetComponent<ObsticleDetection>().enabled = false;
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            score.GameScore++;
        }
    }
}
