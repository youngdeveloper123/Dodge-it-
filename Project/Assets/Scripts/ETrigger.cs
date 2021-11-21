using UnityEngine;

public class ETrigger : MonoBehaviour
{
    public GameManager gameManager;
   void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
