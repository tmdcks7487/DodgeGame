using System.Linq;
using UnityEngine;

public class disappearenemy : MonoBehaviour {
    private float starttime;
    public float timeover = 5.0f;
  
    private void Start()
    {
        starttime = Time.time;
    }

    private void Update()
    {
        if(Time.time-starttime>timeover)
        {
            Destroy(gameObject);
        }
    }

}
