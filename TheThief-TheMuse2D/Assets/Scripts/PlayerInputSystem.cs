// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Player1Controller"",
            ""id"": ""30e29117-b9a2-49e4-947e-5f38fed96beb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""48436bcd-990f-4ab2-b1fa-f3bf4f379f1e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e08d0db-23bc-41bd-bb38-f2ec53510448"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8f37012f-8567-45aa-a58e-71b5c899f65f"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2640dde6-4fe8-46bb-b86c-a77b233e11ae"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Controller
        m_Player1Controller = asset.FindActionMap("Player1Controller", throwIfNotFound: true);
        m_Player1Controller_Movement = m_Player1Controller.FindAction("Movement", throwIfNotFound: true);
        m_Player1Controller_Jump = m_Player1Controller.FindAction("Jump", throwIfNotFound: true);
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

    // Player1Controller
    private readonly InputActionMap m_Player1Controller;
    private IPlayer1ControllerActions m_Player1ControllerActionsCallbackInterface;
    private readonly InputAction m_Player1Controller_Movement;
    private readonly InputAction m_Player1Controller_Jump;
    public struct Player1ControllerActions
    {
        private @PlayerInputSystem m_Wrapper;
        public Player1ControllerActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1Controller_Movement;
        public InputAction @Jump => m_Wrapper.m_Player1Controller_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player1Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1ControllerActions instance)
        {
            if (m_Wrapper.m_Player1ControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1ControllerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player1ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Player1ControllerActions @Player1Controller => new Player1ControllerActions(this);
    public interface IPlayer1ControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
