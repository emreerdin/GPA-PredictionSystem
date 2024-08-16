using UnityEditor;
using UnityEngine;
using System.IO;
using UnityEditor.Scripting.Python;
public class MLModel : MonoBehaviour
{
    public static MLModel mlModel;
    private void OnEnable()
    {
        mlModel = this;

    }

    public static void RunPythonModel()
    {
        string scriptPath = Application.dataPath + "/ProjectFolder/new_python_script.py";
        PythonRunner.RunFile(scriptPath);
    }
}
