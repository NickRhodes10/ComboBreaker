using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboFSM : MonoBehaviour
{
      [SerializeField] private StateBase _curState;

      private float _timer = 0f;

      public void HandleInput(string context)
      {
            if(_curState == null)
            {
                  Debug.LogWarning(gameObject.name + " does not have a state, please add one");
                  return;
            }

           TransitionToState(_curState.HandleInput(context));
      }

      private void TransitionToState(StateBase newState)
      {
            Debug.Log(newState.name);
      }

}
