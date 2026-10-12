using UnityEngine;
using UnityEngine.InputSystem;

public class Student
{
    public string name;
    public int age;
    public string standard;
    public string section;

    // public Student(string name,int age,string standard,string section)
    // {
    //     this.name = name;
    //     this.age = age;
    //     this.standard = standard;
    //     this.section = section;
    // }
}
public class RandomColor : MonoBehaviour
{
    private Renderer previousRenderer;
    public string[] nameList = {"Praveen","kumar","Jai","Sai","Abi","Vijay","Vetri","Jagan","Siva","Ajith"};
    public Student[] students ;
    public string[] sectionList = {"A","B","C","D"};
    public string str="this is string";
    // public Student[] filteredStudent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       students = new Student[nameList.Length];
        //  students = new Student[]{new Student("Praveen",16,"10th","A"),new Student("kumar",17,"11th","B"),new Student("Jai",16,"10th","A"),new Student("Sai",16,"10th","B"),new Student("Abi",16,"10th","A"),
        //  new Student("Vijay",16,"10th","C"),new Student("Vetri",17,"11th","D"),new Student("Jagan",16,"10th","C"),new Student("Siva",16,"10th","D"),new Student("Ajith",16,"10th","D")};
        //  Debug.Log(students[0]?.name);
        for(int i = 0; i < nameList.Length; i++)
        {
            int sectionIndex = UnityEngine.Random.Range(0,4);
            Student data = new Student();
            data.name = nameList[i];
            data.age = UnityEngine.Random.Range(16,18);
            data.standard = $"{UnityEngine.Random.Range(10,13)}th";
            data.section = sectionList[sectionIndex];
            students[i] = data;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            FilterStudent("A");
        }
        else if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            FilterStudent("B");
        }
        else if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            FilterStudent("C");
        }
        else if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            FilterStudent("D");
        }
        // Debug.Log(students[0]);
        // if (Mouse.current.leftButton.wasPressedThisFrame)
        // {
        //     Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        //     RaycastHit hit;

        //     if(Physics.Raycast(ray,out hit))
        //     {
        //         if (previousRenderer!=null)
        //         {
        //             previousRenderer.material.color = Color.gray;
        //         }
        //         Renderer renderer = hit.collider.GetComponent<Renderer>();
        //         // renderer.material.color = Random.ColorHSV();
        //         previousRenderer = renderer;
        //     }
        // }
    }

    void FilterStudent(string target)
    {
        int length = 0;
        for(int i = 0; i < students.Length; i++)
        {
            if(students[i].section == target)
            {
                length++;
            }
        }

        Student[] filteredStudent = new Student[length];

        int counter = 0;
        for(int i = 0; i < students.Length; i++)
        {
            if(students[i].section == target)
            {
                filteredStudent[counter] = students[i];
                counter++;
            }
        }
        // filteredStudent = Array.FindAll(students,value => value.section == target);
        foreach(Student Item in filteredStudent)
        {
            Debug.Log($"Student Name:{Item.name}  Student Section:{Item.section}  Student Standard:{Item.standard}");
        }
        Debug.Log( str.PadLeft(20,'*'));
        Debug.Log(str.StartsWith("this"));
        Debug.Log(string.IsNullOrEmpty("pojkjpopj"));
    }
// {
    
// }
    // void OnMouseDown()
    // {
    //     Debug.Log("on mouse click");
    //     if(cube!= null)
    //     {
    //         cube.material.color = Random.ColorHSV();
    //     }
    // }
}
