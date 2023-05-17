
using UnityEngine;
using DG.Tweening;


public class DaireManager : MonoBehaviour
{
    [SerializeField]
    public GameObject[] daireler;
   
    void Start()
    {
        dairelerikapat();
    }
    public void dairegöster(int hangidaire)
    {
        daireler[hangidaire].GetComponent<RectTransform>().DOScale(1,0.3f);

    }
    public void dairekapat(int kapatilacakdaire)
    {
        daireler[kapatilacakdaire].GetComponent<RectTransform>().DOScale(0,0.3f);
    }


    
    
    public void dairelerikapat()
    {
        foreach(GameObject p in daireler)
        {
            p.transform.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }
}
