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
        speedMove = 05f;
        DOTween.SetTweensCapacity(1250,50);
    }

    // Update is called once per frame
    void Update()
    {
        dirMove = CharacterInput.instance.dir;
        if(dirMove!= Vector3.zero)
        {
            transform.DOKill();
            transform.DOMove(dirMove + transform.position, speedMove).SetEase(Ease.Linear);
        }
            
        
    }
    
}
