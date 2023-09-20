using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] Vector3 dirMove = new Vector3();
    [SerializeField] float speedMove;
    Rigidbody2D rigidbody = new Rigidbody2D();
    void Start()
    {
        dirMove = Vector3.zero;
        rigidbody = GetComponent<Rigidbody2D>();
        speedMove = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        dirMove = CharacterInput.instance.dir;
        rigidbody.MovePosition((dirMove*Time.deltaTime*speedMove) + transform.position);
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePoint.z = 0;
            transform.DOMove(mousePoint, speedMove*Time.deltaTime);
        }
    }
    
}
