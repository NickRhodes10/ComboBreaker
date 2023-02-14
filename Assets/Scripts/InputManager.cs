using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(ComboFSM))]
public class InputManager : MonoBehaviour
{
      private PlayerInputActions _playerInputActions;
      private ComboFSM _comboFSM;

      private void Awake()
      {
            _playerInputActions = new PlayerInputActions();
            _comboFSM = GetComponent<ComboFSM>();
      }

      private void OnEnable()
      {
            _playerInputActions.Gameplay.AttackNorth.performed += AttackNorth;
            _playerInputActions.Gameplay.AttackSouth.performed += AttackSouth;
            _playerInputActions.Gameplay.AttackEast.performed += AttackEast;
            _playerInputActions.Gameplay.AttackWest.performed += AttackWest;

            _playerInputActions.Gameplay.AttackNorth.Enable();
            _playerInputActions.Gameplay.AttackSouth.Enable();
            _playerInputActions.Gameplay.AttackEast.Enable();
            _playerInputActions.Gameplay.AttackWest.Enable();
      }

      private void OnDisable()
      {
            _playerInputActions.Gameplay.AttackNorth.Disable();
            _playerInputActions.Gameplay.AttackSouth.Disable();
            _playerInputActions.Gameplay.AttackEast.Disable();
            _playerInputActions.Gameplay.AttackWest.Disable();
      }

      private void AttackNorth(InputAction.CallbackContext obj)
      {
            _comboFSM.HandleInput("North");
      }

      private void AttackEast(InputAction.CallbackContext obj)
      {
            _comboFSM.HandleInput("East");
      }

      private void AttackWest(InputAction.CallbackContext obj)
      {
            _comboFSM.HandleInput("West");
      }

      private void AttackSouth(InputAction.CallbackContext obj)
      {
            _comboFSM.HandleInput("South");
      }
}
