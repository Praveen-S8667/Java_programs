import java.util.*;
public class Smallest_word {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        String str=sc.nextLine();
        String arr[]=str.split(" ");
        String min=arr[0];
        String max=arr[0];
        for(int i=0;i<arr.length;i++)
        {
            for(int j=i+1;j<arr.length;j++)
              
                if(arr[i].length()>arr[j].length())
                {
                    min=arr[j];
                    
                }
            for(int k=i+1;k<arr.length;k++)
                if(arr[i].length()<arr[k].length())
                {
                    max=arr[k];
                    
                }
        }
        System.out.println(min);
        System.out.println(max);

    }
    
}
