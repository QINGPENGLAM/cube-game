using UnityEngine;

public class playercollsion : MonoBehaviour
{
    public playermovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        
        }
        
    }
}
