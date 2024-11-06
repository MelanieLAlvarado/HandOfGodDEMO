using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField] XRController leftHandController;
    [SerializeField] XRController rightHandController;

    PlayerInput _playerInput = new PlayerInput();
    private void Awake()
    {
        _playerInput = new PlayerInput();
    }
    private void OnEnable() 
    {
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }
    private void Start()
    {
        _playerInput.RightXRController.Position.performed += RightXRControllerPositionUpdated;
        _playerInput.RightXRController.Rotation.performed += RightXRControllerRotationUpdated;
        _playerInput.LeftXRController.Position.performed += LeftXRControllerPositionUpdated;
        _playerInput.LeftXRController.Rotation.performed += LeftXRControllerRotationUpdated;
    }

    private void RightXRControllerPositionUpdated(InputAction.CallbackContext context)
    {
        Debug.Log($"Right hand controller Position updated to: {context.ReadValue<Vector3>()}");
        rightHandController.SetControllerPosition(context.ReadValue<Vector3>());
    }
    private void RightXRControllerRotationUpdated(InputAction.CallbackContext context)
    {
        Debug.Log($"Right hand controller Rotation updated to: {context.ReadValue<Quaternion>()}");
        rightHandController.SetControllerRotation(context.ReadValue<Quaternion>());
    }
    private void LeftXRControllerPositionUpdated(InputAction.CallbackContext context)
    {
        Debug.Log($"Left hand controller Position updated to: {context.ReadValue<Vector3>()}");
        leftHandController.SetControllerPosition(context.ReadValue<Vector3>());
    }
    private void LeftXRControllerRotationUpdated(InputAction.CallbackContext context)
    {
        Debug.Log($"Left hand controller Rotation updated to: {context.ReadValue<Quaternion>()}");
        leftHandController.SetControllerRotation(context.ReadValue<Quaternion>());
    }
}
