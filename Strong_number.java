public class Strong_number {
    public static void main(String args[])
    {
        int n=145;
        int m=n;
        int rem ,fact=1,strong=0;
        while(n!=0)
        {
            rem=n%10;
            for(int i=1;i<=rem;i++)
            {
                fact=fact*i;
                //System.out.println(fact);
            }
            strong+=fact;
            fact=1;
            n/=10;

        }
        if(m==strong)
        {
            System.out.println("Strong Number");
        }
    }
    
}
