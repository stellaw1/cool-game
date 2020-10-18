using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    private int enemyCount;

    void Update()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 3)
        {
            Instantiate(theEnemy, new Vector3(xPos, 342, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.001f);
            enemyCount += 1;
        }
    }
}
