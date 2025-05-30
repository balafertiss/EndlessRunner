using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource coinFX;

        void OnTriggerEnter(Collider other)
    {
        
        coinFX.Play();
        CollectableControll.coinCount += 1;
        this.gameObject.SetActive(false);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
