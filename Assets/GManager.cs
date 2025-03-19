using UnityEngine;

public class GManager : MonoBehaviour
{
    public int objectCount = 0;  // To count how many objects have landed

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided is the one we are interested in
        if (other.CompareTag("DroppableObject")) 
        {
            objectCount++;
            Debug.Log("Objects on Circle: " + objectCount);
        }
    }
}
