import java.util.*;
public class Anagram {
    public static void main(String args[])
{
    Scanner sc=new Scanner(System.in);
    String str1=sc.next();
    String str2=sc.next();
    int count=0;
    char arr1[]=str1.toCharArray();
    char arr2[]=str2.toCharArray();
    Arrays.sort(arr1);
    Arrays.sort(arr2);
    if(arr1.length==arr2.length)
    {
    for(int i=0;i<str1.length();i++)
    {
            if(arr1[i]!=arr2[i])
            {
                count++;
            }
    }
    if(count==0)
    System.out.println("anagram");
    else
    System.out.println("Not anagram");
    }
    else
    System.out.println("not anagram");

}
    
}
