using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public float xSpace;
    public float xOffset;
    void Start()
    {
        for (int l = 0; l < 10; l++)
        {
            Instantiate(enemyPrefab, new Vector2(l * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(enemyPrefab, new Vector2(l * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(enemyPrefab, new Vector2(l * xSpace + xOffset, 4.50f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
