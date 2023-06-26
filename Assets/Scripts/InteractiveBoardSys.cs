using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBoardSys : MonoBehaviour
{
    public GameObject _item1;
    public GameObject _item2;
    public GameObject _item3;
    public GameObject _item4;
    // Start is called before the first frame update
    void Start()
    {
        _item1.SetActive(false);
        _item2.SetActive(false);
        _item3.SetActive(false);
        _item4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
