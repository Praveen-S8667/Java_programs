import java.util.*;
public class Duplicate_String {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        String str=sc.nextLine();
        char arr[]=str.toCharArray();
        int count=0;
        for(int i=0;i<arr.length;i++)
        {
            count=0;
            for(int j=1;j<arr.length;j++)
            {
                
                if(arr[i]==arr[j])
                {
                    arr[j]=0;
                    count++;
                }
            }
            if(count>0)
            {
                System.out.print(arr[i]);
            }

        }




    }
    
}
