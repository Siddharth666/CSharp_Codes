public void AllBazicPrograms()
        {
            //12.
            //Reverse all chars of a string
            string NUM = "one two three four";

            string NUM1 = string.Join(" ", NUM.Split(' ').Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine(NUM1);

            //11.
            //Perfect Numbers 28 = 1,2,4,7,14
            Console.WriteLine("Enter the Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == Num)
            {
                Console.WriteLine("It is Perfect");
            }
            else { Console.WriteLine("Not Perfect"); }

            //10. Armostrong
            Console.WriteLine("Enter the Number to Check");
            int n = Convert.ToInt32(Console.ReadLine());
            int r;
            int temp = n;
            int sum = 0;

            while (n > 0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("Not");
            }

            //9. 
            //Palindrome  6556

            int n = 65561;
            int temp = n;
            int r;
            int sum = 0;

            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }

            //8.
            //swap 2 nmbers without temp.
            int a = 54, b = 45;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a + " and " + b);


            //7. Factorial
            int n = 6, a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            Console.WriteLine(a);


            //6. Fibonacci series
            int i, j, n = 15;
            int a = 0, b = 1, c;
            for (i = 2; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }


            //5. All prime and non prime numbers
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int count = 0;
                for (int j = 1; j < n; j++)
                {

                    if (i % j == 0)
                        count++;

                }
                if (count == 2)
                {
                    Console.WriteLine(i + " are prime ");
                }
                else
                    Console.WriteLine(i + " not prime");
            }

            //4. Given no prime Or not
            Console.WriteLine("Enter the Num");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % 2 == 0)
                    flag++;
            }
            if (flag > 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
                Console.WriteLine("Prime");

            //3. Cat if multiple of 3, Tiger if multiple of 5, Lion if multiple of 15

            for (int i = 1; i <= 30; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i + " LION");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " CAT");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " TIGER");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            //2. Greatest among 3

            Console.WriteLine("Enter the three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greatest");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " is greatest");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is greatest");
            }

            //1. 
            //Odd or Even
            Console.WriteLine("Enter number");
            int OE = Convert.ToInt16(Console.ReadLine());
            if (OE % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (OE % 2 != 0)
            {
                Console.WriteLine("Number " + OE + " is an Odd Number");
            }

        }



====================================
STRINGS


{
        public void XYZ(string S)  //Works for both string and INT     // Same for Reverse of A string or INT
        {

            //Console.WriteLine("Enter string");
            //string B = Console.ReadLine();

            //Strings1 S = new Strings1();
            //S.XYZ(B);


            char[] A = S.ToCharArray();

            string reverse = String.Empty;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                reverse = reverse + A[i];
            }
            Console.WriteLine("Reverse is " + reverse);

            if (S == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

        }

        public void CountChar()
        {

            ////Count Characters in a string
            string S = "SIDDHARTHS  BVC";
            char[] SA = S.ToCharArray();

            int count = 0;


            for (int i = SA.Length - 1; i >= 0; i--)
            {
                if (SA[i] != ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count++);
        }
    }

    class strings2
    {
        //Search for element and replace with empty, or $
        public void FindElement()
        {
            Console.WriteLine("Enter a string");
            string S = Console.ReadLine();
            // string S = "MALIK";
            char[] CS = S.ToCharArray();
            Console.WriteLine("Enter Element to Search");
            char F = Convert.ToChar(Console.ReadLine());
            // char F = 'L';
            char T;
            Console.WriteLine("Enter Element to replace it with");
            char R = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i <= CS.Length - 1; i++)
            {
                if (CS[i] == F)
                {
                    T = CS[i];
                    CS[i] = R;


                }

            }
            for (int i = 0; i <= CS.Length - 1; i++)
            {
                Console.Write
                    (CS[i]);
            }

        }
    }


===========================
PATTERNS

public void AllPats()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("O");

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();

            }
            Console.WriteLine("===========Try thos later again");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(i + 64));

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + 64));

                }
                Console.WriteLine();
            }
            Console.WriteLine("=======c======");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(i + 64));

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write((char)(j + 64));

                }
                Console.WriteLine();
            }
            Console.WriteLine("========================");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("==============");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("==============");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("=================");


            for (int i = 0; i <= 5; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("==========");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

=========================
Sort and Search

//1. Linear Search 2. Bubble Sort 3. Binary Search
    class SortSearch1
    {
        public void linear()
        { 
             //Linear Search 
            //int[] A = { 1, 2, 3, 4 };
            
            int[] ARR = new int[5];
            Console.WriteLine("Enter 4 Elements");
            for (int i = 0; i <= 3; i++)
            {
                ARR[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Element to be searched");
            int a = Convert.ToInt32(Console.ReadLine());
            int found;
            for (int i = 0; i <= ARR.Length - 1; i++)
            {
                if (ARR[i] == a)
                {
                    found = 1;

                }
                else
                {
                    found = 0;
                }

                if (found == 1)
                {
                    Console.WriteLine("Element is found - " + ARR[i]);
                    break;
                }
                  else if(found == 0) { Console.WriteLine("Not found"); }
            }
        }

        public void bubble()
        {
            //bubbleSort
            int[] ARR = new int[5];
            int temp = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < 5; i++)
            {
                ARR[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered UnSorted Elements are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ARR[i]);
            }

            for (int i = 0; i < ARR.Length - 1; i++)
            {
                for (int j = i + 1; j < ARR.Length; j++)
                {
                    if (ARR[i] > ARR[j])
                    {
                        temp = ARR[i];
                        ARR[i] = ARR[j];
                        ARR[j] = temp;
                    }


                }
            }
            Console.WriteLine("Ascending Order Is");
            for (int l = 0; l <= ARR.Length - 1; l++)
            {
                Console.WriteLine(ARR[l]);
            }
        }

        public void binary()
        {
            int[] A = new int[5];
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Elements are");
            for (int i = 0; i < A.Length-1; i++)
            {
                Console.WriteLine(A[i]+" ");
            }

            //Sorting & then Binary Search
            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted in ASC is: ");
            for (int l = 0; l <= A.Length - 1; l++)
            {
                Console.WriteLine(A[l]+" ");
            }

            int keynum, low = 1;
            int high = A.Length-1, mid;
            Console.WriteLine("Enter Element to Search");
            keynum = Convert.ToInt32(Console.ReadLine());

            do
            {
                mid = (low+high)/2;
                if(keynum<A[mid])
                    high = mid-1;
                if(keynum>A[mid])
                    low = mid+1;
            }
            while(keynum!=A[mid] && low<=high);

            if(keynum == A[mid])
                Console.WriteLine("Element "+ A[mid] +" is found at location "+mid);
            else
                Console.WriteLine("Element Not found");
        }
    }


