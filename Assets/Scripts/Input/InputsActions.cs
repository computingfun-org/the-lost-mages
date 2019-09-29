// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputsActions.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public class Actions : IInputActionCollection
    {
        private InputActionAsset asset;
        public Actions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputsActions"",
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
                    ""name"": ""WASD"",
                    ""id"": ""cc895817-745c-4b81-a7ad-057439115bd9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f7173597-ae7d-4da8-aed8-0383a5d9c839"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79e14767-1f6b-466d-92bf-027a46d621b3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""307fa384-ba0f-4b2d-b549-20a7900a00c1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c312fe21-a588-4fcc-a622-b1c89321bcd7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                },
                {
                    ""name"": """",
                    ""id"": ""5e03dd6f-66a7-45c7-a562-c2c5a2e7aeb6"",
                    ""path"": ""<Keyboard>/leftShift"",
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
            ""name"": ""AbilitySelect"",
            ""id"": ""626f8b57-2c9e-4450-9d2a-a82a89c7a86a"",
            ""actions"": [
                {
                    ""name"": ""Four"",
                    ""type"": ""Button"",
                    ""id"": ""a99649ef-cc22-4d8a-84c7-68d52abef1a0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Three"",
                    ""type"": ""Button"",
                    ""id"": ""6e7fa403-be53-4d39-989c-b49427d54948"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Two"",
                    ""type"": ""Button"",
                    ""id"": ""5fda7a97-b288-41a1-942a-703c599cd96b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""One"",
                    ""type"": ""Button"",
                    ""id"": ""6a92d8f7-2ef4-4009-973a-9b37e52ad197"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8f4c7e71-a3a1-444a-b5a5-ea2f5715c3e5"",
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
                    ""id"": ""c21b7c24-bcac-4006-a0cd-b1b52475ec5f"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""One"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64dba7f9-91e2-4216-8437-0cb747800759"",
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
                    ""id"": ""3dfd03b7-0ea2-4ef2-af8f-a38135f72785"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Two"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4641282e-004b-41e8-9e9c-7b7dda9595a8"",
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
                    ""id"": ""b4b6375c-7f93-4c5a-8505-447d2393e643"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Three"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f0c7153-e13b-4c4e-9a7b-443156444353"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Four"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b66b61de-03ac-410a-a4db-576f7218a002"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Four"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AbilityUse"",
            ""id"": ""51956bc0-f46d-4aac-81e1-c9977d91d4f3"",
            ""actions"": [
                {
                    ""name"": ""Use"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1d9b54b-3b69-47c6-9fbe-5c4a79a409fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ed8c2c8c-186b-458d-bd8f-be00f50d1df4"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimPress"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e578df0d-33f2-4c6c-af96-f76b35416152"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c27da21a-9126-4e47-94cf-55700554b7fa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0d3e2473-cd7d-4bcb-b4c8-d99800e262ae"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""25b05aad-ccf7-4462-bf85-dca765d954a2"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fab97fa0-0a3c-4c8f-93db-4f277d73b238"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1420bdf0-57f2-4b29-b624-fdc6df6dd484"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6939244b-801a-4447-a62d-530ca8092d15"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9d8eab2-c180-4060-8617-f18226f1a766"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5eb18807-5e05-4eaf-9f6f-c6735338c729"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b153a160-eb13-403a-869a-f028a538735c"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c9df58a-ab44-4e42-a5a2-ea384180272f"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Build"",
            ""id"": ""14774b1b-a101-4da1-bfc5-c9431c5b15f1"",
            ""actions"": [
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""d595f62e-ea9d-4ce4-8b39-13d9c8d00f58"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8621ca52-948b-469b-9824-eeb4e4ffa1a9"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""681b792a-cad2-4406-bbb7-85587b91ce77"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""fc7f7bbc-21b4-46c6-a717-5a5c30c3c864"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a624c672-6693-4d2d-a0bb-8e3b94c4ac05"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4b411ca1-62c8-4894-87ad-15d283f6da98"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de7c476b-8e97-443b-ad85-3a94eb9100b9"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0.1)"",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""control scheme"",
            ""bindingGroup"": ""control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Movement
            m_Movement = asset.GetActionMap("Movement");
            m_Movement_Move = m_Movement.GetAction("Move");
            m_Movement_Run = m_Movement.GetAction("Run");
            // AbilitySelect
            m_AbilitySelect = asset.GetActionMap("AbilitySelect");
            m_AbilitySelect_Four = m_AbilitySelect.GetAction("Four");
            m_AbilitySelect_Three = m_AbilitySelect.GetAction("Three");
            m_AbilitySelect_Two = m_AbilitySelect.GetAction("Two");
            m_AbilitySelect_One = m_AbilitySelect.GetAction("One");
            // AbilityUse
            m_AbilityUse = asset.GetActionMap("AbilityUse");
            m_AbilityUse_Use = m_AbilityUse.GetAction("Use");
            m_AbilityUse_Aim = m_AbilityUse.GetAction("Aim");
            m_AbilityUse_AimPress = m_AbilityUse.GetAction("AimPress");
            // Build
            m_Build = asset.GetActionMap("Build");
            m_Build_Menu = m_Build.GetAction("Menu");
            // Camera
            m_Camera = asset.GetActionMap("Camera");
            m_Camera_Zoom = m_Camera.GetAction("Zoom");
        }

        ~Actions()
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
            private Actions m_Wrapper;
            public MovementActions(Actions wrapper) { m_Wrapper = wrapper; }
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

        // AbilitySelect
        private readonly InputActionMap m_AbilitySelect;
        private IAbilitySelectActions m_AbilitySelectActionsCallbackInterface;
        private readonly InputAction m_AbilitySelect_Four;
        private readonly InputAction m_AbilitySelect_Three;
        private readonly InputAction m_AbilitySelect_Two;
        private readonly InputAction m_AbilitySelect_One;
        public struct AbilitySelectActions
        {
            private Actions m_Wrapper;
            public AbilitySelectActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Four => m_Wrapper.m_AbilitySelect_Four;
            public InputAction @Three => m_Wrapper.m_AbilitySelect_Three;
            public InputAction @Two => m_Wrapper.m_AbilitySelect_Two;
            public InputAction @One => m_Wrapper.m_AbilitySelect_One;
            public InputActionMap Get() { return m_Wrapper.m_AbilitySelect; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(AbilitySelectActions set) { return set.Get(); }
            public void SetCallbacks(IAbilitySelectActions instance)
            {
                if (m_Wrapper.m_AbilitySelectActionsCallbackInterface != null)
                {
                    Four.started -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnFour;
                    Four.performed -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnFour;
                    Four.canceled -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnFour;
                    Three.started -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnThree;
                    Three.performed -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnThree;
                    Three.canceled -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnThree;
                    Two.started -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnTwo;
                    Two.performed -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnTwo;
                    Two.canceled -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnTwo;
                    One.started -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnOne;
                    One.performed -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnOne;
                    One.canceled -= m_Wrapper.m_AbilitySelectActionsCallbackInterface.OnOne;
                }
                m_Wrapper.m_AbilitySelectActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Four.started += instance.OnFour;
                    Four.performed += instance.OnFour;
                    Four.canceled += instance.OnFour;
                    Three.started += instance.OnThree;
                    Three.performed += instance.OnThree;
                    Three.canceled += instance.OnThree;
                    Two.started += instance.OnTwo;
                    Two.performed += instance.OnTwo;
                    Two.canceled += instance.OnTwo;
                    One.started += instance.OnOne;
                    One.performed += instance.OnOne;
                    One.canceled += instance.OnOne;
                }
            }
        }
        public AbilitySelectActions @AbilitySelect => new AbilitySelectActions(this);

        // AbilityUse
        private readonly InputActionMap m_AbilityUse;
        private IAbilityUseActions m_AbilityUseActionsCallbackInterface;
        private readonly InputAction m_AbilityUse_Use;
        private readonly InputAction m_AbilityUse_Aim;
        private readonly InputAction m_AbilityUse_AimPress;
        public struct AbilityUseActions
        {
            private Actions m_Wrapper;
            public AbilityUseActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Use => m_Wrapper.m_AbilityUse_Use;
            public InputAction @Aim => m_Wrapper.m_AbilityUse_Aim;
            public InputAction @AimPress => m_Wrapper.m_AbilityUse_AimPress;
            public InputActionMap Get() { return m_Wrapper.m_AbilityUse; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(AbilityUseActions set) { return set.Get(); }
            public void SetCallbacks(IAbilityUseActions instance)
            {
                if (m_Wrapper.m_AbilityUseActionsCallbackInterface != null)
                {
                    Use.started -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnUse;
                    Use.performed -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnUse;
                    Use.canceled -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnUse;
                    Aim.started -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAim;
                    Aim.performed -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAim;
                    Aim.canceled -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAim;
                    AimPress.started -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAimPress;
                    AimPress.performed -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAimPress;
                    AimPress.canceled -= m_Wrapper.m_AbilityUseActionsCallbackInterface.OnAimPress;
                }
                m_Wrapper.m_AbilityUseActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Use.started += instance.OnUse;
                    Use.performed += instance.OnUse;
                    Use.canceled += instance.OnUse;
                    Aim.started += instance.OnAim;
                    Aim.performed += instance.OnAim;
                    Aim.canceled += instance.OnAim;
                    AimPress.started += instance.OnAimPress;
                    AimPress.performed += instance.OnAimPress;
                    AimPress.canceled += instance.OnAimPress;
                }
            }
        }
        public AbilityUseActions @AbilityUse => new AbilityUseActions(this);

        // Build
        private readonly InputActionMap m_Build;
        private IBuildActions m_BuildActionsCallbackInterface;
        private readonly InputAction m_Build_Menu;
        public struct BuildActions
        {
            private Actions m_Wrapper;
            public BuildActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Menu => m_Wrapper.m_Build_Menu;
            public InputActionMap Get() { return m_Wrapper.m_Build; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BuildActions set) { return set.Get(); }
            public void SetCallbacks(IBuildActions instance)
            {
                if (m_Wrapper.m_BuildActionsCallbackInterface != null)
                {
                    Menu.started -= m_Wrapper.m_BuildActionsCallbackInterface.OnMenu;
                    Menu.performed -= m_Wrapper.m_BuildActionsCallbackInterface.OnMenu;
                    Menu.canceled -= m_Wrapper.m_BuildActionsCallbackInterface.OnMenu;
                }
                m_Wrapper.m_BuildActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Menu.started += instance.OnMenu;
                    Menu.performed += instance.OnMenu;
                    Menu.canceled += instance.OnMenu;
                }
            }
        }
        public BuildActions @Build => new BuildActions(this);

        // Camera
        private readonly InputActionMap m_Camera;
        private ICameraActions m_CameraActionsCallbackInterface;
        private readonly InputAction m_Camera_Zoom;
        public struct CameraActions
        {
            private Actions m_Wrapper;
            public CameraActions(Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
            public InputActionMap Get() { return m_Wrapper.m_Camera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
            public void SetCallbacks(ICameraActions instance)
            {
                if (m_Wrapper.m_CameraActionsCallbackInterface != null)
                {
                    Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                    Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                    Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                }
                m_Wrapper.m_CameraActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Zoom.started += instance.OnZoom;
                    Zoom.performed += instance.OnZoom;
                    Zoom.canceled += instance.OnZoom;
                }
            }
        }
        public CameraActions @Camera => new CameraActions(this);
        private int m_controlschemeSchemeIndex = -1;
        public InputControlScheme controlschemeScheme
        {
            get
            {
                if (m_controlschemeSchemeIndex == -1) m_controlschemeSchemeIndex = asset.GetControlSchemeIndex("control scheme");
                return asset.controlSchemes[m_controlschemeSchemeIndex];
            }
        }
        public interface IMovementActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
        }
        public interface IAbilitySelectActions
        {
            void OnFour(InputAction.CallbackContext context);
            void OnThree(InputAction.CallbackContext context);
            void OnTwo(InputAction.CallbackContext context);
            void OnOne(InputAction.CallbackContext context);
        }
        public interface IAbilityUseActions
        {
            void OnUse(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnAimPress(InputAction.CallbackContext context);
        }
        public interface IBuildActions
        {
            void OnMenu(InputAction.CallbackContext context);
        }
        public interface ICameraActions
        {
            void OnZoom(InputAction.CallbackContext context);
        }
    }
}
