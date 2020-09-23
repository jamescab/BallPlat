using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public PlayerMovement movement;

   public void OnCollisionEnter (Collision collisionInfo)  {
       if (collisionInfo.collider.tag == "Ramp") {
           movement.enabled = true;
       }
       else if (collisionInfo.collider.tag == "Obstacle" || 
            collisionInfo.collider.tag == "Obstacle Long" ||
            collisionInfo.collider.tag == "ObstacleHigh") {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       } 
       
   }
}
