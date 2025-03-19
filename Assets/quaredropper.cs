using UnityEditor.Build.Content;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToDrop;
    public GameObject Gamemanager;
    public float spawnHeight = 1f;
    public float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
        Gamemanager.GetComponent<GManager>().objectCount += 1;
    }

    void SpawnObject()
    {
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        float randomX = Random.Range(boxCollider.bounds.min.x, boxCollider.bounds.max.x);
        float randomY = Random.Range(boxCollider.bounds.min.y, boxCollider.bounds.max.y);
        Vector3 spawnPosition = new Vector3(randomX, randomY, transform.position.z);
        Instantiate(objectToDrop, spawnPosition, Quaternion.identity);
    }
}
