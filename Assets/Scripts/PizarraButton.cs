using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizarraButton : MonoBehaviour
{

    public Text _menu;
    //public GameObject _menu;

    // Start is called before the first frame update
    void Start()
    {
        //_menu = GameObject.Find("MenuFrame");
        _menu.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPizarra(Text _menu)
    {
        //_menu.SetActive(true);
        _menu.text = "Menú Principal";
    }
}
