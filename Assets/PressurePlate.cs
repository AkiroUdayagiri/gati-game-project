using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject DestroyTree1; // Assign the tree GameObject in the Inspector

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is the Player
        if (collision.gameObject.name == "Parent")
        {
            Destroy(DestroyTree1); // Destroy the tree GameObject
            Debug.Log("Tree destroyed!");
        }
    }
}
