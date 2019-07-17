// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputMaster : IInputActionCollection
{
    private InputActionAsset asset;
    public InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player 2"",
            ""id"": ""8e12833e-bf89-4e32-af59-9e28dc1320a2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""07c57896-83b0-4f40-baee-86e4b595fc71"",
                    ""expectedControlLayout"": ""Stick"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d64aac29-705d-4533-b214-682c4a9c9cde"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";DualShock"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        },
        {
            ""name"": ""Player 1"",
            ""id"": ""b7845a8e-82f0-448f-ba20-9b4c29fd19c4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""52e5aa5c-cdae-4520-81bd-adae7c4c86cd"",
                    ""expectedControlLayout"": ""Stick"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec208505-bf6f-4089-bb52-94cbdf487b49"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";DualShock"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""DualShock"",
            ""basedOn"": """",
            ""bindingGroup"": ""DualShock"",
            ""devices"": [
                {
                    ""devicePath"": ""<PS4DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player 2
        m_Player2 = asset.GetActionMap("Player 2");
        m_Player2_Movement = m_Player2.GetAction("Movement");
        // Player 1
        m_Player1 = asset.GetActionMap("Player 1");
        m_Player1_Movement = m_Player1.GetAction("Movement");
    }

    ~InputMaster()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

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

    // Player 2
    private InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private InputAction m_Player2_Movement;
    public struct Player2Actions
    {
        private InputMaster m_Wrapper;
        public Player2Actions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement { get { return m_Wrapper.m_Player2_Movement; } }
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
            }
        }
    }
    public Player2Actions @Player2
    {
        get
        {
            return new Player2Actions(this);
        }
    }

    // Player 1
    private InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private InputAction m_Player1_Movement;
    public struct Player1Actions
    {
        private InputMaster m_Wrapper;
        public Player1Actions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement { get { return m_Wrapper.m_Player1_Movement; } }
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
            }
        }
    }
    public Player1Actions @Player1
    {
        get
        {
            return new Player1Actions(this);
        }
    }
    private int m_DualShockSchemeIndex = -1;
    public InputControlScheme DualShockScheme
    {
        get
        {
            if (m_DualShockSchemeIndex == -1) m_DualShockSchemeIndex = asset.GetControlSchemeIndex("DualShock");
            return asset.controlSchemes[m_DualShockSchemeIndex];
        }
    }
    public interface IPlayer2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
