using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Follow : MonoBehaviour
{

    public Transform Player;
    public float MoveSpeed = 2f;
    int MinDist = 5;


    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

        //    transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.position, MoveSpeed * Time.deltaTime);

        }
    }
}
