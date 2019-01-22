using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.UI;

public class InputKey : MonoBehaviour
{ 
    public Dropdown tmd;
    public string DefaultCode;//デフォルトのコード ドロップダウンから調査
    private void Start()
    {
        for (int i = 0; i < InputAccess.KeyCodes.Count; i++)
        {
            Dropdown.OptionData opd = new Dropdown.OptionData();
            if (InputAccess.KeyCodes[i] != null) {
                InputControl ic = InputAccess.KeyCodes[i];
                opd.text = ic.displayName;
            }
            else
            {
                opd.text = null;
            }
            tmd.options.Add(opd);
        }

        if (PlayerPrefs.HasKey(this.name))
        {
            tmd.value = PlayerPrefs.GetInt(this.name);
        }
        else
        {
            int j = 0; tmd.value = 0;
            for (j = 0; j < InputAccess.KeyCodes.Count; j++)
            {
                if (InputAccess.KeyCodes[j] == null && DefaultCode == "")
                {

                    tmd.value = j;
                    break;
                }
                if (InputAccess.KeyCodes[j] != null && InputAccess.KeyCodes[j].displayName == DefaultCode)
                {
                    tmd.value = j;
                    break;
                }
            }
        }
    }
}
