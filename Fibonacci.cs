/*
The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,

F(0) = 0,   F(1) = 1
F(N) = F(N - 1) + F(N - 2), for N > 1.
Given N, calculate F(N).
/*

public class Solution {
    public int Fib(int N) {
        if(N == 0){
            return 0;
        }
        if (N == 1){
            return 1;
        }
        return Fib(N-1)+Fib(N-2);
    }
}
