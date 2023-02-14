using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Combo/State")]
public class StateBase : ScriptableObject
{
      [Header("Timer")]
      public float duration;

      [Header("States")]
      public StateBase defaultState;

      [Space(10)]
      public StateBase northState;
      public StateBase southState;
      public StateBase eastState;
      public StateBase westState;

      public StateBase HandleInput(string context)
      {
            switch (context)
            {
                  case "North":
                        return northState;

                  case "South":
                        return southState;

                  case "East":
                        return eastState;

                  case "West":
                        return westState;

                  default:
                        return defaultState;
            }
      }
}
