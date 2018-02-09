using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour {
    public GameObject SpherePrefab;
    public GameObject CapsulePrefab;
    public GameObject CrossPrefab;
    public GameObject player;
    private float lastspawntime ;
    private float radius = 6;
    private float spawninterval = 1.0f;
    
    private float starttime;
    

    private void Start()
    {
        starttime = Time.time;
    }

    private void Update()
    {
        //var v1 = Mathf.Sin(Mathf.PI / 4);
        //var v2 = Mathf.Cos(Mathf.PI / 4);

        if (Time.time - lastspawntime > spawninterval)
        {
            var enemy = Instantiate(SpherePrefab);
            var theta = Random.Range(0, 2 * Mathf.PI);
            var boundary = radius * new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta));
            enemy.transform.position = player.transform.position + boundary;

            
            if (Time.time - starttime > 10.0f)
            { 
                var enemy2 = Instantiate(CapsulePrefab);
              
                // enemy2.transform.RotateAround()

                enemy2.transform.position = player.transform.position + boundary;
            }

            if(Time.time - starttime > 25.0f)
            {
                var enemy3 = Instantiate(CrossPrefab);
                enemy3.transform.position = player.transform.position + boundary;
            }
            lastspawntime = Time.time;


        }
    }

}


