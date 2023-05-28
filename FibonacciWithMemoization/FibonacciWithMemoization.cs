// See https://aka.ms/new-console-template for more information

class Fibonacci
{
    Dictionary<int, int> memoization = new Dictionary<int, int> ();
    
    //inefficient fibonacci. This runs at exponential time.
    static int inefficientFibonacci (int input)
    {
        int fibonacciNumber;

        if (input == 0) {
            return 0;
        }
        else if (input == 1) {
            return 1;
        }
        else
            fibonacciNumber = inefficientFibonacci(input - 1) + inefficientFibonacci(input - 2);
        return fibonacciNumber;
    }
    
    //memoization: Remember and reuse solutions
    //fibonacci with memoization. this can potentially run at linear time
    static int fibonacciWithMemoization (int input)
    {
        int fibonacciNumber, inputMinusOne = 0, inputMinusTwo = 0;

        if (input == 0){
            return 0;
        }
        else if (input == 1){
            return 1;
        }
        else
        {
            if (memoization.ContainsKey(input))
            {
                return memoization[input];
            }
            else if (memoization.ContainsKey(input - 1))
            {
                inputMinusOne = memoization[input - 1];
            }
            else if (memoization.ContainsKey(input - 2))
            {
                inputMinusTwo = memoization[input - 2];
            }
            else
            {
                inputMinusOne = fibonacciWithMemoization(input - 1);
                inputMinusTwo = fibonacciWithMemoization(input - 2);
                memoization.Add(inputMinusOne)
                memoization.Add(inputMinusTwo)
            }
            fibonacciNumber = inputMinusOne + inputMinusTwo;
            memoization.Add(fibonacciNumber);
        }
    return fibonacciNumber;
    }
}