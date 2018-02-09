using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject HpPanel;
    public Text addNumberButtonText;//누르면 증가하는 버튼의 Text
    public void OpenMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
   
   // HpPanel.SetActive(HpPanel.activeSelf == false);
    //또는hppanel.SetActive(!happanel.activeSelf);
    public void ToggleHpPanel()
    {
        //    if (HpPanel.activeSelf)
        //    {
        //        HpPanel.SetActive(false);
        //    }
        //    else
        //    {
        //        HpPanel.SetActive(true);
        //    }
        HpPanel.SetActive(HpPanel.activeSelf == false);
    }

    public void AddNumber()
    {
        var addNumber = PlayerPrefs.GetInt("ADD_NUMBER", 1);//값이 있을때 없을때
        addNumberButtonText.text=(addNumber + 1).ToString();
        PlayerPrefs.SetInt("ADD_NUMBER", addNumber + 1);//저장
        PlayerPrefs.Save();//Disk에 저장
    }

}
