using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.UI;
public class InputAccess : MonoBehaviour, IInputActions
{

    public InputConfig input;
    public GameObject ConfigWindow;
    public List<InputKey> ipks;
    public static List<InputControl> KeyCodes;
    public float speed  = 1;
    Rigidbody rig;
    float x, y,z;
    private void Awake()
    {
        InputControl[] icmouse = Mouse.current.children.ToArray();
        InputControl[] ickeyboard = Keyboard.current.children.ToArray();
        KeyCodes = new List<InputControl>();
        KeyCodes.Add(null);   //empty
        KeyCodes.AddRange(icmouse);//keyboard
        KeyCodes.AddRange(ickeyboard);//keyboard
        input.input.SetCallbacks(this);

        rig = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        input.Enable();
        chagebind();

    }
    private void OnDisable()
    {

        input.Disable();

    }
    public void defaultButton()
    {
        for (int i = 0; i < ipks.Count; i++)
        {
            InputKey ipk = ipks[i];
            Dropdown tmd = ipk.tmd;
            int j = 0; tmd.value = 0;
            for (j = 0; j < KeyCodes.Count; j++)
            {
                if (KeyCodes[j] == null && ipk.DefaultCode == "")
                {
                    tmd.value = j;
                    break;
                }
                if (KeyCodes[j] != null && KeyCodes[j].displayName == ipk.DefaultCode)
                {
                    tmd.value = j;
                    break;
                }
            }
        }

    }

    public void LoadButton()
    {
        for (int i = 0; i < ipks.Count; i++)
        {
            if (PlayerPrefs.HasKey(ipks[i].name))
            {
                ipks[i].tmd.value = PlayerPrefs.GetInt(ipks[i].name);
            }
        }
    }
    public void SaveButton()
    {
        for (int i = 0; i < ipks.Count; i++)
        {
            PlayerPrefs.SetInt(ipks[i].name, ipks[i].tmd.value);
        }
        PlayerPrefs.Save();
        chagebind();
    }
    void chagebind()
    {
        InputActionMap iam = input.input.Get();
        InputAction[] ia = iam.actions.ToArray();
        input.Disable();

        for (int i = 0; i < ia.Length; i++)
        {
            if (PlayerPrefs.HasKey(ia[i].name + "0"))
            {
                int pref0 = PlayerPrefs.GetInt(ia[i].name + "0");
                if (KeyCodes[pref0] == null) {
                    ia[i].ApplyBindingOverride(0, "<>/");
                } else
                {
                    string[] path = KeyCodes[pref0].path.Split('/');
                    ia[i].ApplyBindingOverride(0, "<" + path[1] + ">/" + path[2]);
                }
                
                int pref1 = PlayerPrefs.GetInt(ia[i].name + "1");
                if (KeyCodes[pref1] == null)
                {
                    ia[i].ApplyBindingOverride(1, "<>/");
                }
                else
                {
                    string[] path = KeyCodes[PlayerPrefs.GetInt(ia[i].name + "1")].path.Split('/');
                    ia[i].ApplyBindingOverride(1, "<" + path[1] + ">/" + path[2]);
                }

            }
        }
        input.Enable();
    }

    public void CancelButton()
    {
        ConfigWindow.SetActive(false);
    }



    //以下各種コントロール 今回はPlayerにこれ張り付けてるから直接Rigibodyに
    private void FixedUpdate()
    {
        rig.velocity = transform.forward * z + transform.right * x + transform.up * -4.9f;
    }
    public void OnPosition(InputAction.CallbackContext context)
    {

    }
    public void OnInput_forward(InputAction.CallbackContext context)
    {
        z = context.ReadValue<float>() == 0 ? 0 : speed;
    }
    public void OnInput_back(InputAction.CallbackContext context)
    {
        z = context.ReadValue<float>() == 0 ? 0 : -speed;
    }
    public void OnInput_right(InputAction.CallbackContext context) {

        x = context.ReadValue<float>() == 0 ? 0 : speed;
    }
    public void OnInput_left(InputAction.CallbackContext context) {
        x = context.ReadValue<float>() == 0 ? 0 : -speed;
    }
    public void OnInput_func00(InputAction.CallbackContext context) { }
    public void OnInput_func01(InputAction.CallbackContext context) { }
    public void OnInput_func02(InputAction.CallbackContext context) { }
    public void OnInput_func03(InputAction.CallbackContext context) { }
    public void OnInput_func04(InputAction.CallbackContext context) { }
    public void OnInput_func05(InputAction.CallbackContext context) { }
    public void OnInput_func06(InputAction.CallbackContext context) { }
    public void OnInput_func07(InputAction.CallbackContext context) { }
    public void OnInput_func08(InputAction.CallbackContext context) { }
    public void OnInput_func09(InputAction.CallbackContext context) { }
    public void OnInput_func10(InputAction.CallbackContext context) { }
    public void OnInput_func11(InputAction.CallbackContext context) { }
    public void OnInput_func12(InputAction.CallbackContext context) { }
    public void OnInput_func13(InputAction.CallbackContext context) { }
    public void OnInput_func14(InputAction.CallbackContext context) { }
    public void OnInput_func15(InputAction.CallbackContext context) { }

}
