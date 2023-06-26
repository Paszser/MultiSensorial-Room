using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldosasController : MonoBehaviour
{
    public int _num;
    public List<GameObject> _baldosas;
    int _prevnum;
    public static bool _game;   //determina si la partida está activa o no
    public static List<int> _colorBaldosas = new List<int>(4); //contiene el valor de las baldosas que identifica cada color
    public bool resultado = true;   // recoge si la solución va siendo o es válida cuando se compruebe
    public GameObject _good;    //resultado correcto
    public GameObject _bad;     //resultado nulo   
    // Start is called before the first frame update
    void Start()
    {
        if (_game)
        {

        }
        else
        {
            _num = Random.Range(0, 3);
            _baldosas[_num].SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_game)
        {
            if(_colorBaldosas.Count == 4) //cuando hemos pisado 4 baldosas
            {
                foreach (GameObject obj in _baldosas)
                {
                    obj.SetActive(false);
                }
                resultado = true;

                for (int i = 0; (i < 4); ++i){
                    if(_colorBaldosas[i] != SimonSay._order[i]) //Comprobamos si el resultado está bien
                    {                        
                        resultado = false;
                    }
                }

                if (resultado)
                {
                    _good.SetActive(true);
                    _bad.SetActive(false);
                }
                else
                {
                    _bad.SetActive(true);
                    _good.SetActive(false);


                }
                Clearass();
            }
        }
    }

    public void Clearass()
    {
        SimonSay._order.Clear();
        _colorBaldosas.Clear();
        _game = false;
        _num = Random.Range(0, 3);
        _baldosas[_num].SetActive(true);
    }

    public void ClearPreviousGame()
    {
        for (int i = 0; (i < 4); ++i)
        {
            _baldosas[i].SetActive(false);
        }
    }
    public void ActivateAllTiles()
    {
        foreach (GameObject obj in _baldosas)
        {
            obj.SetActive(true);
        }

    }
    public void SelectOtherBaldosa()
    {
        ClearPreviousGame(); 
        _prevnum = _num;
        _num = Random.Range(0, 3);
        if(_prevnum == _num)
        {
            _num = (++_num) % _baldosas.Count;

        }
        _baldosas[_num].SetActive(true);
    }
}
