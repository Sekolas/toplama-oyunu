
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Transform kafa;
    [SerializeField]
    private Transform buton;
    // Start is called before the first frame update
    void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveX(0f, 1.5f).SetEase(Ease.OutBack);
        buton.transform.GetComponent<RectTransform>().DOLocalMoveY(-270f, 1.5f).SetEase(Ease.OutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sahneyiaç()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
