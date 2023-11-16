using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            playerController.UpdateCheckpoint(new Vector2(this.transform.position.x, this.transform.position.y));
        }
    }
}
