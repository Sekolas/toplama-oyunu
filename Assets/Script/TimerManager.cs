using System.Collections;

using UnityEngine;
using UnityEngine.UI;


public class TimerManager : MonoBehaviour
{

    [SerializeField]
    private Text süre;
    int kalansüre = 90;
    GameManager gamemanager;
    private void Awake()
    {
        gamemanager = Object.FindObjectOfType<GameManager>();
    }
    public void süreyibaşlat()
    {
        StartCoroutine(süretimerRoutine());
    }
    
    IEnumerator süretimerRoutine()
    {
        while (true)
        {
            süre.text = kalansüre.ToString();
            yield return new WaitForSeconds(1f);
            kalansüre--;
            if (kalansüre <= 0)
            {
                süre.text = "0";
                gamemanager.oyunubitir();
                break;
            }
        }
    }
}
