using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizarraButton : MonoBehaviour
{

    public Text _menu;
    public GameObject _menuframe;

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

    public void StartPizarra()
    {
        //_menu.SetActive(true);
        _menu.text = "Menú Principal";
    }
}
