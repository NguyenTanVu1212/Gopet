using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMove : MonoBehaviour
{
    [SerializeField]
    GameObject character;
    bool isMove = false;
    [SerializeField] float petMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if(character==  null)
        {
            character = new GameObject();

            character.transform.position = Vector3.zero;
        }
        isMove = false;
        petMoveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, character.transform.position) > 1f)
        {
            isMove = true;
        }
        else isMove = false;

        if(isMove)
        {
            transform.position = Vector3.MoveTowards(this.transform.position ,character.transform.position  ,petMoveSpeed *Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, character.transform.position) > 4f)
        {
            petMoveSpeed = petMoveSpeed * 1.456f;
        }
        else petMoveSpeed = 5;
    }
}
