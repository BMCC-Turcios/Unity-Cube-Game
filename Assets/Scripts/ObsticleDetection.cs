using UnityEngine;

public class ObsticleDetection : MonoBehaviour
{
    public Transform player;
    
    // Update is called once per frame
    void Update()
    {
        if((int)player.position.z == (int)this.transform.position.z)
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
