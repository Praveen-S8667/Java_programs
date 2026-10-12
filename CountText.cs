using UnityEngine;
using UnityEngine.InputSystem;

public class CountText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] string para;
    [SerializeField] string text;
    [SerializeField] int number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            TextCounter(text);
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            PrintPattern(number);
        }
    }
    void TextCounter(string text){
        int count=0;
        string[] splitedtext= para.Split(' ');
        for(int i = 0; i < splitedtext.Length; i++)
        {
            if (string.Equals(splitedtext[i],text,System.StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        Debug.Log($"The total count of the text {text} is {count}");
    }
    void PrintPattern(int num)
    {
        int maxStep = num/2;
        for(int i = 0; i <= num/2; i++)
        {
            int step = num/2;
            string str = "";
            for(int j = 0; j < num; j++)
            {
                if (i + j == step&& i+j <= maxStep)
                {
                    str+="*";
                    step+=2;
                }
                else
                {
                    str+=" ";
                }
                
            }
            Debug.Log(str);
            maxStep+=2;
        }
        
    }
}
