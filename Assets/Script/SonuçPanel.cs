
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonuçPanel : MonoBehaviour
{
   public void anameüyedön()
   {
        SceneManager.LoadScene("Menu");
   }


    public void tekraroyna()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
