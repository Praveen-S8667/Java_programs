
public class Max {
    public static void main(String args[])
    {
        int arr[]={10,20,30,40};
        max(arr);
    }

    static void max(int arr[])
    {
        int m=0;
        for(int i=0;i<4;i++)
        {
            if(arr[i]>arr[m])
            {
                arr[m]=arr[i];
            }
        }
        System.out.println(arr[m]);

    }
    
}
