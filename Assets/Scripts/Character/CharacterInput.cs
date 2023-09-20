using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public static CharacterInput instance;
    public Vector3 dir = new Vector3();
    public bool isMove = false;
    private void Awake()
    {
        if(instance!=null)
        {
            instance = this;
        }
        instance = this;
        isMove = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
        
    }
}
