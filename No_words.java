import java.util.*;
public class No_words {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        String str1=sc.nextLine();
        int count=0;
        //System.out.println(str1.length());
        for(int i=0;i<str1.length();i++)
        {
            if(str1.charAt(i)==' '||i==str1.length()-1)
            {
                count++;
                //System.out.println(str1.charAt(i));
            }
        }
        System.out.println(count);
    }
    
}
