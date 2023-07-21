import java.lang.Math;
public class Amstrong {
    public static void main(String args[])
    {
        //Scanner sc=new Scanner(System.in);
        //int n=sc.nextInt();
       for(int n=153;n<=200;n++)
        {
        //int n=153;
        int x,m,rem,res=0,base,exponent,count=0;
        m=n;
        x=n;
        while(m!=0)
        {
            //m=n;
            //r=m%10;
            count++;
            m=m/10;     

        }
        m=n;
        //System.out.println(m);
        while(m!=0)
        System.out.print(m);
        {
            rem=m%10;
            base=rem;
            exponent=count;
            res+=(int)Math.pow(base,exponent);
            m=m/10;
            
        }
        System.out.print(res);
    

        if(x==res)
        {
            System.out.print(res);
        }
    }
    

}
}
    

