using DG.Tweening;
using System.Collections;


using UnityEngine;

using UnityEngine.UI;



    public class GameManager : MonoBehaviour
{
    [SerializeField]
    public Transform üstpanel;
    [SerializeField]
    public GameObject puanıkap,büyükolanıseç;
    [SerializeField]
    public GameObject sayıpanel1, sayıpanel2;
    [SerializeField]
    private Text üsttext,altext;
    TimerManager timermanager;
    int oyunSayaç;
    int üstdeğer, altdeğer;
    int büyükdeğer;
    DaireManager dairemanager;
    int butondeğeri;
    int seviye;
    [SerializeField]
    public GameObject trueikonu, falseikonu;
    [SerializeField]
    private GameObject pausepaneli,sonuçpaneli;
    [SerializeField]
    public Text skortext,puantext;
    int toplampuan, artışpuanı;
    
    int artış;
    bool süre;
    int yazdırılacakpuan;
    private AudioSource sesler;

    [SerializeField]
    private AudioClip başlangıçsesi, dorusesi, yanlışsesi, bitişsesi;
    private void Awake()
    {
        timermanager = Object.FindObjectOfType<TimerManager>();
        dairemanager = Object.FindObjectOfType<DaireManager>();
        sesler = GetComponent<AudioSource>();
    }
    void Start()
    {
        
        oyunSayaç = 0;
        seviye = 0;
        toplampuan = 0;
        skortext.text = "0";
        süre = true;
        panleiaç();
    }

       

    void panleiaç()
    {
        üstpanel.transform.GetComponent<CanvasGroup>().DOFade(1, 1.5f);
        puanıkap.GetComponent<CanvasGroup>().DOFade(1, 1f);
        sayıpanel1.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1.2f).SetEase(Ease.OutBack);
        sayıpanel2.transform.GetComponent<RectTransform>().DOLocalMoveX(0, 1.2f).SetEase(Ease.OutBack);

    }

    public void oyunabaşla()
    {
        sesler.PlayOneShot(başlangıçsesi);
        puanıkap.GetComponent<CanvasGroup>().DOFade(0, 1f);
        büyükolanıseç.GetComponent<CanvasGroup>().DOFade(1, 1f);
        timermanager.süreyibaşlat();
        kaçıncOyun();

    }
    void kaçıncOyun()
    {
        if (seviye < 5)
        {
            birincifonksiyon();
            artışpuanı = 10;
        }else if(seviye>=5 && seviye < 10)
        {
            ikincifonksiyon();
            artışpuanı =15;
        }
        else if (seviye >= 10 && seviye < 15)
        {
            üçüncüfonksiyon();
            artışpuanı = 20;
        }
        else if (seviye >= 15 && seviye < 20)
        {
            dödüncüfonksiyon();
            artışpuanı = 25;
        }
        else
        {
            dödüncüfonksiyon();
            artışpuanı = 25;
        }
        

    }
    void birincifonksiyon()
    {
        üstdeğer = Random.Range(2, 50);
        altdeğer = Random.Range(2, 50);
        if (üstdeğer == altdeğer)
        {
            üstdeğer = altdeğer + Random.Range(1, 5);
            büyükdeğer = üstdeğer;
            üsttext.text = üstdeğer.ToString();
            altext.text = altdeğer.ToString();
          
        }
        else
        {
            üsttext.text = üstdeğer.ToString();
            altext.text = altdeğer.ToString();
           
            if (altdeğer > üstdeğer)
            {
                büyükdeğer = altdeğer;
            }
            else
            {
                büyükdeğer = üstdeğer;
            }
        }
    }

    void ikincifonksiyon()
    {
        int birincsayı = Random.Range(1, 10);
        int ikincisayı = Random.Range(1, 20);
        int üçüncü = Random.Range(1, 10);
        int dördüncü = Random.Range(1, 20);

        üstdeğer = birincsayı + ikincisayı;
        altdeğer = üçüncü + dördüncü;
        if (üstdeğer > altdeğer)
        {
            büyükdeğer = üstdeğer;
        }
        else if (üstdeğer < altdeğer)
        {
            büyükdeğer = altdeğer;
        }
        else
        {
            birincsayı = birincsayı + Random.Range(1, 5);
            büyükdeğer = üstdeğer;
        }


        üsttext.text = birincsayı + "+" + ikincisayı;
        altext.text = üçüncü + "+" + dördüncü;

    }

    void üçüncüfonksiyon()
    {
        int birincsayı = Random.Range(11, 30);
        int ikincisayı = Random.Range(1, 11);
        int üçüncü = Random.Range(11, 30);
        int dördüncü = Random.Range(1, 11);

        üstdeğer = birincsayı - ikincisayı;
        altdeğer = üçüncü - dördüncü;
        if (üstdeğer > altdeğer)
        {
            büyükdeğer = üstdeğer;
        }
        else if (üstdeğer < altdeğer)
        {
            büyükdeğer = altdeğer;
        }
        else
        {
            birincsayı = birincsayı + Random.Range(1, 5);
            büyükdeğer = üstdeğer;
        }


        üsttext.text = birincsayı + "-" + ikincisayı;
        altext.text = üçüncü + "-" + dördüncü;

    }

    void dödüncüfonksiyon()
    {
        int birincsayı = Random.Range(1, 10);
        int ikincisayı = Random.Range(10, 20);
        int üçüncü = Random.Range(1, 10);
        int dördüncü = Random.Range(11, 30);
        int rastgele = Random.Range(1, 10);

        if (rastgele < 5)
        {
            üstdeğer = birincsayı + ikincisayı;
            altdeğer = dördüncü - üçüncü;
            üsttext.text = birincsayı + "+" + ikincisayı;
            altext.text = dördüncü + "-" + üçüncü;
            if (üstdeğer > altdeğer)
            {
                büyükdeğer = üstdeğer;

            }else if(altdeğer> üstdeğer)
            {
                büyükdeğer = altdeğer;
            }
        }else if (rastgele >= 5)
        {
            üstdeğer = dördüncü - üçüncü;
            altdeğer = birincsayı + ikincisayı;
            üsttext.text = dördüncü + "-" + üçüncü;
            altext.text = birincsayı + "+" + ikincisayı;
            if (üstdeğer > altdeğer)
            {
                büyükdeğer = üstdeğer;

            }
            else if (altdeğer > üstdeğer)
            {
                büyükdeğer = altdeğer;
            }

        }



    }





    public void doğrumu(string butonadı)
    {
        if (butonadı == "üstbuton")
        {
            butondeğeri = üstdeğer;
        }else if (butonadı == "altbuton")
        {
            butondeğeri = altdeğer;
        }



        if (büyükdeğer==butondeğeri)
        {
            
            if (oyunSayaç == 5)
            {
                dairemanager.dairelerikapat();
                oyunSayaç = 0;
            }
            
            dairemanager.dairegöster(oyunSayaç);
            oyunSayaç++;
            toplampuan += artışpuanı;
            skortext.text = toplampuan.ToString();
            seviye++;
            kaçıncOyun();
            trueaç();
            Invoke("truekapat",0.4f);
            sesler.PlayOneShot(dorusesi);

        }
        else
        {
            
            sayacıazalt();
            kaçıncOyun();
            dairemanager.dairelerikapat();
            oyunSayaç = 0;
            falseaç();
            Invoke("falsekapat", 0.4f);
            sesler.PlayOneShot(yanlışsesi);
            if (seviye < 5)
            {
                seviye = 0;
            }
            else if (seviye >= 5 && seviye < 10)
            {
                seviye = 5;
            }
            else if (seviye >= 10 && seviye < 15)
            {
                seviye = 10;
            }
            else if (seviye >= 15 && seviye < 20)
            {
                seviye = 20;
            }


        }
    }

    void sayacıazalt()
    {
        seviye--;
        kaçıncOyun();
    }
    void trueaç()
    {
        trueikonu.GetComponent<RectTransform>().DOScale(1, 0.2f);
    }
    void truekapat()
    {
        trueikonu.GetComponent<RectTransform>().localScale = Vector3.zero;
    }

    void falseaç()
    {
        falseikonu.GetComponent<RectTransform>().DOScale(1, 0.2f);
    }

    void falsekapat()
    {
        falseikonu.GetComponent<RectTransform>().localScale = Vector3.zero;
    }

    public void pausepanleiaç()
    {
        pausepaneli.SetActive(true);
    }


    public void oyunubitir()
    {
        artış = toplampuan / 5;
        sonuçpaneli.SetActive(true);
        sesler.PlayOneShot(bitişsesi);
        StartCoroutine(puanıyazdır());
        
    }


    IEnumerator puanıyazdır() {
        while (süre)
        { 
            yield return new WaitForSeconds(0.1f);
            yazdırılacakpuan += artış;
            if (yazdırılacakpuan >= toplampuan)
            {
                yazdırılacakpuan = toplampuan;
                süre = false;
            }
            puantext.text = yazdırılacakpuan.ToString();

        }
    }
   


}

