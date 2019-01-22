// GENERATED AUTOMATICALLY FROM 'Assets/InputConfig.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class InputConfig : InputActionAssetReference
{
    public InputConfig()
    {
    }
    public InputConfig(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // input
        m_input = asset.GetActionMap("input");
        m_input_position = m_input.GetAction("position");
        m_input_input_forward = m_input.GetAction("input_forward");
        m_input_input_back = m_input.GetAction("input_back");
        m_input_input_right = m_input.GetAction("input_right");
        m_input_input_left = m_input.GetAction("input_left");
        m_input_input_func00 = m_input.GetAction("input_func00");
        m_input_input_func01 = m_input.GetAction("input_func01");
        m_input_input_func02 = m_input.GetAction("input_func02");
        m_input_input_func03 = m_input.GetAction("input_func03");
        m_input_input_func04 = m_input.GetAction("input_func04");
        m_input_input_func05 = m_input.GetAction("input_func05");
        m_input_input_func06 = m_input.GetAction("input_func06");
        m_input_input_func07 = m_input.GetAction("input_func07");
        m_input_input_func08 = m_input.GetAction("input_func08");
        m_input_input_func09 = m_input.GetAction("input_func09");
        m_input_input_func10 = m_input.GetAction("input_func10");
        m_input_input_func11 = m_input.GetAction("input_func11");
        m_input_input_func12 = m_input.GetAction("input_func12");
        m_input_input_func13 = m_input.GetAction("input_func13");
        m_input_input_func14 = m_input.GetAction("input_func14");
        m_input_input_func15 = m_input.GetAction("input_func15");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        if (m_InputActionsCallbackInterface != null)
        {
            input.SetCallbacks(null);
        }
        m_input = null;
        m_input_position = null;
        m_input_input_forward = null;
        m_input_input_back = null;
        m_input_input_right = null;
        m_input_input_left = null;
        m_input_input_func00 = null;
        m_input_input_func01 = null;
        m_input_input_func02 = null;
        m_input_input_func03 = null;
        m_input_input_func04 = null;
        m_input_input_func05 = null;
        m_input_input_func06 = null;
        m_input_input_func07 = null;
        m_input_input_func08 = null;
        m_input_input_func09 = null;
        m_input_input_func10 = null;
        m_input_input_func11 = null;
        m_input_input_func12 = null;
        m_input_input_func13 = null;
        m_input_input_func14 = null;
        m_input_input_func15 = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var inputCallbacks = m_InputActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        input.SetCallbacks(inputCallbacks);
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // input
    private InputActionMap m_input;
    private IInputActions m_InputActionsCallbackInterface;
    private InputAction m_input_position;
    private InputAction m_input_input_forward;
    private InputAction m_input_input_back;
    private InputAction m_input_input_right;
    private InputAction m_input_input_left;
    private InputAction m_input_input_func00;
    private InputAction m_input_input_func01;
    private InputAction m_input_input_func02;
    private InputAction m_input_input_func03;
    private InputAction m_input_input_func04;
    private InputAction m_input_input_func05;
    private InputAction m_input_input_func06;
    private InputAction m_input_input_func07;
    private InputAction m_input_input_func08;
    private InputAction m_input_input_func09;
    private InputAction m_input_input_func10;
    private InputAction m_input_input_func11;
    private InputAction m_input_input_func12;
    private InputAction m_input_input_func13;
    private InputAction m_input_input_func14;
    private InputAction m_input_input_func15;
    public struct InputActions
    {
        private InputConfig m_Wrapper;
        public InputActions(InputConfig wrapper) { m_Wrapper = wrapper; }
        public InputAction @position { get { return m_Wrapper.m_input_position; } }
        public InputAction @input_forward { get { return m_Wrapper.m_input_input_forward; } }
        public InputAction @input_back { get { return m_Wrapper.m_input_input_back; } }
        public InputAction @input_right { get { return m_Wrapper.m_input_input_right; } }
        public InputAction @input_left { get { return m_Wrapper.m_input_input_left; } }
        public InputAction @input_func00 { get { return m_Wrapper.m_input_input_func00; } }
        public InputAction @input_func01 { get { return m_Wrapper.m_input_input_func01; } }
        public InputAction @input_func02 { get { return m_Wrapper.m_input_input_func02; } }
        public InputAction @input_func03 { get { return m_Wrapper.m_input_input_func03; } }
        public InputAction @input_func04 { get { return m_Wrapper.m_input_input_func04; } }
        public InputAction @input_func05 { get { return m_Wrapper.m_input_input_func05; } }
        public InputAction @input_func06 { get { return m_Wrapper.m_input_input_func06; } }
        public InputAction @input_func07 { get { return m_Wrapper.m_input_input_func07; } }
        public InputAction @input_func08 { get { return m_Wrapper.m_input_input_func08; } }
        public InputAction @input_func09 { get { return m_Wrapper.m_input_input_func09; } }
        public InputAction @input_func10 { get { return m_Wrapper.m_input_input_func10; } }
        public InputAction @input_func11 { get { return m_Wrapper.m_input_input_func11; } }
        public InputAction @input_func12 { get { return m_Wrapper.m_input_input_func12; } }
        public InputAction @input_func13 { get { return m_Wrapper.m_input_input_func13; } }
        public InputAction @input_func14 { get { return m_Wrapper.m_input_input_func14; } }
        public InputAction @input_func15 { get { return m_Wrapper.m_input_input_func15; } }
        public InputActionMap Get() { return m_Wrapper.m_input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                position.started -= m_Wrapper.m_InputActionsCallbackInterface.OnPosition;
                position.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnPosition;
                position.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnPosition;
                input_forward.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_forward;
                input_forward.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_forward;
                input_forward.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_forward;
                input_back.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_back;
                input_back.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_back;
                input_back.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_back;
                input_right.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_right;
                input_right.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_right;
                input_right.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_right;
                input_left.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_left;
                input_left.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_left;
                input_left.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_left;
                input_func00.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func00;
                input_func00.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func00;
                input_func00.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func00;
                input_func01.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func01;
                input_func01.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func01;
                input_func01.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func01;
                input_func02.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func02;
                input_func02.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func02;
                input_func02.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func02;
                input_func03.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func03;
                input_func03.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func03;
                input_func03.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func03;
                input_func04.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func04;
                input_func04.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func04;
                input_func04.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func04;
                input_func05.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func05;
                input_func05.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func05;
                input_func05.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func05;
                input_func06.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func06;
                input_func06.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func06;
                input_func06.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func06;
                input_func07.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func07;
                input_func07.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func07;
                input_func07.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func07;
                input_func08.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func08;
                input_func08.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func08;
                input_func08.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func08;
                input_func09.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func09;
                input_func09.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func09;
                input_func09.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func09;
                input_func10.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func10;
                input_func10.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func10;
                input_func10.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func10;
                input_func11.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func11;
                input_func11.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func11;
                input_func11.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func11;
                input_func12.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func12;
                input_func12.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func12;
                input_func12.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func12;
                input_func13.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func13;
                input_func13.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func13;
                input_func13.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func13;
                input_func14.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func14;
                input_func14.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func14;
                input_func14.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func14;
                input_func15.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func15;
                input_func15.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func15;
                input_func15.cancelled -= m_Wrapper.m_InputActionsCallbackInterface.OnInput_func15;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                position.started += instance.OnPosition;
                position.performed += instance.OnPosition;
                position.cancelled += instance.OnPosition;
                input_forward.started += instance.OnInput_forward;
                input_forward.performed += instance.OnInput_forward;
                input_forward.cancelled += instance.OnInput_forward;
                input_back.started += instance.OnInput_back;
                input_back.performed += instance.OnInput_back;
                input_back.cancelled += instance.OnInput_back;
                input_right.started += instance.OnInput_right;
                input_right.performed += instance.OnInput_right;
                input_right.cancelled += instance.OnInput_right;
                input_left.started += instance.OnInput_left;
                input_left.performed += instance.OnInput_left;
                input_left.cancelled += instance.OnInput_left;
                input_func00.started += instance.OnInput_func00;
                input_func00.performed += instance.OnInput_func00;
                input_func00.cancelled += instance.OnInput_func00;
                input_func01.started += instance.OnInput_func01;
                input_func01.performed += instance.OnInput_func01;
                input_func01.cancelled += instance.OnInput_func01;
                input_func02.started += instance.OnInput_func02;
                input_func02.performed += instance.OnInput_func02;
                input_func02.cancelled += instance.OnInput_func02;
                input_func03.started += instance.OnInput_func03;
                input_func03.performed += instance.OnInput_func03;
                input_func03.cancelled += instance.OnInput_func03;
                input_func04.started += instance.OnInput_func04;
                input_func04.performed += instance.OnInput_func04;
                input_func04.cancelled += instance.OnInput_func04;
                input_func05.started += instance.OnInput_func05;
                input_func05.performed += instance.OnInput_func05;
                input_func05.cancelled += instance.OnInput_func05;
                input_func06.started += instance.OnInput_func06;
                input_func06.performed += instance.OnInput_func06;
                input_func06.cancelled += instance.OnInput_func06;
                input_func07.started += instance.OnInput_func07;
                input_func07.performed += instance.OnInput_func07;
                input_func07.cancelled += instance.OnInput_func07;
                input_func08.started += instance.OnInput_func08;
                input_func08.performed += instance.OnInput_func08;
                input_func08.cancelled += instance.OnInput_func08;
                input_func09.started += instance.OnInput_func09;
                input_func09.performed += instance.OnInput_func09;
                input_func09.cancelled += instance.OnInput_func09;
                input_func10.started += instance.OnInput_func10;
                input_func10.performed += instance.OnInput_func10;
                input_func10.cancelled += instance.OnInput_func10;
                input_func11.started += instance.OnInput_func11;
                input_func11.performed += instance.OnInput_func11;
                input_func11.cancelled += instance.OnInput_func11;
                input_func12.started += instance.OnInput_func12;
                input_func12.performed += instance.OnInput_func12;
                input_func12.cancelled += instance.OnInput_func12;
                input_func13.started += instance.OnInput_func13;
                input_func13.performed += instance.OnInput_func13;
                input_func13.cancelled += instance.OnInput_func13;
                input_func14.started += instance.OnInput_func14;
                input_func14.performed += instance.OnInput_func14;
                input_func14.cancelled += instance.OnInput_func14;
                input_func15.started += instance.OnInput_func15;
                input_func15.performed += instance.OnInput_func15;
                input_func15.cancelled += instance.OnInput_func15;
            }
        }
    }
    public InputActions @input
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new InputActions(this);
        }
    }
}
public interface IInputActions
{
    void OnPosition(InputAction.CallbackContext context);
    void OnInput_forward(InputAction.CallbackContext context);
    void OnInput_back(InputAction.CallbackContext context);
    void OnInput_right(InputAction.CallbackContext context);
    void OnInput_left(InputAction.CallbackContext context);
    void OnInput_func00(InputAction.CallbackContext context);
    void OnInput_func01(InputAction.CallbackContext context);
    void OnInput_func02(InputAction.CallbackContext context);
    void OnInput_func03(InputAction.CallbackContext context);
    void OnInput_func04(InputAction.CallbackContext context);
    void OnInput_func05(InputAction.CallbackContext context);
    void OnInput_func06(InputAction.CallbackContext context);
    void OnInput_func07(InputAction.CallbackContext context);
    void OnInput_func08(InputAction.CallbackContext context);
    void OnInput_func09(InputAction.CallbackContext context);
    void OnInput_func10(InputAction.CallbackContext context);
    void OnInput_func11(InputAction.CallbackContext context);
    void OnInput_func12(InputAction.CallbackContext context);
    void OnInput_func13(InputAction.CallbackContext context);
    void OnInput_func14(InputAction.CallbackContext context);
    void OnInput_func15(InputAction.CallbackContext context);
}
