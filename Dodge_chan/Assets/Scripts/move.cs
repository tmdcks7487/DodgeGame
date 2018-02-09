﻿using UnityEngine;

public class move : MonoBehaviour {

    public float speed = 1;
    public DirPad dirPad;

    // Use this for initialization
    void Start () {
        Debug.Log("Start() called"); //debugging 관련한 class
    }

    // Update is called once per frame
    void Update ()
    {
        if (dirPad.dragging)
        {//mouse
            var dn = dirPad.dir.normalized * Time.deltaTime * speed;
            transform.Translate(new Vector3(dn.x, 0, dn.y));
        }
        else
        {//keyboard
            //Debug.LogFormat("Time.deltaTime = {0}", Time.deltaTime);//60장인지 아닌지(0.016) 확인
            var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed; //1초에 0.016움직인다.
            var dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            //Debug.LogFormat("{0}", dx);

            transform.Translate(new Vector3(dx, 0, dz));

        }
        Vector3 movePosition = transform.position;
        if (movePosition.x < -49.0f) { movePosition.x = -49.0f; }
        if (movePosition.x > 49.0f) { movePosition.x = 49.0f; }

        // if (movePosition.z < -49.0f) { movePosition.z = -49.0f; }
        // if (movePosition.z > 49.0f) { movePosition.z = 49.0f; }
        movePosition.z = Mathf.Clamp(movePosition.z, -49, 49);
        transform.position = movePosition;

    }
}
