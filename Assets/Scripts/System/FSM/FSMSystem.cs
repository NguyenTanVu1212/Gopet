using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMSystem : MonoBehaviour
{
    #region Variable
    public List<FSMState> lsState = new List<FSMState>();
    public FSMState currentState;
    public FSMState preverState;
    #endregion
    #region State action
    public void GotoState(FSMState state)
    {
        if (!lsState.Contains(state))
        {
            lsState.Add(state);
        }
        if (currentState != null)
        {
            preverState = currentState;
            currentState.OnExit();
        }        
        currentState = state;
        currentState.OnEnter();
    }
    public void AddState(FSMState state)
    {
        lsState.Add(state);
        if (lsState.Count == 1)
        {
            currentState = state;
            currentState.OnEnter();
        }
    }
    public void DeleteState(string name)
    {
        if (lsState.Count <= 1)
        {
            Debug.Log("Cant delete state " + name + ". This object must have one state");
            return;
        }
            
        foreach(var e in lsState)
        {
            if(e.nameState == name)
            {
                if(currentState == e)
                {
                    currentState.OnExit();
                    lsState.Remove(e);
                    currentState = lsState[0];
                    currentState.OnEnter();
                }
                lsState.Remove(e);
                return;
            }
            
        }
        Debug.Log("Cant delete state " + name + ". Cant find state name : " + name);
    }
    #endregion

    #region Unity Region
    void Start()
    {
        OnStart();
    }
    void Update()
    {
        OnUpdate();
    }
    private void FixedUpdate()
    {
        OnFixUpdate();
    }
    private void LateUpdate()
    {
        OnLateUpdate();
    }

    public virtual void OnStart()
    {
        currentState.OnEnter();
    }
    public virtual void OnUpdate()
    {
        currentState.OnUpdate();
    }
    public virtual void OnFixUpdate()
    {
        currentState.OnFixUpdate();
    }
    public virtual void OnLateUpdate()
    {
        currentState.OnLateUpdate();
            
    }
    #endregion


}
