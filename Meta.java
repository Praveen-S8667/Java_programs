import java.util.*;
public class Meta {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        String str1=sc.next();
        String str2=sc.next();
        int count=0;
        for(int i=0;i<str1.length();i++)
        {
            if(str1.charAt(i)!=str2.charAt(i))
            {
                count++;
            }
        }
        //System.out.println(count);
        if(count==2)
        {
            System.out.println("Yes");
        }
        else{
            System.out.println("No");
            
        }

    }
    
}
