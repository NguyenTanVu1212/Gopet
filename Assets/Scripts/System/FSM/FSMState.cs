using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMState 
{
    public string nameState;
    protected FSMSystem system;
    public FSMState()
    {
        nameState = "NoneState";
    }
    public FSMState(string _name , FSMSystem _system)
    {
        this.system = _system;
        this.nameState = _name;
    }

    public virtual void OnSetup()
    {

    }
    public virtual void OnEnter()
    {

    }
    public virtual void OnUpdate()
    {

    }
    public virtual void OnFixUpdate()
    {

    }
    public virtual void OnLateUpdate()
    {

    }
    public virtual void OnExit()
    {

    }
}
