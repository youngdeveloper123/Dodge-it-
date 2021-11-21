using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerscript movement;

    void OnCollisionEnter (Collision collisionInfo)
    {     
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }

    }

}
