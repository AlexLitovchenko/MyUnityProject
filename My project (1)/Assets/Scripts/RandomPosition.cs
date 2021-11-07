using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> gameObjects;
    [SerializeField]
    private GameObject zone;
    
    private readonly int _Number=10;
    private float _RandX;
    private float _RandY;
    Vector2 whereSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(zone, zone.transform.position, Quaternion.identity);
        
        for (int i = 0; i < _Number; i++)
        {
            _RandX = Random.Range(-9.5f, -8f);
            _RandY = Random.Range(5.6f,6f);
            whereSpawn = new Vector2(_RandX,_RandY);
            Instantiate(gameObjects[i], whereSpawn, Quaternion.identity);
        }    
    }   
}
