// GENERATED AUTOMATICALLY FROM 'Assets/FutureGames/JRPG_Rocket/Input/CommandInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CommandInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CommandInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CommandInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""7ca19104-b02d-4fc8-8d00-9b3c8faa9e46"",
            ""actions"": [
                {
                    ""name"": ""ExecuteCommands"",
                    ""type"": ""Button"",
                    ""id"": ""43cefa7e-0b57-483a-bde4-7aa20f2e247b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveForwards"",
                    ""type"": ""Button"",
                    ""id"": ""9e6715ca-5c83-41c1-a78b-5df5ecb9d2ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""59865f10-9cf6-4df7-a20f-8f96c8cba3cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""91b44e2f-2c7e-4168-9a8b-98c8d94543c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""f244c7d6-31e7-41c6-b3de-e835fc22ad38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5cd42d3-6e38-42dd-82fa-8d2dd61be593"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""ExecuteCommands"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7665f23-adb2-4210-9d5d-975ff28826a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a6fd77f-2dfc-453b-9813-5b1ed78f18b5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""MoveForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b64de83f-62c4-4583-aad3-a48f43de9552"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e4cdb2f-1902-47af-9d18-cc284f998f14"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""MoveBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4475cba-5429-4cee-88a3-5f323a54f2b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4152f13a-802d-4d43-9146-eae9d601f48a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e40d1b1-c36d-4f36-8380-3873d55af273"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""750528f5-2706-4d49-a574-b862b49f0a1e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse & Keyboard"",
            ""bindingGroup"": ""Mouse & Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_ExecuteCommands = m_PlayerOne.FindAction("ExecuteCommands", throwIfNotFound: true);
        m_PlayerOne_MoveForwards = m_PlayerOne.FindAction("MoveForwards", throwIfNotFound: true);
        m_PlayerOne_MoveBackwards = m_PlayerOne.FindAction("MoveBackwards", throwIfNotFound: true);
        m_PlayerOne_MoveLeft = m_PlayerOne.FindAction("MoveLeft", throwIfNotFound: true);
        m_PlayerOne_MoveRight = m_PlayerOne.FindAction("MoveRight", throwIfNotFound: true);
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_ExecuteCommands;
    private readonly InputAction m_PlayerOne_MoveForwards;
    private readonly InputAction m_PlayerOne_MoveBackwards;
    private readonly InputAction m_PlayerOne_MoveLeft;
    private readonly InputAction m_PlayerOne_MoveRight;
    public struct PlayerOneActions
    {
        private @CommandInput m_Wrapper;
        public PlayerOneActions(@CommandInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExecuteCommands => m_Wrapper.m_PlayerOne_ExecuteCommands;
        public InputAction @MoveForwards => m_Wrapper.m_PlayerOne_MoveForwards;
        public InputAction @MoveBackwards => m_Wrapper.m_PlayerOne_MoveBackwards;
        public InputAction @MoveLeft => m_Wrapper.m_PlayerOne_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_PlayerOne_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @ExecuteCommands.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnExecuteCommands;
                @ExecuteCommands.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnExecuteCommands;
                @ExecuteCommands.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnExecuteCommands;
                @MoveForwards.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveForwards;
                @MoveForwards.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveForwards;
                @MoveForwards.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveForwards;
                @MoveBackwards.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveBackwards;
                @MoveBackwards.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveBackwards;
                @MoveBackwards.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveBackwards;
                @MoveLeft.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExecuteCommands.started += instance.OnExecuteCommands;
                @ExecuteCommands.performed += instance.OnExecuteCommands;
                @ExecuteCommands.canceled += instance.OnExecuteCommands;
                @MoveForwards.started += instance.OnMoveForwards;
                @MoveForwards.performed += instance.OnMoveForwards;
                @MoveForwards.canceled += instance.OnMoveForwards;
                @MoveBackwards.started += instance.OnMoveBackwards;
                @MoveBackwards.performed += instance.OnMoveBackwards;
                @MoveBackwards.canceled += instance.OnMoveBackwards;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse & Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IPlayerOneActions
    {
        void OnExecuteCommands(InputAction.CallbackContext context);
        void OnMoveForwards(InputAction.CallbackContext context);
        void OnMoveBackwards(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
}
