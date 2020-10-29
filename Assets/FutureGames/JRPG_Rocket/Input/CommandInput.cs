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
                },
                {
                    ""name"": ""ChangeSelectedHero"",
                    ""type"": ""Value"",
                    ""id"": ""f34ccff4-53e6-4621-9636-97c9e505b651"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveLastCommand"",
                    ""type"": ""Button"",
                    ""id"": ""a0ed2267-9cfc-4607-ae64-472705b11918"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""352e6158-1304-46c4-bb43-6486e8f195d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""7700a66c-013d-4025-9b82-93d5b2a0eca7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""922a4dfd-b1e4-408f-8936-e6adf91bf1bc"",
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
                    ""groups"": ""Mouse & Keyboard"",
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
                    ""groups"": ""Mouse & Keyboard"",
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
                    ""groups"": ""Mouse & Keyboard"",
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
                    ""groups"": ""Mouse & Keyboard"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""ecb0512b-534d-4572-837b-83d3b89a192b"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""ChangeSelectedHero"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b335b1e-a579-4b6b-a295-d6e13f97d6e2"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""RemoveLastCommand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfd61b55-3c38-4b55-9e15-a43955d160a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd05d48b-9ee9-4ecc-af14-57f8e86ee4a6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da67ef71-a2e3-45f4-b5fc-55245c163808"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""RotateRight"",
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
        m_PlayerOne_ChangeSelectedHero = m_PlayerOne.FindAction("ChangeSelectedHero", throwIfNotFound: true);
        m_PlayerOne_RemoveLastCommand = m_PlayerOne.FindAction("RemoveLastCommand", throwIfNotFound: true);
        m_PlayerOne_Attack = m_PlayerOne.FindAction("Attack", throwIfNotFound: true);
        m_PlayerOne_RotateLeft = m_PlayerOne.FindAction("RotateLeft", throwIfNotFound: true);
        m_PlayerOne_RotateRight = m_PlayerOne.FindAction("RotateRight", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerOne_ChangeSelectedHero;
    private readonly InputAction m_PlayerOne_RemoveLastCommand;
    private readonly InputAction m_PlayerOne_Attack;
    private readonly InputAction m_PlayerOne_RotateLeft;
    private readonly InputAction m_PlayerOne_RotateRight;
    public struct PlayerOneActions
    {
        private @CommandInput m_Wrapper;
        public PlayerOneActions(@CommandInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExecuteCommands => m_Wrapper.m_PlayerOne_ExecuteCommands;
        public InputAction @MoveForwards => m_Wrapper.m_PlayerOne_MoveForwards;
        public InputAction @MoveBackwards => m_Wrapper.m_PlayerOne_MoveBackwards;
        public InputAction @MoveLeft => m_Wrapper.m_PlayerOne_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_PlayerOne_MoveRight;
        public InputAction @ChangeSelectedHero => m_Wrapper.m_PlayerOne_ChangeSelectedHero;
        public InputAction @RemoveLastCommand => m_Wrapper.m_PlayerOne_RemoveLastCommand;
        public InputAction @Attack => m_Wrapper.m_PlayerOne_Attack;
        public InputAction @RotateLeft => m_Wrapper.m_PlayerOne_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_PlayerOne_RotateRight;
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
                @ChangeSelectedHero.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnChangeSelectedHero;
                @ChangeSelectedHero.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnChangeSelectedHero;
                @ChangeSelectedHero.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnChangeSelectedHero;
                @RemoveLastCommand.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRemoveLastCommand;
                @RemoveLastCommand.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRemoveLastCommand;
                @RemoveLastCommand.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRemoveLastCommand;
                @Attack.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAttack;
                @RotateLeft.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRotateRight;
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
                @ChangeSelectedHero.started += instance.OnChangeSelectedHero;
                @ChangeSelectedHero.performed += instance.OnChangeSelectedHero;
                @ChangeSelectedHero.canceled += instance.OnChangeSelectedHero;
                @RemoveLastCommand.started += instance.OnRemoveLastCommand;
                @RemoveLastCommand.performed += instance.OnRemoveLastCommand;
                @RemoveLastCommand.canceled += instance.OnRemoveLastCommand;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
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
        void OnChangeSelectedHero(InputAction.CallbackContext context);
        void OnRemoveLastCommand(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
    }
}
