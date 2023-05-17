
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseManager : MonoBehaviour
{
    [SerializeField]
    public GameObject pauspaneli;
    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void yenidenoyna()
    {
        pauspaneli.SetActive(false);
    }

    public void menüyedön()
    {
        SceneManager.LoadScene("Menu");
    }

    public void oyundançık()
    {
        Application.Quit();
    }

    

}
