// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/For Virtual Concert Hall/Advanced 3rdPersonController/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControlsMovement"",
            ""id"": ""091b8ab4-5fcf-4cb3-a653-aadb40e886df"",
            ""actions"": [
                {
                    ""name"": ""MovementControls"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0dc2440e-b8ed-4097-a5f4-4a2d7eab39ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6df9945d-6b43-43ad-ac10-3d75cddaf310"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6e11779d-8438-4f2b-bc2d-ae92b5eda31b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6539afef-b3c5-4b00-bb62-499029780750"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75eab231-3fdb-4b06-a323-cb0e592d1332"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a8d621c2-fb52-4bdf-95cd-0abef6478389"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc46ac91-a7d5-4c5a-bb6a-245b15556312"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""9756e832-7065-4088-af90-2ee1ca675c09"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""76dfd1e5-5bdf-42be-b5b5-ce39a6e6dac8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e6ae938-c4c0-45f1-865d-c57567835cba"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b050624c-346b-4d27-be39-426d328be412"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dacb43ba-a995-4049-814a-b2e0afb4e78c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ed59faf2-e43b-45ec-a1cf-7d3d1330a05c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Stick"",
                    ""id"": ""1eff67c9-a2ef-49ad-934e-1a75fc29e56d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aa6107a3-30e5-4421-bb9d-4aaff107ca2a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8575ea76-a450-40f6-a56f-11c08d25de6c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c29e85a6-75e9-461a-92e7-6584cc2234c1"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a406d0d3-6d9f-4c80-9f0d-0ded9833a364"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlsMovement
        m_PlayerControlsMovement = asset.FindActionMap("PlayerControlsMovement", throwIfNotFound: true);
        m_PlayerControlsMovement_MovementControls = m_PlayerControlsMovement.FindAction("MovementControls", throwIfNotFound: true);
        m_PlayerControlsMovement_Camera = m_PlayerControlsMovement.FindAction("Camera", throwIfNotFound: true);
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

    // PlayerControlsMovement
    private readonly InputActionMap m_PlayerControlsMovement;
    private IPlayerControlsMovementActions m_PlayerControlsMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerControlsMovement_MovementControls;
    private readonly InputAction m_PlayerControlsMovement_Camera;
    public struct PlayerControlsMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlsMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementControls => m_Wrapper.m_PlayerControlsMovement_MovementControls;
        public InputAction @Camera => m_Wrapper.m_PlayerControlsMovement_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlsMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsMovementActions instance)
        {
            if (m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface != null)
            {
                @MovementControls.started -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnMovementControls;
                @MovementControls.performed -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnMovementControls;
                @MovementControls.canceled -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnMovementControls;
                @Camera.started -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerControlsMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementControls.started += instance.OnMovementControls;
                @MovementControls.performed += instance.OnMovementControls;
                @MovementControls.canceled += instance.OnMovementControls;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerControlsMovementActions @PlayerControlsMovement => new PlayerControlsMovementActions(this);
    public interface IPlayerControlsMovementActions
    {
        void OnMovementControls(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}
