using UnityEngine;

public class enemymove : MonoBehaviour {
    public GameObject player;
    private float starttime;
    public float speed = 1.0f;
    

    private void Start()
    {
        player = GameObject.Find("Player");
        starttime=Time.time;
    }
    // Update is called once per frame
    void Update() {
        //player.transform.position를 활용해서 dir 계산


        //Vector3 dir = (player.transform.position - transform.position) * speed * Time.deltaTime;//종착점 - 현재 위치
        //transform.Translate(dir);
        var diff = player.transform.position - transform.position;
        var dir = diff.normalized;//단위벡터와 시키는 것
        transform.Translate(dir * speed * Time.deltaTime, Space.World);

        var realtime = Time.time - starttime;
        if (realtime > 10.0f)
        {
            speed = 4;
        }
        if (realtime > 20.0f)
        {
            speed = 8;
        }

    }
}
