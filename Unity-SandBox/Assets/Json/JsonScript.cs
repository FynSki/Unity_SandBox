using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonScript : MonoBehaviour
{
    public InputField inInputField;
    public InputField nameInputField;
    public InputField infoInputField;

    // Update is called once per frame
    public void SaveToJson()
    {
        JsonDataHolding data = new JsonDataHolding();

        data.id = inInputField.text;
        data.name = nameInputField.text;
        data.info = infoInputField.text;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/jsonFile.json" , json);


    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/jsonFile.json");
        JsonDataHolding data = JsonUtility.FromJson<JsonDataHolding>(json);

        inInputField.text = data.id;
        nameInputField.text = data.name;
        infoInputField.text = data.info;

    }

}
