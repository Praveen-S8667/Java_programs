import java.util.*;
public class Adem {
    public static void main(String args[])
    {
        Scanner sc=new Scanner(System.in);
        int n=sc.nextInt();
        int m,rem1,rem2,rev1=0,rev2=0,count=0,square1,square2,base,exponent;
        m=n;
        while(n!=0)
        {
            rem1=n%10;
            rev1=rev1*10+rem1;
            count++;
            n/=10;

        }
        base=m;
        exponent=count;
        square1=(int)Math.pow(base,exponent);
        // System.out.println(square1);

        base=rev1;
        exponent=count;
        square2=(int)Math.pow(base,exponent);
        // System.out.println(square2);


        while(square2!=0)
        {
            rem2=square2%10;
            rev2=rev2*10+rem2;
            square2/=10;

        }
        if(square1==rev2)
        {
            System.out.println("Adam Number");
        }
        else
        {
            System.out.println("Not Adam Number");
        }



    }
    
}
