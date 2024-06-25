namespace Antra_hw4;

public class Program
{
    static void Main(string[] args)
    {
        
        //printing size of difference variable and century conversion
        VarPrint vp = new VarPrint();
        vp.Print();
        //Fizzbuzz
        FizzBuzz fizzBuzz = new FizzBuzz();
        fizzBuzz.func();
        
        //Print Pyramid
        PrintPyramid pp = new PrintPyramid();
        pp.PrintP(5);
        
        //Number guessing game
        Guessing g = new Guessing();
        g.game();
        
        //Birthday calculator
        BirthdayCalculator bc = new BirthdayCalculator();
        bc.calculate();
        
        //Greet
        Greeting greet = new Greeting();
        greet.greet();
        
        //Count
        Counting c = new Counting();
        c.count();
        
        //Array Practice
        ArrayPractice ap = new ArrayPractice();
        ap.arraycopy();
        
        //Manage Element
        ap.ManageElement();
        
        //Print all prime numbers in range
        ap.PrintArray(ap.FindPrimesInRange(0, 20));
        
        //Rotate array k times and sum the obtained array
        RotateSum RS = new RotateSum();
        RS.start();
        
        //Find longest sequence of equal elements
        LongestSeq ls = new LongestSeq();
        ls.longest_seq();
        
        //Find most frequent element
        FreqElement fe = new FreqElement();
        fe.find_freq();

        //Reverse the string using two methods
        ReverseString rs = new ReverseString();
        rs.reverse();
        
        //Reverse sentance without punctuation
        SentenceReverse sr = new SentenceReverse();
        sr.reverse();
        
        //Find all palindrome
        FindPalindrome fp = new FindPalindrome();
        fp.find();

        Parse_URL purl = new Parse_URL();
        purl.parse();



    }
}