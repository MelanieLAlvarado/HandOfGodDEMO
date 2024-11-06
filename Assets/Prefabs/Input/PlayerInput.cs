//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/Prefabs/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""RightXRController"",
            ""id"": ""2414d6ca-a855-4735-bbcf-ed47ceb964d3"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""d30a4db3-ca6a-47f5-b528-d77f74a6392f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""704f178c-7297-4da0-a45c-98e9eafc8aec"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07f35032-d810-43cb-9531-659da647d752"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f3af8ee-93b0-4d63-9ee4-ad90aa10fddc"",
                    ""path"": ""<XRController>{RightHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftXRController"",
            ""id"": ""9a59c86a-d34f-4a99-bef9-258b03b46705"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""32eeeb3a-62e3-4d10-8b10-e879a1cb9ee0"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""a6c8ce24-0436-4d6f-8051-a9b71b7aecfb"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""055a1b23-3a5d-4506-9800-89cb84ec8460"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1b26aca-ea4b-4f59-98ee-65f553d80315"",
                    ""path"": ""<XRController>{LeftHand}/{DeviceRotation}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightXRController
        m_RightXRController = asset.FindActionMap("RightXRController", throwIfNotFound: true);
        m_RightXRController_Position = m_RightXRController.FindAction("Position", throwIfNotFound: true);
        m_RightXRController_Rotation = m_RightXRController.FindAction("Rotation", throwIfNotFound: true);
        // LeftXRController
        m_LeftXRController = asset.FindActionMap("LeftXRController", throwIfNotFound: true);
        m_LeftXRController_Position = m_LeftXRController.FindAction("Position", throwIfNotFound: true);
        m_LeftXRController_Rotation = m_LeftXRController.FindAction("Rotation", throwIfNotFound: true);
    }

    ~@PlayerInput()
    {
        UnityEngine.Debug.Assert(!m_RightXRController.enabled, "This will cause a leak and performance issues, PlayerInput.RightXRController.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_LeftXRController.enabled, "This will cause a leak and performance issues, PlayerInput.LeftXRController.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RightXRController
    private readonly InputActionMap m_RightXRController;
    private List<IRightXRControllerActions> m_RightXRControllerActionsCallbackInterfaces = new List<IRightXRControllerActions>();
    private readonly InputAction m_RightXRController_Position;
    private readonly InputAction m_RightXRController_Rotation;
    public struct RightXRControllerActions
    {
        private @PlayerInput m_Wrapper;
        public RightXRControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_RightXRController_Position;
        public InputAction @Rotation => m_Wrapper.m_RightXRController_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_RightXRController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightXRControllerActions set) { return set.Get(); }
        public void AddCallbacks(IRightXRControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Add(instance);
            @Position.started += instance.OnPosition;
            @Position.performed += instance.OnPosition;
            @Position.canceled += instance.OnPosition;
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
        }

        private void UnregisterCallbacks(IRightXRControllerActions instance)
        {
            @Position.started -= instance.OnPosition;
            @Position.performed -= instance.OnPosition;
            @Position.canceled -= instance.OnPosition;
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
        }

        public void RemoveCallbacks(IRightXRControllerActions instance)
        {
            if (m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRightXRControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_RightXRControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RightXRControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RightXRControllerActions @RightXRController => new RightXRControllerActions(this);

    // LeftXRController
    private readonly InputActionMap m_LeftXRController;
    private List<ILeftXRControllerActions> m_LeftXRControllerActionsCallbackInterfaces = new List<ILeftXRControllerActions>();
    private readonly InputAction m_LeftXRController_Position;
    private readonly InputAction m_LeftXRController_Rotation;
    public struct LeftXRControllerActions
    {
        private @PlayerInput m_Wrapper;
        public LeftXRControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_LeftXRController_Position;
        public InputAction @Rotation => m_Wrapper.m_LeftXRController_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_LeftXRController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftXRControllerActions set) { return set.Get(); }
        public void AddCallbacks(ILeftXRControllerActions instance)
        {
            if (instance == null || m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Add(instance);
            @Position.started += instance.OnPosition;
            @Position.performed += instance.OnPosition;
            @Position.canceled += instance.OnPosition;
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
        }

        private void UnregisterCallbacks(ILeftXRControllerActions instance)
        {
            @Position.started -= instance.OnPosition;
            @Position.performed -= instance.OnPosition;
            @Position.canceled -= instance.OnPosition;
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
        }

        public void RemoveCallbacks(ILeftXRControllerActions instance)
        {
            if (m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILeftXRControllerActions instance)
        {
            foreach (var item in m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LeftXRControllerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LeftXRControllerActions @LeftXRController => new LeftXRControllerActions(this);
    public interface IRightXRControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface ILeftXRControllerActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
}
