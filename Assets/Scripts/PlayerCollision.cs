using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public calculatinig playerHp;
    public AudioSource audiosource;
    public GameObject SmokePrefab;


    public void PlaySound()
    {
        audiosource.Play();
    }
    private void OnTriggerEnter(Collider other)
    {   
        //gameobject이름
        //  if (other.gameObject.name == "enemy(Clone)")
        //component이름
        //if(other.GetComponent<enemymove>())
        //tagging을 enemyprefab에서 한 후

        if(other.tag == "enemy" || other.tag == "enemy2" || other.tag == "enemy3")
        {
            PlaySound();
            var effect = Instantiate(SmokePrefab);
            effect.transform.position = transform.position;
            playerHp.DamageHp(1);       
            Destroy(other.gameObject);//other는 컴포넌트
        }
        

    }
}
