// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Input.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Input : IInputActionCollection
{
    private InputActionAsset asset;
    public Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""31a71b1c-c2f2-426f-a6da-685d56abc226"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d774078d-7fd8-4162-b64e-ebe925547ee6"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""976ff062-81ce-4a93-8f7c-7eccf6cfd3e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""899985f5-2d0e-489a-8a5b-1195c0af7854"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc21a69-8bee-42f2-b11c-b09e4b91ed1b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AbilitiesUse"",
            ""id"": ""626f8b57-2c9e-4450-9d2a-a82a89c7a86a"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""26fd5950-0a39-482b-a2a2-f8d781a0a191"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""PassThrough"",
                    ""id"": ""88b1539f-d97e-475c-84d7-3ac72d5960c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""76eaee96-de6c-448f-8b48-83668a971559"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c9b970c-d197-417f-8521-982fab87cdd6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AbilitiesSelection"",
            ""id"": ""7c8509fb-8c99-4286-883a-783de5ec0e52"",
            ""actions"": [
                {
                    ""name"": ""One"",
                    ""type"": ""Button"",
                    ""id"": ""e83f6295-9b73-496c-ad1f-2a8abba847d9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Two"",
                    ""type"": ""Button"",
                    ""id"": ""082e6ee4-81d3-4e32-9e3e-e8d7d750121f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Three"",
                    ""type"": ""Button"",
                    ""id"": ""484aef20-02f6-405a-9aa4-ac84120e8ff1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Four"",
                    ""type"": ""Button"",
                    ""id"": ""03aee080-b82f-4e3a-904e-354a4614bcb0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bcb14937-d693-449b-b1c4-93f2cf46540d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""One"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e0ba503-247b-4eba-9f39-fe78a2fe74f4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Two"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff4e23b7-44db-410b-a8af-05a9a65242c2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Three"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c243a9f1-d519-4e50-bf20-2aab7c154515"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Four"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_Move = m_Movement.GetAction("Move");
        m_Movement_Run = m_Movement.GetAction("Run");
        // AbilitiesUse
        m_AbilitiesUse = asset.GetActionMap("AbilitiesUse");
        m_AbilitiesUse_Aim = m_AbilitiesUse.GetAction("Aim");
        m_AbilitiesUse_Use = m_AbilitiesUse.GetAction("Use");
        // AbilitiesSelection
        m_AbilitiesSelection = asset.GetActionMap("AbilitiesSelection");
        m_AbilitiesSelection_One = m_AbilitiesSelection.GetAction("One");
        m_AbilitiesSelection_Two = m_AbilitiesSelection.GetAction("Two");
        m_AbilitiesSelection_Three = m_AbilitiesSelection.GetAction("Three");
        m_AbilitiesSelection_Four = m_AbilitiesSelection.GetAction("Four");
    }

    ~Input()
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Run;
    public struct MovementActions
    {
        private Input m_Wrapper;
        public MovementActions(Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Run => m_Wrapper.m_Movement_Run;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Run.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                Run.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                Run.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Run.started += instance.OnRun;
                Run.performed += instance.OnRun;
                Run.canceled += instance.OnRun;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // AbilitiesUse
    private readonly InputActionMap m_AbilitiesUse;
    private IAbilitiesUseActions m_AbilitiesUseActionsCallbackInterface;
    private readonly InputAction m_AbilitiesUse_Aim;
    private readonly InputAction m_AbilitiesUse_Use;
    public struct AbilitiesUseActions
    {
        private Input m_Wrapper;
        public AbilitiesUseActions(Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_AbilitiesUse_Aim;
        public InputAction @Use => m_Wrapper.m_AbilitiesUse_Use;
        public InputActionMap Get() { return m_Wrapper.m_AbilitiesUse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AbilitiesUseActions set) { return set.Get(); }
        public void SetCallbacks(IAbilitiesUseActions instance)
        {
            if (m_Wrapper.m_AbilitiesUseActionsCallbackInterface != null)
            {
                Aim.started -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnAim;
                Use.started -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnUse;
                Use.performed -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnUse;
                Use.canceled -= m_Wrapper.m_AbilitiesUseActionsCallbackInterface.OnUse;
            }
            m_Wrapper.m_AbilitiesUseActionsCallbackInterface = instance;
            if (instance != null)
            {
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
                Use.started += instance.OnUse;
                Use.performed += instance.OnUse;
                Use.canceled += instance.OnUse;
            }
        }
    }
    public AbilitiesUseActions @AbilitiesUse => new AbilitiesUseActions(this);

    // AbilitiesSelection
    private readonly InputActionMap m_AbilitiesSelection;
    private IAbilitiesSelectionActions m_AbilitiesSelectionActionsCallbackInterface;
    private readonly InputAction m_AbilitiesSelection_One;
    private readonly InputAction m_AbilitiesSelection_Two;
    private readonly InputAction m_AbilitiesSelection_Three;
    private readonly InputAction m_AbilitiesSelection_Four;
    public struct AbilitiesSelectionActions
    {
        private Input m_Wrapper;
        public AbilitiesSelectionActions(Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @One => m_Wrapper.m_AbilitiesSelection_One;
        public InputAction @Two => m_Wrapper.m_AbilitiesSelection_Two;
        public InputAction @Three => m_Wrapper.m_AbilitiesSelection_Three;
        public InputAction @Four => m_Wrapper.m_AbilitiesSelection_Four;
        public InputActionMap Get() { return m_Wrapper.m_AbilitiesSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AbilitiesSelectionActions set) { return set.Get(); }
        public void SetCallbacks(IAbilitiesSelectionActions instance)
        {
            if (m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface != null)
            {
                One.started -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnOne;
                One.performed -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnOne;
                One.canceled -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnOne;
                Two.started -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnTwo;
                Two.performed -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnTwo;
                Two.canceled -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnTwo;
                Three.started -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnThree;
                Three.performed -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnThree;
                Three.canceled -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnThree;
                Four.started -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnFour;
                Four.performed -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnFour;
                Four.canceled -= m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface.OnFour;
            }
            m_Wrapper.m_AbilitiesSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                One.started += instance.OnOne;
                One.performed += instance.OnOne;
                One.canceled += instance.OnOne;
                Two.started += instance.OnTwo;
                Two.performed += instance.OnTwo;
                Two.canceled += instance.OnTwo;
                Three.started += instance.OnThree;
                Three.performed += instance.OnThree;
                Three.canceled += instance.OnThree;
                Four.started += instance.OnFour;
                Four.performed += instance.OnFour;
                Four.canceled += instance.OnFour;
            }
        }
    }
    public AbilitiesSelectionActions @AbilitiesSelection => new AbilitiesSelectionActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IAbilitiesUseActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
    }
    public interface IAbilitiesSelectionActions
    {
        void OnOne(InputAction.CallbackContext context);
        void OnTwo(InputAction.CallbackContext context);
        void OnThree(InputAction.CallbackContext context);
        void OnFour(InputAction.CallbackContext context);
    }
}
