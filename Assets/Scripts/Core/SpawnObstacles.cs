using UnityEngine;
public class SpawnObstacles : MonoBehaviour
{
   [SerializeField] private GameObject obstacle;
   [SerializeField] private float maxX;
   [SerializeField] private float minX;
   [SerializeField] private float maxY;
   [SerializeField] private float minY;
   [SerializeField] private float timeBetweenSpawn;
   private float _spawnTime;

    void Update()
    {
        if(Time.time > _spawnTime)
        {
            Spawn ();
            _spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    
    void Spawn ()
    {
        float randomX = Random. Range (minX, maxX);
        float randomY = Random. Range (minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        
    }
}