using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour {

	public void OpenMainScene()
    {
        SceneManager.LoadScene("Splash");
    }
}
