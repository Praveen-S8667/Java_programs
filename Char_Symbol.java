import java.util.*;
public class Char_Symbol {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        char num=sc.next().charAt(0);
        if(num>='a'&&num<='z'||num>='A'&&num<='Z')
        {
            System.out.println("Character");
        }
        if(num>='0'&&num<='9')
        {
            System.out.println("Number");
        }
        else
        {
            System.out.println("Special Character");
        }

    }
    
}
