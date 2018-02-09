using System;
using UnityEngine;
using UnityEngine.UI;

public class calculatinig : MonoBehaviour {
    private float starttime;
    private float scoretime;
    private float savetime;
    private int hp = 10;
    public Text hptext;
    public Text timetext;
    public move playermove;
    public movecamera cameramove;
    public GameObject HomeButton;
    public float endtime;
  
    public void HealHp(int amount)
    {
        hp += amount;
        if (hp > 10 || hp == 10) hp = 10;
        UpdateHp();
    }
    public void DamageHp(int amount)
    {   

        hp -= amount;
        if (hp < 0 || hp == 0)
        {
           
            playermove.speed = 0;
            cameramove.speed = 0;
            hp = 0;
            HomeButton.SetActive(true);
            
            hptext.text = hp.ToString();

            scoretime = Time.time;
            //HighScore();
        }
        else
        UpdateHp();

    }

    //private void HighScore()
    //{
    //    savetime = 
    //}

    private void UpdateHp()
    {
        hptext.text = hp.ToString();
    }
   
    private void Start()
    {
        hptext.text = hp.ToString();//숫자를 문자열로 변환 후 넣기
        starttime = Time.time;
        scoretime = Time.time;
        savetime = Time.time;
    }

    private void Update()
    {
        var realtime = Time.time - starttime;
        var realtime2 = Time.time - scoretime;
        endtime = Time.time - savetime;

        if (hp>0)
        {
            
            timetext.text = realtime2.ToString("F2");
            
        }
        
       
            //  scoretime = Time.time;
        if (realtime > 10.0f)
        {
            if(hp>0) hp += 1;
            hptext.text = hp.ToString();
            starttime = Time.time;
  
            //timetext.text = realtime.ToString();
        }
       
        
        //starttime = Time.time;
    }
    

}
