using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(OneScriptToRuleThemAll))]
public class OneScriptToRuleThemAllGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Rule"))
        {
            OneScriptToRuleThemAll script = (OneScriptToRuleThemAll) target;
            //script.SetAllScrollsValues();
            //script.AddSelectableAddonComponent();
        }
    }
}
