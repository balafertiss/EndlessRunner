using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour
{

    public GameObject[] sections;
    public float zPos;
    public bool creatingSections = false;
    public int secNum;
    public float x;
    public float y;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (creatingSections == false)
        {
            creatingSections = true;
            StartCoroutine(GenerateSection());
        }
        
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(sections[secNum], new Vector3(x, y, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);
        creatingSections = false;

    }
}
