using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _initialHealth;
    private int _Health;

    private int Health
    {
      get { return _Health; }
       
    } 

    // Start is called before the first frame update
    void Start()
    {
        _Health = _initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
