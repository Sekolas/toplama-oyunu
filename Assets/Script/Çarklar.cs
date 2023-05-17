using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Çarklar : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    
}
