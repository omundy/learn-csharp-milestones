using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int a = 10;
    public float b = 10.0f;
    private string c = "10";
    private string sample = "5";
    private bool d = false;

    

    //single line comment

    /*
     * multi line comment
     */

    /// <summary>
    /// summary comment
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
        Debug.LogFormat("int: {0}, float: {1}", a, b);
        string concat = c + sample;
        string interp = $"{c}{sample}";
        Debug.Log(example(a, a));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int example(int inputA, int inputB)
    {
        return inputA + inputB;
    }
}
