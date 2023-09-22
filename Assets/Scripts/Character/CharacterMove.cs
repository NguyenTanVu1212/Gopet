using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] Vector3 dirMove = new Vector3();
    [SerializeField] float speedMove;
    Rigidbody2D rigidbody = new Rigidbody2D();
    [SerializeReference]
    bool isMoveToTagert = false;
    Vector3 tagertPoint = new Vector3();
    [SerializeField] LayerMask layer;
    RaycastHit2D hit2D;
    void Start()
    {
        dirMove = Vector3.zero;
        rigidbody = GetComponent<Rigidbody2D>();
        speedMove = 10f;
        isMoveToTagert = false;
        tagertPoint = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        dirMove = CharacterInput.instance.dir;
        if (dirMove!= Vector3.zero)
        {
            isMoveToTagert = false;
            rigidbody.MovePosition(transform.position + dirMove * speedMove*Time.fixedDeltaTime);
        }
        if(Input.GetMouseButtonDown(0))
        {
            isMoveToTagert = true;
            tagertPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tagertPoint.z = 0;
        }
        if(isMoveToTagert)
        {
            Debug.DrawLine(transform.position, tagertPoint,Color.red,3f);
            Vector3 dir = Vector3.MoveTowards(this.transform.position , tagertPoint , speedMove*Time.fixedDeltaTime);
            hit2D = Physics2D.Raycast(transform.position , dir , 0.1f , layer);
            if (hit2D.collider == null)
                rigidbody.MovePosition(dir);
            else isMoveToTagert = false;
        }
        
    }
    
}
