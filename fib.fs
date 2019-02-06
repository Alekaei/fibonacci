open System

let rec fib n = 
  match n with
    | n when n <= 1 -> n
    | _ -> fib(n - 1) + fib(n - 2)

Console.WriteLine(fib 10)