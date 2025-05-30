using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject cam;
    public GameObject levelControll;
    

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMov>().enabled = false;
        Debug.Log(gameObject.name);
        charModel.GetComponent<Animator>().Play("Soccer Trip");
        levelControll.GetComponent<LevelDIstance>().enabled = false;
        crashThud.Play();
        cam.GetComponent<Animator>().enabled = true;
        levelControll.GetComponent<EndRunSequence>().enabled = true;
        
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
