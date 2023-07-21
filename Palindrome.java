import java.util.Scanner;
public class Palindrome {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        int n=sc.nextInt();
        int org,rem;
        int rev=0;
        org=n;
        while(n!=0)
        {
            rem=n%10;
            rev=rev*10+rem;
            n/=10;
        }
        //printf("%d",rev);
        if(rev==org)
        {
            System.out.println("Original"+org);
            System.out.println("Reverse"+rev);
            System.out.println("palindrome");
        }
        else
        {
            System.out.println("Not palindrome");
        }
    }
    
}
