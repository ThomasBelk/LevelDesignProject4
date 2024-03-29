//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""21b81c09-269f-46f5-9612-e7355a8c95de"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9e117395-9823-4866-b9dc-f4754893e8bb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""70ce1d99-1bc5-4b26-822b-dbc4fcbb38c6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60f287a0-33d9-4d2e-8dbe-b4f6aa4a88e4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InteractButton"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f617b55b-f093-4d9b-aa38-565763855b02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropButton"",
                    ""type"": ""PassThrough"",
                    ""id"": ""066adf42-3dd2-4fdd-a146-a0277504e990"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurnPageRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""28632c1f-ee5f-4f58-8a15-97fe770e2c13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurnPageLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""71414e4d-095e-44d8-98c1-13ab5307ece6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cd9d5100-1387-4eb5-9890-7a54831356f4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c57776c9-9ecb-4a4c-af84-0b4c7e96b569"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a0cc9e69-689c-4459-85d1-6f239bc35e1c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""405521e4-e081-4de4-9a75-899bcd168b31"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dee85385-28de-4721-9e7a-3d8b63c17578"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3fff720e-b562-4ed7-84f3-5c6e2fcf9634"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd650446-3d6f-43c7-b951-4f3c45be917d"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cabde4b-1827-469e-88b7-181a8a1aca3c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""222ef3b5-fcc2-4f63-8594-6e1451c4341d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnPageRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36412526-ca16-4427-8679-4827565ed627"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnPageLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fab575fa-0f7c-4251-9a7f-30c67ea738a6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteractButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_MouseX = m_Player.FindAction("MouseX", throwIfNotFound: true);
        m_Player_MouseY = m_Player.FindAction("MouseY", throwIfNotFound: true);
        m_Player_InteractButton = m_Player.FindAction("InteractButton", throwIfNotFound: true);
        m_Player_DropButton = m_Player.FindAction("DropButton", throwIfNotFound: true);
        m_Player_TurnPageRight = m_Player.FindAction("TurnPageRight", throwIfNotFound: true);
        m_Player_TurnPageLeft = m_Player.FindAction("TurnPageLeft", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_MouseX;
    private readonly InputAction m_Player_MouseY;
    private readonly InputAction m_Player_InteractButton;
    private readonly InputAction m_Player_DropButton;
    private readonly InputAction m_Player_TurnPageRight;
    private readonly InputAction m_Player_TurnPageLeft;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @MouseX => m_Wrapper.m_Player_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Player_MouseY;
        public InputAction @InteractButton => m_Wrapper.m_Player_InteractButton;
        public InputAction @DropButton => m_Wrapper.m_Player_DropButton;
        public InputAction @TurnPageRight => m_Wrapper.m_Player_TurnPageRight;
        public InputAction @TurnPageLeft => m_Wrapper.m_Player_TurnPageLeft;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @MouseX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @InteractButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractButton;
                @InteractButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractButton;
                @InteractButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractButton;
                @DropButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropButton;
                @DropButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropButton;
                @DropButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDropButton;
                @TurnPageRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageRight;
                @TurnPageRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageRight;
                @TurnPageRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageRight;
                @TurnPageLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageLeft;
                @TurnPageLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageLeft;
                @TurnPageLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurnPageLeft;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @InteractButton.started += instance.OnInteractButton;
                @InteractButton.performed += instance.OnInteractButton;
                @InteractButton.canceled += instance.OnInteractButton;
                @DropButton.started += instance.OnDropButton;
                @DropButton.performed += instance.OnDropButton;
                @DropButton.canceled += instance.OnDropButton;
                @TurnPageRight.started += instance.OnTurnPageRight;
                @TurnPageRight.performed += instance.OnTurnPageRight;
                @TurnPageRight.canceled += instance.OnTurnPageRight;
                @TurnPageLeft.started += instance.OnTurnPageLeft;
                @TurnPageLeft.performed += instance.OnTurnPageLeft;
                @TurnPageLeft.canceled += instance.OnTurnPageLeft;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnInteractButton(InputAction.CallbackContext context);
        void OnDropButton(InputAction.CallbackContext context);
        void OnTurnPageRight(InputAction.CallbackContext context);
        void OnTurnPageLeft(InputAction.CallbackContext context);
    }
}
