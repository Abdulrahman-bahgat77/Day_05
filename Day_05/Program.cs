namespace Day_05
{
      class Data
    {
        public int sum { get; set; }
        public int mul { get; set; }
    }
    internal class Program
    {

        //public  static void printshape(int count,string shape)
        //{
        //    for(int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine (shape);
        //    }
        //}
        //public static void swap(  int x,    int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;

        //}
        public static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;

        }
        //////////////
      

        ////////
        // public static Data sunMul(int x, int y)
        //{
        //    int sum = x + y;
        //    int mul = x * y;
        //    //Data d = new Data();
        //    //d.sum = sum;
        //    //d.mul = mul;
        //    //return d;

        //    return new Data() { mul = mul, sum = sum };
        //}

       public static void sunMul(int x, int y,out int sum,out int mul)
        {
              sum = x + y;
              mul = x * y;



        }


        /////
          public static int sumarray(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
static void Main(string[] args)
        {
            #region Casing[Boxing-unBoxing]
            //boxing ==> casting from value type to refernence type
            // un boxing ==> casting from reference type to value type
            //object o1;
            //o1 = "abdo";
            //o1 = 1;

            //int x = 10;
            //object obj =10;


            //object obj = 10;
            //int y = (int)obj; //unboxing==> [unsafe casting]
            //Console.WriteLine(y);
            #endregion


            #region Nullable type
            #region value type
            // null as value is valid only with reference type

            //int x = 10;
            //int ? y = x;

            //int? k = null;
            //int l;

            //if (k.HasValue) {
            //    l = (int)k;
            //}
            //else
            //{
            //    l = 0;
            //}
            #endregion

            #region reference type
            // Null is default value of references type

            //string message = "hi";
            //message = null;
            //message = null!; //forgiveness operator

            //string? message = null!;

            //Console.WriteLine(message);

            //string notnull = "hello";
            //string? nullable =default;

            //notnull = nullable!;

            #endregion

            #endregion

            #region Null propagation operator
            //int[] numbers=default;
            //for (int i = 0;(numbers!=null) && i < numbers.Length; i++)
            //for (int i = 0;  i<numbers?.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //if (numbers != null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion


            #region Function
            // function : is a reusable code
            // namepace can contain(class -interface-struct-enum)
            // class can contain(function-data)

            // function:
            //1.class member function(static function)
            //2. object member function(non-ststaic function)

            /*printshape(10,":)");*/ // passsing parameter

            //skip /==>@
            //printshape (3,@"/*\");


            #endregion

            #region passing parameters

            #region  passing by value
            //int a = 10,b=20;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //swap(  a,  b);
            //Console.WriteLine("swapping");
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            #endregion

            #region passing by ref
            //int a = 10, b = 20;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //swap(ref a,ref b);
            //Console.WriteLine("swapping");
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int summation = sumarray(numbers); // passing by value
            //Console.WriteLine($"sum ={summation}");

            #endregion

            #region passign by out
            //int a = 10, b = 20;
            //int sumres, mulres;
            //sunMul(a, b, out sumres, out mulres);
            //Console.WriteLine($"sum={sumres} , mul={mulres}");
            #endregion

            #region passing params

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int result =sumarray(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(result);
            #endregion
            #endregion
        }
    }

}