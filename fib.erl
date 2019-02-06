-module(fib).
-export([fib/1,start/0]).

fib(N) when N<2 -> N;
fib(N) -> fib(N-1) + fib(N-2).

start() ->
    io:fwrite("Out: ~w", [fib(10)]).