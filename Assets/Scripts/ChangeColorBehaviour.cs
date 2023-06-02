using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBehaviour : MonoBehaviour
{
    public GameObject _targetColorObject;
    public List<Color> _colorSelection;
    public int _currentColor;
    public GameObject _instantiateObject;
    public GameObject _instantiatorTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeColor()
    {
        _currentColor++;
        _targetColorObject.GetComponent<Renderer>().material.SetColor("_Color", _colorSelection[_currentColor%_colorSelection.Count]);
    }

    public void Instantiator()
    {
        Instantiate(_instantiateObject, _instantiatorTarget.transform.position, Quaternion.identity);
    }
}
