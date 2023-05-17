using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class GeriSayımManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gerisayım;
    [SerializeField]
    private Text gerisayımtext;
    GameManager gamemanager;

    private void Awake()
    {
        gamemanager = Object.FindObjectOfType<GameManager>();
       

    }
    void Start()
    {
        StartCoroutine(GerisayRoutine());
      
    }

    IEnumerator GerisayRoutine()
    {
        gerisayımtext.text = "3";
        yield return new WaitForSeconds(0.3f);

        gerisayım.GetComponent<RectTransform>().DOScale(1, 0.3f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.4f);
        gerisayım.GetComponent<RectTransform>().DOScale(0, 0.3f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        gerisayımtext.text = "2";
        yield return new WaitForSeconds(0.3f);

        gerisayım.GetComponent<RectTransform>().DOScale(1, 0.3f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.4f);
        gerisayım.GetComponent<RectTransform>().DOScale(0, 0.3f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        gerisayımtext.text = "1";
        yield return new WaitForSeconds(0.3f);

        gerisayım.GetComponent<RectTransform>().DOScale(1, 0.3f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.4f);
        gerisayım.GetComponent<RectTransform>().DOScale(0, 0.3f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        StopAllCoroutines();

        gamemanager.oyunabaşla();
        
        
        

        


    }

}
